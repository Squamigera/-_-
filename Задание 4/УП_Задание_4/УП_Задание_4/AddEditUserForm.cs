using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_Задание_4
{
    public partial class AddEditUserForm : Form
    {
        private int? userId = null;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public AddEditUserForm()
        {
            InitializeComponent();
            InitializeRoles();
        }

        public AddEditUserForm(int id) : this()
        {
            userId = id;
            LoadUserData();
        }

        private void InitializeRoles()
        {
            cmbRole.Items.Add(new { Name = "Администратор", Value = 1 });
            cmbRole.Items.Add(new { Name = "Менеджер", Value = 2 });
            cmbRole.Items.Add(new { Name = "Поставщик", Value = 3 });
            cmbRole.Items.Add(new { Name = "Партнер", Value = 4 });

            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Value";
        }

        private void LoadUserData()
        {
            string query = "SELECT Логин, Пароль, Роль FROM Пользователи WHERE ID_пользователя = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", userId);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtLogin.Text = reader["Логин"].ToString();
                                txtPassword.Text = reader["Пароль"].ToString();
                                cmbRole.SelectedValue = Convert.ToInt32(reader["Роль"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query;
                    if (userId.HasValue)
                    {
                        query = "UPDATE Пользователи SET Логин = @login, Пароль = @password, Роль = @role WHERE ID_пользователя = @id";
                    }
                    else
                    {
                        query = "INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES (@login, @password, @role)";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", txtLogin.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.Parameters.AddWithValue("@role", ((dynamic)cmbRole.SelectedItem).Value);

                        if (userId.HasValue)
                            command.Parameters.AddWithValue("@id", userId.Value);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
