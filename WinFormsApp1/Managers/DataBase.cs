using System;
using System.IO;
using System.Data.SQLite;

namespace SpaceShooter.Database
{
    public class Database
    {
        private readonly string _databasePath;
        private readonly string _connectionString;

        public Database(string? databasePath = null)
        {
            _databasePath = databasePath ??
                            Path.Combine(AppContext.BaseDirectory, "data_game.db");

            _connectionString = $"Data Source={_databasePath};Version=3;"; _connectionString = $"Data Source={_databasePath};Version=3;";
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
                SELECT 1, 1500, 0
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

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 1,1,1
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=1);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 2,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=2);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 3,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=3);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 4,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=4);



    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 101,1,1
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=101);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 102,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=102);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 103,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=103);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 104,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=104);



    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 201,1,1
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=201);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 202,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=202);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 203,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=203);

    INSERT INTO ShopItems (Id, IsPurchased, IsEquipped)
    SELECT 204,0,0
    WHERE NOT EXISTS(SELECT 1 FROM ShopItems WHERE Id=204);

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
                        string resetQuery;

                        if (itemId >= 1 && itemId <= 4)
                        {
                            resetQuery = @"
                                UPDATE ShopItems
                                SET IsEquipped = 0
                                WHERE Id BETWEEN 1 AND 4;
                            ";
                        }
                        else if (itemId >= 101 && itemId <= 104)
                        {
                            resetQuery = @"
                                UPDATE ShopItems
                                SET IsEquipped = 0
                                WHERE Id BETWEEN 101 AND 104;
                            ";
                        }
                        else if (itemId >= 201 && itemId <= 204)
                        {
                            resetQuery = @"
                                UPDATE ShopItems
                                SET IsEquipped = 0
                                WHERE Id BETWEEN 201 AND 204;
                            ";
                        }
                        else
                        {
                            return false;
                        }

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

        public bool UnEquipItem(int itemId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
            UPDATE ShopItems
            SET IsEquipped = 0
            WHERE Id = @Id;
        ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", itemId);

                    return command.ExecuteNonQuery() > 0;
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

        public bool SellItem(int itemId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
                    UPDATE ShopItems
                    SET IsPurchased = 0,
                        IsEquipped = 0
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