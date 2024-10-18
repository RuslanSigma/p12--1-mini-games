using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
namespace ігри.Pages
{
    public class sql
    {


        string connectionString = @"Data Source=C:\Users\ggg81\OneDrive\Робочий стіл\SQL Server Scripts1\SQL Server Scripts1\SQL Server Scripts1\SQL Server Scripts1";

        public static void RegisterUser(string username, string password, string achievements, string url, string connectionString)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string checkUserQuery = @"SELECT COUNT(*) FROM User_data WHERE User_name = @UserName";

                using (SQLiteCommand checkCmd = new SQLiteCommand(checkUserQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@UserName", username);
                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        Console.WriteLine("Користувач з таким ім'ям вже існує.");
                        return;
                    }
                }

                string insertQuery = @"INSERT INTO User_data (User_name, User_password, User_achievements, User_URL) 
                               VALUES (@UserName, @UserPassword, @UserAchievements, @UserURL);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@UserPassword", password);
                    cmd.Parameters.AddWithValue("@UserAchievements", achievements);
                    cmd.Parameters.AddWithValue("@UserURL", url);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Користувача успішно зареєстровано.");
                }
            }
        }
        static bool SignUser(string username, string password, string email, string connectionString)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM User_data;";
                using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["User_id"]}, Name: {reader["User_name"]}, Achievements: {reader["User_achievements"]}, URL: {reader["User_URL"]}");
                        }
                    }
                }
                return true;
            }

        }

    }

}
