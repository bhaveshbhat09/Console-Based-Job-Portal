using ConsoleApp1.Config;
using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Repositories
{
    public class UserRepo
    {
        public bool RegisterUser(User user)
        {
            using(SqlConnection conne = new SqlConnection(DbConfig.ConnectionString))
            {
                String sql = @"INSERT INTO Users (FullName, Email, Password, Role, IsActive, CreatedAt)
                        Values (@FullName, @Email, @Password, @Role, @IsActive, @CreatedAt)";
                using(SqlCommand command = new SqlCommand(sql, conne))
                {
                    command.Parameters.AddWithValue("@FullName", user.FullName);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role.ToString());
                    command.Parameters.AddWithValue("@IsActive", user.IsActive);
                    command.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);
                    conne.Open();
                    int affectedRow = command.ExecuteNonQuery();

                    return affectedRow > 0;
                }
            }
        }

        public User? LoginUser(String email, String Password)
        {
            using(SqlConnection connection = new SqlConnection(DbConfig.ConnectionString))
            {
                string sql = @"Select userId, FullName, Email, Password, Role, IsActive, CreatedAt From Users
                            Where Email = @Email AND Password = @Password AND IsActive =1";
                using(SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    connection.Open();

                    using(SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            User user = new User();

                            user.UserId = Convert.ToInt32(rd["UserId"]);

                        }
                    }
                }
            }
        }
    }
}
