using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public class UserService : IUserService
    {
        private string connectionString = @"Data Source=DESKTOP-RGPQP6I\TFTIC2019;Initial Catalog=TFNetCore;Integrated Security=True;";

        public IEnumerable<User> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new User
                            {
                                Id = (int)reader["Id"],
                                Email = reader["Email"].ToString(),
                                Nickname = reader["Nickname"].ToString()

                            };
                        }
                    }
                }
            }


        }
        public void Create(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Users (Email, Nickname, Password) " +
                        "VALUES(@mail, @nick, @pwd)";

                    cmd.Parameters.AddWithValue("mail", user.Email);
                    cmd.Parameters.AddWithValue("nick", user.Nickname);
                    cmd.Parameters.AddWithValue("pwd", user.Password);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
