using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace УП_Задание_4
{
    public partial class LoginForm : Form
    {
        public event Action<Form> SuccessfulLogin;
        public static LoginForm Instance;

        public LoginForm()
        {
            InitializeComponent();
            Instance = this;
        }
       
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var authService = new AuthService();
            User user = authService.Authenticate(login, password);

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form mainForm;
            switch (user.Роль)
            {
                case UserRole.Администратор:
                    mainForm = new AdminMainForm(user);
                    break;
                case UserRole.Менеджер:
                    mainForm = new ManagerMainForm(user);
                    break;
                case UserRole.Партнер:
                    if (user.ID_партнера.HasValue)
                        mainForm = new PartnersMainForm(user, user.ID_партнера.Value);
                    else
                    {
                        MessageBox.Show("Ваш аккаунт не привязан к партнёру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case UserRole.Поставщик:
                    if (user.ID_поставщика.HasValue)
                        mainForm = new SuppliersMainForm(user, user.ID_поставщика.Value);
                    else
                    {
                        MessageBox.Show("Ваш аккаунт не привязан к поставщику.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                default:
                    mainForm = new ManagerMainForm(user);
                    break;
            }

            // Сначала показываем главную форму
            mainForm.Show();

            // Затем закрываем форму входа
            this.Hide();
        }

        internal User AuthenticateUser(string login, string password)
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
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                                    Логин = reader.GetString(1),
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
                MessageBox.Show($"Ошибка подключения к БД: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        internal UserRole ParseUserRole(int roleInt)
        {
            switch (roleInt)
            {
                case 0:
                    return UserRole.Администратор;
                case 1:
                    return UserRole.Менеджер;
                case 2:
                    return UserRole.Поставщик;
                case 3:
                    return UserRole.Партнер;
                default:
                    return UserRole.Менеджер;
            }
        }

        public void ClearLoginFields()
        {
            txtLogin.Clear();
            txtPassword.Clear();
            txtLogin.Focus();
        }
    }
}

