using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace УП_Задание_4
{
    public partial class DiscountsForm : Form
    {
        public DiscountsForm()
        {
            InitializeComponent();
            LoadAllDiscounts();
        }

        private void LoadAllDiscounts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT 
                    p.ID_партнера AS [ID],
                    p.Наименование AS [Партнёр],
                    ISNULL(SUM(z.Цена), 0) AS [Общий объём продаж],
                    CASE
                        WHEN ISNULL(SUM(z.Цена), 0) < 10000 THEN 0
                        WHEN ISNULL(SUM(z.Цена), 0) < 50000 THEN 5
                        WHEN ISNULL(SUM(z.Цена), 0) < 300000 THEN 10
                        ELSE 15
                    END AS [Скидка (%)]
                FROM Партнеры p
                LEFT JOIN ЗаявкиНаПродажу z 
                    ON p.ID_партнера = z.ID_партнера 
                    AND z.Статус = 'Выполнено'  -- ← фильтр внутри JOIN!                
                GROUP BY p.ID_партнера, p.Наименование
                ORDER BY [Общий объём продаж] DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDiscounts.DataSource = dt;
                    dgvDiscounts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки скидок: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllDiscounts();
        }
    }
}