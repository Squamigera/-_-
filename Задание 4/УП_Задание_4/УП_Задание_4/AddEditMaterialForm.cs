using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace УП_Задание_4
{
    public partial class AddEditMaterialForm : Form
    {
        private int? _materialId;

        public AddEditMaterialForm()
        {
            InitializeComponent();
            LoadMaterialTypes();
        }

        public AddEditMaterialForm(int materialId) : this()
        {
            _materialId = materialId;
            LoadMaterialData(materialId);
            Text = "Редактирование материала";
        }

        private void LoadMaterialTypes()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT ID_типа_материала, Название_типа FROM ТипыМатериалов";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbMaterialType.DisplayMember = "Название_типа";
                cmbMaterialType.ValueMember = "ID_типа_материала";
                cmbMaterialType.DataSource = dt;
            }
        }

        private void LoadMaterialData(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT Наименование, ID_типа_материала, Единица_измерения, Стоимость, 
                       Количество_на_складе, Минимальный_запас
                FROM Материалы WHERE ID_материала = @id";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtName.Text = reader["Наименование"].ToString();
                        cmbMaterialType.SelectedValue = reader["ID_типа_материала"];
                        txtUnit.Text = reader["Единица_измерения"].ToString();
                        txtCost.Text = reader["Стоимость"].ToString();
                        txtStock.Text = reader["Количество_на_складе"].ToString();
                        txtMinStock.Text = reader["Минимальный_запас"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUnit.Text) ||
                !decimal.TryParse(txtCost.Text, out decimal cost) ||
                !int.TryParse(txtStock.Text, out int stock) ||
                !int.TryParse(txtMinStock.Text, out int minStock))
            {
                MessageBox.Show("Заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = _materialId.HasValue
                ? @"
UPDATE Материалы 
SET Наименование = @name, ID_типа_материала = @typeId, Единица_измерения = @unit,
    Стоимость = @cost, Количество_на_складе = @stock, Минимальный_запас = @minStock
WHERE ID_материала = @id"
                : @"
INSERT INTO Материалы (ID_материала, Наименование, ID_типа_материала, Единица_измерения, Стоимость, Количество_на_складе, Минимальный_запас)
VALUES ((SELECT ISNULL(MAX(ID_материала), 0) + 1 FROM Материалы), @name, @typeId, @unit, @cost, @stock, @minStock)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@typeId", cmbMaterialType.SelectedValue);
                        cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@minStock", minStock);
                        if (_materialId.HasValue) cmd.Parameters.AddWithValue("@id", _materialId.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}