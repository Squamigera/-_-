using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_Задание_4
{
    public class User
    {
        public int ID_сущности { get; set; }
        public string Логин { get; set; }
        public UserRole Роль { get; set; }
        public int? ID_поставщика { get; set; } // Может быть null
        public int? ID_партнера { get; set; }   // Может быть null
    }
    
    public enum UserRole
    {
        Администратор = 0,
        Менеджер = 1,
        Поставщик = 2,
        Партнер = 3
    }
    public static class DiscountHelper
    {
        public static decimal CalculateDiscount(decimal totalSalesAmount)
        {
            if (totalSalesAmount < 10000)
                return 0;
            else if (totalSalesAmount < 50000)
                return 5;
            else if (totalSalesAmount < 300000)
                return 10;
            else
                return 15;
        }
    }
    public class AuthService
    {
        private readonly string _connectionString;

        public AuthService(string connectionString = null)
        {
            _connectionString = connectionString ?? ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public User Authenticate(string login, string password)
        {
            string query = @"
                SELECT 
                    ID_пользователя AS ID_сущности,
                    Логин,
                    Роль,
                    ID_поставщика,
                    ID_партнера
                FROM Пользователи 
                WHERE Логин = @login AND Пароль = @password";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    ID_сущности = reader.GetInt32(0),
                                    Логин = reader.GetString(1).Trim(),
                                    Роль = ParseUserRole(reader.GetInt32(2)),
                                    ID_поставщика = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                                    ID_партнера = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // В продакшене — логируйте, но не показывайте детали
                throw new Exception("Ошибка аутентификации", ex);
            }

            return null;
        }

        public UserRole ParseUserRole(int roleInt)
        {
            switch (roleInt)
            {
                case 0: return UserRole.Администратор;
                case 1: return UserRole.Менеджер;
                case 2: return UserRole.Поставщик;
                case 3: return UserRole.Партнер;
                default: return UserRole.Менеджер;
            }
        }
    }
}
