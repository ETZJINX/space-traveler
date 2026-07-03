using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace WinFormsApp1.Managers
{
    internal class database
    {
        SQLiteConnection connection;
        public database()
        {
            connection = new SQLiteConnection("Data Source=game.db;Version=3;");
            Shipcreattable();
            Personcreattable();
        }
        public void Shipcreattable()
        {
            connection.Open();
            SQLiteCommand command;
            string sql1 = "CREATE TABLE IF NOT EXISTS shop(SHIPID INTEGER PRIMARY KEY,SHIPNAME TEXT ,SHIPDAMAGE REAL,SHIPHEALTH INTEGER,SHIPLEVEL TEXT )";
            command = new SQLiteCommand(sql1,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Personcreattable()
        {
            connection.Open();
            SQLiteCommand command;
            string sql1 = "CREATE TABLE IF NOT EXISTS persons(PERSONID INTEGER PRIMARY KEY,PERSONNAME TEXT ,PERSONLEVEL TEXT ,PERSONCOIN INTEGER , PERSONSCORE INTEGER)";
            command = new SQLiteCommand(sql1, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddShip()
        {

        }
        public void AddPerson()
        {

        }
        public void EditShip()
        {

        }
        public void DeleteShip()
        {
        }
        public void EditPerson()
        {

        }
        public void DeletePerson()
        {

        }
        
    
    }
}
