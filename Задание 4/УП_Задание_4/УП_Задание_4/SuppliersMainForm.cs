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
    public partial class SuppliersMainForm : Form
    {
        private bool isExitingViaButton = false;
        private User currentUser;
        private int supplierId;

        public SuppliersMainForm(User user, int supplierId)
        {
            currentUser = user;
            InitializeComponent();
            ApplyStyle();
            this.supplierId = supplierId;
            LoadMySupplyRequests();
            LoadMaterials();
            LoadMaterialTypes();
        }

        private void ApplyStyle()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9F);
        }       

        private void LoadMySupplyRequests()
        {
            if (supplierId == 0) return;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    ID_заявки_поставки AS [ID],
                    ID_менеджера AS [Менеджер],
                    ID_материала AS [Материал],
                    Количество,
                    Цена,
                    Дата_создания AS [Дата создания],
                    Статус,
                    Предоплата,
                    Дата_предоплаты AS [Дата предоплаты],
                    Полная_оплата AS [Полная оплата],
                    Дата_полной_оплаты AS [Дата полной оплаты],
                    Способ_доставки AS [Способ доставки],
                    Дата_поставки AS [Дата поставки]
                FROM ЗаявкиНаПоставки 
                WHERE ID_поставщика = @supplierId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@supplierId", supplierId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMyRequests.DataSource = dt;
                    dgvMyRequests.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявок: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMaterials()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT ID_материала AS [ID], Наименование, Стоимость, Количество_на_складе, Минимальный_запас FROM Материалы";

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
                MessageBox.Show($"Ошибка загрузки материалов: {ex.Message}");
            }
        }

        private void LoadMaterialTypes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT ID_типа_материала AS [ID], Название_типа, Описание FROM ТипыМатериалов";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMaterialTypes.DataSource = dt;
                    dgvMaterialTypes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки типов материалов: {ex.Message}");
            }
        }

        private void btnRefreshRequests_Click(object sender, EventArgs e)
        {
            LoadMySupplyRequests();
        }

        private void btnRefreshMaterials_Click(object sender, EventArgs e)
        {
            LoadMaterials();
        }

        private void btnRefreshMaterialTypes_Click(object sender, EventArgs e)
        {
            LoadMaterialTypes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            isExitingViaButton = true;
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (isExitingViaButton)
            {
                // Возвращаемся на форму входа
                var loginForm = new LoginForm();
                loginForm.Show();
            }
            // Если флаг НЕ установлен (закрытие крестиком) — ничего не делаем,
            // и приложение завершится автоматически, так как это последняя форма.

            base.OnFormClosed(e);
        }
    }
}
