using System;

namespace habit_tracker

{
    class Program
    {
        static void Main(string[] args)
    {
        string connectingString = @"Data Source=habit-Tracker.db"        

        using (var connection = new SqliteConnection(connectingString)) {
            connection.Open();
            var tableCmd = connection.CreateCommand

            tableCmd.CommandText = "";

            tableCmd.ExecuteNonQuery();

            connection.Close();

            }

        }
    }

}

