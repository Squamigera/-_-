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
    public partial class AddEditSalesRequestForm : Form
    {
        private int managerId;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public AddEditSalesRequestForm(int managerId)
        {
            this.managerId = managerId;
            InitializeComponent();
            LoadPartners();
            LoadProducts();
        }

        private void LoadPartners()
        {
            string query = "SELECT ID_партнера, Наименование FROM Партнеры";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbPartner.ValueMember = "ID_партнера";
                cmbPartner.DisplayMember = "Наименование";
                cmbPartner.DataSource = dt;
            }
        }

        private void LoadProducts()
        {
            string query = "SELECT ID_продукции, Наименование FROM Продукция";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbProduct.ValueMember = "ID_продукции";
                cmbProduct.DisplayMember = "Наименование";
                cmbProduct.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPartner.SelectedValue == null || cmbProduct.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    INSERT INTO ЗавякиНаПродажу 
                    (ID_партнера, ID_менеджера, ID_продукции, Количество, Цена, Дата_создания, Статус)
                    VALUES 
                    (@partnerId, @managerId, @productId, @quantity, @price, GETDATE(), 'Создана')";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@partnerId", cmbPartner.SelectedValue);
                        cmd.Parameters.AddWithValue("@managerId", managerId);
                        cmd.Parameters.AddWithValue("@productId", cmbProduct.SelectedValue);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Заявка успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заявки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
