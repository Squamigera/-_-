using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace УП_Задание_4
{
    public partial class EmployeeForm : Form
    {
        private UserRole _userRole;

        public EmployeeForm(UserRole userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ApplyStyle();
            LoadEmployees();
            ApplyPermissions();
        }

        public EmployeeForm() : this(UserRole.Менеджер) { }

        private void ApplyStyle()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9F);
        }

        private void ApplyPermissions()
        {
            bool isAdmin = (_userRole == UserRole.Администратор);
            btnAdd.Visible = isAdmin;
            btnEdit.Visible = isAdmin;
            btnDelete.Visible = isAdmin;
        }

        private void LoadEmployees()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    [ID_сотрудника] AS [ID],
                    [ФИО],
                    [Дата_рождения],
                    [Паспортные_данные],
                    [Банковские_реквизиты],
                    [Должность]
                FROM [Сотрудники]";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvEmployees.DataSource = dt;
                    dgvEmployees.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // === ДОБАВЛЕНИЕ ===
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditEmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        // === РЕДАКТИРОВАНИЕ ===
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int employeeId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["ID"].Value);
            var editForm = new AddEditEmployeeForm(employeeId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        // === УДАЛЕНИЕ ===
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранного сотрудника?\n" +
                "Это может повлиять на связанные заявки!",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            int employeeId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["ID"].Value);

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "DELETE FROM Сотрудники WHERE ID_сотрудника = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Сотрудник успешно удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 547) // Ошибка внешнего ключа
            {
                MessageBox.Show("Невозможно удалить сотрудника: на него ссылаются другие записи (например, заявки).",
                    "Ошибка целостности", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}