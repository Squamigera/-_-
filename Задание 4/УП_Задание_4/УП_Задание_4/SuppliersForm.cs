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
    public partial class SuppliersForm : Form
    {
        private UserRole _userRole;
        public SuppliersForm(UserRole userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ApplyStyle();
            LoadSuppliers();
            ApplyPermissions();
        }

        public SuppliersForm() : this(UserRole.Менеджер) { }

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

        private void LoadSuppliers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    [ID_поставщика] AS [ID],
                    [Наименование],
                    [ИНН],
                    [Тип_поставщика],
                    [Контактные_данные]
                FROM [Поставщики]";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMaterials.DataSource = dt;
                    dgvMaterials.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditSupplierForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadSuppliers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите поставщика для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvMaterials.SelectedRows[0].Cells["ID"].Value);
            var form = new AddEditSupplierForm(id);
            if (form.ShowDialog() == DialogResult.OK)
                LoadSuppliers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите поставщика для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Удалить выбранного поставщика?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dgvMaterials.SelectedRows[0].Cells["ID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "DELETE FROM Поставщики WHERE ID_поставщика = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Поставщик удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSuppliers();
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
