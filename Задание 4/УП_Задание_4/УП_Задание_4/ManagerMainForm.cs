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
    public partial class ManagerMainForm : Form
    {
        private bool isExitingViaButton = false;
        private User currentUser;        

        public ManagerMainForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            ApplyStyle();
            LoadSalesRequestsData();
            LoadSupplyRequestsData();
        }

        private void ApplyStyle()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9F);
        }

        // ============ ЗАГРУЗКА ЗАЯВОК НА ПРОДАЖУ ============
        private void LoadSalesRequestsData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    ID_заявки_продажи AS [ID],
                    ID_партнера AS [Партнер],
                    ID_менеджера AS [Менеджер],
                    ID_продукции AS [Продукт],
                    Количество,
                    Цена,
                    Дата_создания AS [Дата создания],
                    Статус,
                    Предоплата,
                    Дата_предоплаты AS [Дата предоплаты],
                    Полная_оплата AS [Полная оплата],
                    Дата_полной_оплаты AS [Дата полной оплаты],
                    Способ_доставки AS [Способ доставки],
                    Дата_производства AS [Дата производства]
                FROM [ЗаявкиНаПродажу]";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSalesRequests.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявок на продажу: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ ЗАГРУЗКА ЗАЯВОК НА ПОСТАВКУ ============
        private void LoadSupplyRequestsData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    ID_заявки_поставки AS [ID],
                    ID_поставщика AS [Поставщик],
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
                FROM [ЗаявкиНаПоставки]";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSupplyRequests.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявок на поставку: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ ОБРАБОТЧИКИ КНОПОК ============

        private void btnRefreshSales_Click(object sender, EventArgs e)
        {
            LoadSalesRequestsData();
        }

        private void btnRefreshSupply_Click(object sender, EventArgs e)
        {
            LoadSupplyRequestsData();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm();
            form.Show();
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            var form = new PartnersForm();
            form.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            var form = new SuppliersForm();
            form.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            form.Show();
        }

        // Пример из ManagerMainForm
        private void btnMaterials_Click(object sender, EventArgs e)
        {
            var form = new MaterialForm(UserRole.Менеджер); // или текущая роль
            form.Show(); // без MdiParent, если не MDI
        }

        private void btnMaterialTypes_Click(object sender, EventArgs e)
        {
            var form = new MaterialTypeForm();
            form.Show();
        }

        private void btnProductTypes_Click(object sender, EventArgs e)
        {
            var form = new ProductTypeForm();
            form.Show();
        }

        private void btnCreateSales_Click(object sender, EventArgs e)
        {
            var form = new AddEditSalesRequestForm(currentUser.ID_сущности); // Передаём ID менеджера
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSalesRequestsData(); // Обновляем таблицу
            }
        }

        private void btnCreateSupply_Click(object sender, EventArgs e)
        {
            var form = new AddEditSupplyRequestForm(currentUser.ID_сущности); // Передаём ID менеджера
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSupplyRequestsData(); // Обновляем таблицу
            }
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

        private void btnShowDiscounts_Click(object sender, EventArgs e)
        {
            var form = new DiscountsForm();
            form.Show();
        }
    }
}
