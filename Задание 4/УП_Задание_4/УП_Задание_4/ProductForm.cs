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
    public partial class ProductForm : Form
    {
        private UserRole _userRole;
        public ProductForm(UserRole userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ApplyStyle();
            LoadProducts();
            ApplyPermissions();
        }

        public ProductForm() : this(UserRole.Менеджер) { }

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

        private void LoadProducts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    p.[ID_продукции] AS [ID],
                    p.[Артикул],
                    p.[Наименование],
                    m.[Наименование] AS [Материал],
                    tp.[Название_типа] AS [Тип продукции],
                    p.[Минимальная_цена],
                    p.[Время_изготовления],
                    p.[Себестоимость],
                    p.[Количество_на_складе]
                FROM [Продукция] p
                INNER JOIN [Материалы] m ON p.[ID_материала] = m.[ID_материала]
                INNER JOIN [ТипыПродукции] tp ON p.[ID_типа_продукции] = tp.[ID_типа_продукции]";

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
            LoadProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditProductForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукцию для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvMaterials.SelectedRows[0].Cells["ID"].Value);
            var form = new AddEditProductForm(id);
            if (form.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукцию для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Удалить выбранную продукцию?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dgvMaterials.SelectedRows[0].Cells["ID"].Value);
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "DELETE FROM Продукция WHERE ID_продукции = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Продукция удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
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
