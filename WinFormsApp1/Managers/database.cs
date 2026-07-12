using System.Data.SQLite;
using SpaceShooter.Database;

namespace SpaceShooter.Database
{
    public class Database
    {
        private readonly string _databasePath;
        private readonly string _connectionString;

        public Database()
        {
            _databasePath = "data_game.db";
            _connectionString = $"Data Source={_databasePath};Version=3;";
        }

        public void InitializeDatabase()
        {
            if (!File.Exists(_databasePath))
            {
                SQLiteConnection.CreateFile(_databasePath);
            }

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string playerTableQuery = @"
                    CREATE TABLE IF NOT EXISTS PlayerData
                    (
                        Id INTEGER PRIMARY KEY,
                        TotalCoins INTEGER NOT NULL,
                        HighScore INTEGER NOT NULL
                    );
                ";

                const string shopTableQuery = @"
                    CREATE TABLE IF NOT EXISTS ShopItems
                    (
                        Id INTEGER PRIMARY KEY,
                        ItemName TEXT NOT NULL,
                        IsPurchased INTEGER NOT NULL,
                        IsEquipped INTEGER NOT NULL
                    );
                ";

                using (var command = new SQLiteCommand(playerTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(shopTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                SeedPlayerData(connection);

                SeedShopItems(connection);
            }
        }

        private void SeedPlayerData(SQLiteConnection connection)
        {
            const string query = @"
                INSERT INTO PlayerData (Id, TotalCoins, HighScore)
                SELECT 1, 0, 0
                WHERE NOT EXISTS
                (
                    SELECT 1
                    FROM PlayerData
                    WHERE Id = 1
                );
            ";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void SeedShopItems(SQLiteConnection connection)
        {
            const string query = @"
                INSERT INTO ShopItems
                    (Id, ItemName, IsPurchased, IsEquipped)

                SELECT 1, 'Red Ship', 1, 1
                WHERE NOT EXISTS (SELECT 1 FROM ShopItems WHERE Id = 1);

                INSERT INTO ShopItems
                    (Id, ItemName, IsPurchased, IsEquipped)

                SELECT 2, 'Blue Ship', 0, 0
                WHERE NOT EXISTS (SELECT 1 FROM ShopItems WHERE Id = 2);

                INSERT INTO ShopItems
                    (Id, ItemName, IsPurchased, IsEquipped)

                SELECT 3, 'Green Ship', 0, 0
                WHERE NOT EXISTS (SELECT 1 FROM ShopItems WHERE Id = 3);
            ";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public PlayerData GetPlayerData()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
                    SELECT
                        TotalCoins,
                        HighScore
                    FROM PlayerData
                    WHERE Id = @Id;
                ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", 1);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PlayerData
                            {
                                TotalCoins = Convert.ToInt32(reader["TotalCoins"]),
                                HighScore = Convert.ToInt32(reader["HighScore"])
                            };
                        }
                    }
                }
            }

            throw new InvalidOperationException("Player data was not found.");
        }

        public List<ShopItem> GetShopItems()
        {
            var items = new List<ShopItem>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
            SELECT
                Id,
                ItemName,
                IsPurchased,
                IsEquipped
            FROM ShopItems;
        ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new ShopItem
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            ItemName = reader["ItemName"].ToString(),
                            IsPurchased = Convert.ToInt32(reader["IsPurchased"]) == 1,
                            IsEquipped = Convert.ToInt32(reader["IsEquipped"]) == 1
                        });
                    }
                }
            }

            return items;
        }
        public bool UpdateCoins(int totalCoins)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
                    UPDATE PlayerData
                    SET TotalCoins = @Coins
                    WHERE Id = @Id;
                ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Coins", totalCoins);
                    command.Parameters.AddWithValue("@Id", 1);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateHighScore(int highScore)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
                    UPDATE PlayerData
                    SET HighScore = @HighScore
                    WHERE Id = @Id;
                ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HighScore", highScore);
                    command.Parameters.AddWithValue("@Id", 1);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EquipItem(int itemId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        const string resetQuery = @"
                            UPDATE ShopItems
                            SET IsEquipped = 0;
                        ";

                        using (var resetCommand = new SQLiteCommand(resetQuery, connection, transaction))
                        {
                            resetCommand.ExecuteNonQuery();
                        }

                        const string equipQuery = @"
                            UPDATE ShopItems
                            SET IsEquipped = 1
                            WHERE Id = @Id;
                        ";

                        using (var equipCommand = new SQLiteCommand(equipQuery, connection, transaction))
                        {
                            equipCommand.Parameters.AddWithValue("@Id", itemId);

                            bool success = equipCommand.ExecuteNonQuery() > 0;

                            transaction.Commit();

                            return success;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public bool PurchaseItem(int itemId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
                    UPDATE ShopItems
                    SET IsPurchased = 1
                    WHERE Id = @Id;
                ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", itemId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}