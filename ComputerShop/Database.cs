using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    internal class Database
    {
        private static string constring = "";

        public static async Task<bool> login(string username, string password)
        {
            using (var conn = new NpgsqlConnection(constring))
            {
                await conn.OpenAsync();
                string query = "SELECT COUNT(login) FROM computer_shop.admin WHERE login = @username AND password = @password;";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    

                    if (Convert.ToInt64(await cmd.ExecuteScalarAsync()) == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }
        }
    }
}
