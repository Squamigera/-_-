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
    public partial class PartnersForm : Form
    {
        private UserRole _userRole;
        public PartnersForm(UserRole userRole)
        {
            InitializeComponent();
            ApplyStyle();
            LoadPartners();
            _userRole = userRole;
            ApplyPermissions();
        }

        public PartnersForm() : this(UserRole.Менеджер) // или любой "ограниченный" по умолчанию
        {
        }

        private void ApplyPermissions()
        {
            bool isAdmin = (_userRole == UserRole.Администратор);

            btnAdd.Visible = isAdmin;
            btnEdit.Visible = isAdmin;
            btnDelete.Visible = isAdmin;
        }

        private void ApplyStyle()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9F);
        }

        private void LoadPartners()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    [ID_партнера] AS [ID],
                    [Наименование],
                    [Юридический_адрес],
                    [ИНН],
                    [ФИО_директора],
                    [Телефон],
                    [Email],
                    [Рейтинг],
                    [Тип_партнера]
                FROM [Партнеры]";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPartners.DataSource = dt;
                    dgvPartners.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditPartnerForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadPartners();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPartners.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите партнера для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvPartners.SelectedRows[0].Cells["ID"].Value);
            var form = new AddEditPartnerForm(id);
            if (form.ShowDialog() == DialogResult.OK)
                LoadPartners();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPartners.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите партнера для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Удалить выбранного партнера?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dgvPartners.SelectedRows[0].Cells["ID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "DELETE FROM Партнеры WHERE ID_партнера = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Партнер удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPartners();
                    }
                    else
                        MessageBox.Show("Не удалось удалить запись.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
