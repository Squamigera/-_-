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
    public partial class PartnersMainForm : Form
    {
        private bool isExitingViaButton = false;
        private User currentUser;
        private int partnerId;

        public PartnersMainForm(User user, int partnerId)
        {
            currentUser = user;
            InitializeComponent();
            ApplyStyle();
            this.partnerId = partnerId;
            LoadMySalesRequests();
            LoadProducts();
            LoadProductTypes();
            LoadPartnerDiscount();
        }

        private void ApplyStyle()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 9F);
        }        

        private void LoadMySalesRequests()
        {
            if (partnerId == 0) return;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    ID_заявки_продажи AS [ID],
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
                FROM ЗаявкиНаПродажу 
                WHERE ID_партнера = @partnerId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@partnerId", partnerId);
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

        private void LoadProducts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT ID_продукции AS [ID],Артикул, Наименование, ID_материала, Минимальная_цена AS [Минимальная цена], Количество_на_складе FROM Продукция";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    dgvProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки продукции: {ex.Message}");
            }
        }

        private void LoadProductTypes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT ID_типа_продукции AS [ID], Название_типа, Описание FROM ТипыПродукции";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProductTypes.DataSource = dt;
                    dgvProductTypes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки типов продукции: {ex.Message}");
            }
        }

        private void btnRefreshRequests_Click(object sender, EventArgs e)
        {
            LoadMySalesRequests();
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnRefreshProductTypes_Click(object sender, EventArgs e)
        {
            LoadProductTypes();
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
        private void LoadPartnerDiscount()
        {
            if (partnerId == 0) return;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT ISNULL(SUM(Цена), 0) AS TotalSales
                FROM ЗаявкиНаПродажу
                WHERE ID_партнера = @partnerId AND Статус = 'Выполнено'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@partnerId", partnerId);
                        var result = cmd.ExecuteScalar();
                        decimal totalSales = Convert.ToDecimal(result);

                        decimal discount = DiscountHelper.CalculateDiscount(totalSales);
                        lblDiscount.Text = $"Ваша скидка: {discount}%";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки скидки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDiscount.Text = "Скидка: недоступна";
            }
        }
    }
}
