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
    public partial class MaterialForm : Form
    {
        private UserRole _userRole;

        // Новый конструктор с ролью
        public MaterialForm(UserRole userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ApplyStyle();
            LoadMaterials();
            ApplyPermissions();
        }

        // Старый конструктор (для обратной совместимости, если нужно)
        public MaterialForm() : this(UserRole.Менеджер) // или любой "ограниченный" по умолчанию
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

        private void LoadMaterials()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    m.[ID_материала] AS [ID],
                    m.[Наименование],
                    tm.[Название_типа] AS [Тип материала],
                    m.[Единица_измерения],
                    m.[Стоимость],
                    m.[Количество_на_складе],
                    m.[Минимальный_запас]
                FROM [Материалы] m
                INNER JOIN [ТипыМатериалов] tm ON m.[ID_типа_материала] = tm.[ID_типа_материала]";

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
            LoadMaterials();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditMaterialForm(); // Создайте эту форму (см. ниже)
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadMaterials();
            }
        }

        // === РЕДАКТИРОВАНИЕ ===
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите материал для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int materialId = Convert.ToInt32(dgvMaterials.SelectedRows[0].Cells["ID"].Value);
            var editForm = new AddEditMaterialForm(materialId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadMaterials();
            }
        }

        // === УДАЛЕНИЕ ===
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите материал для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный материал?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            int materialId = Convert.ToInt32(dgvMaterials.SelectedRows[0].Cells["ID"].Value);

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "DELETE FROM Материалы WHERE ID_материала = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", materialId);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Материал успешно удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMaterials();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить материал.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
