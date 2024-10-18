using System;
using System.Data.SQLite;
namespace ігри.Data
{
    public class UserService : IUserService
    {
        private readonly string _connectionString;

        public UserService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void RegisterUser(string username, string password, string achievements, string url)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                string checkUserQuery = @"SELECT COUNT(*) FROM User_data WHERE User_name = @UserName";

                using (SQLiteCommand checkCmd = new SQLiteCommand(checkUserQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@UserName", username);
                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        throw new Exception("Користувач з таким ім'ям вже існує.");
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
                }
            }
        }
    }
}
