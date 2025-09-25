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
    public partial class AddEditSupplyRequestForm : Form
    {
        private int managerId;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public AddEditSupplyRequestForm(int managerId)
        {
            this.managerId = managerId;
            InitializeComponent();
            LoadSuppliers();
            LoadMaterials();
        }

        private void LoadSuppliers()
        {
            string query = "SELECT ID_поставщика, Наименование FROM Поставщики";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbSupplier.ValueMember = "ID_поставщика";
                cmbSupplier.DisplayMember = "Наименование";
                cmbSupplier.DataSource = dt;
            }
        }

        private void LoadMaterials()
        {
            string query = "SELECT ID_материала, Наименование FROM Материалы";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbMaterial.ValueMember = "ID_материала";
                cmbMaterial.DisplayMember = "Наименование";
                cmbMaterial.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue == null || cmbMaterial.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    INSERT INTO ЗаявкиНаПоставки 
                    (ID_поставщика, ID_менеджера, ID_материала, Количество, Цена, Дата_создания, Статус)
                    VALUES 
                    (@supplierId, @managerId, @materialId, @quantity, @price, GETDATE(), 'Создана')";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@supplierId", cmbSupplier.SelectedValue);
                        cmd.Parameters.AddWithValue("@managerId", managerId);
                        cmd.Parameters.AddWithValue("@materialId", cmbMaterial.SelectedValue);
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
