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
    public partial class AdminMainForm : Form
    {
        private bool isExitingViaButton = false;
        private User currentUser;

        public AdminMainForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            ApplyStyle();
            LoadUsersData();            
        }

        private void ApplyStyle()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9F);
        }

        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddEditUserForm(); // Создайте эту форму (см. ниже)
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                // После успешного добавления — перезагрузить данные
                LoadUsersData();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
            var editUserForm = new AddEditUserForm(userId); // Передаём ID для редактирования
            if (editUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersData(); // Обновляем данные
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного пользователя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "DELETE FROM Пользователи WHERE ID_пользователя = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", userId);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsersData();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsersData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
        SELECT 
            ID_пользователя AS [ID],
            Логин,
            Пароль,
            Роль
        FROM Пользователи";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Привязка данных к DataGridView
                    dgvUsers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new MaterialTypeForm(UserRole.Администратор);
            form.Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            var form = new MaterialForm(UserRole.Администратор);            
            form.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductForm(UserRole.Администратор);
            form.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm(UserRole.Администратор);
            form.Show();
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            var form = new PartnersForm(UserRole.Администратор);
            form.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            var form = new SuppliersForm(UserRole.Администратор);            
            form.Show();
        }

        private void btnProductTypes_Click(object sender, EventArgs e)
        {
            var form = new ProductTypeForm(UserRole.Администратор);            
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            // Создаем новую форму входа
            var loginForm = new LoginForm();
            loginForm.Show();

            // Закрываем текущую форму
            this.Close();
        }        

        private void btnShowDiscounts_Click(object sender, EventArgs e)
        {
            var form = new DiscountsForm();
            form.Show();
        }
    }
}
