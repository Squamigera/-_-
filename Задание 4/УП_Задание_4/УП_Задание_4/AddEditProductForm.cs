using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace УП_Задание_4
{
    public partial class AddEditProductForm : Form
    {
        private int? _id;

        public AddEditProductForm()
        {
            InitializeComponent();
            LoadMaterials();
            LoadProductTypes();
        }

        public AddEditProductForm(int id) : this()
        {
            _id = id;
            LoadData(id);
            Text = "Редактирование продукции";
        }

        private void LoadMaterials()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT ID_материала, Наименование FROM Материалы";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbMaterial.DisplayMember = "Наименование";
                cmbMaterial.ValueMember = "ID_материала";
                cmbMaterial.DataSource = dt;
            }
        }

        private void LoadProductTypes()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT ID_типа_продукции, Название_типа FROM ТипыПродукции";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbType.DisplayMember = "Название_типа";
                cmbType.ValueMember = "ID_типа_продукции";
                cmbType.DataSource = dt;
            }
        }

        private void LoadData(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT Артикул, Наименование, ID_материала, ID_типа_продукции,
                       Минимальная_цена, Время_изготовления, Себестоимость, Количество_на_складе
                FROM Продукция WHERE ID_продукции = @id";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtArticle.Text = reader["Артикул"].ToString();
                        txtName.Text = reader["Наименование"].ToString();
                        cmbMaterial.SelectedValue = reader["ID_материала"];
                        cmbType.SelectedValue = reader["ID_типа_продукции"];
                        txtMinPrice.Text = reader["Минимальная_цена"].ToString();
                        txtTime.Text = reader["Время_изготовления"] == DBNull.Value ? "" : reader["Время_изготовления"].ToString();
                        txtCost.Text = reader["Себестоимость"].ToString();
                        txtStock.Text = reader["Количество_на_складе"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticle.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                !decimal.TryParse(txtMinPrice.Text, out decimal minPrice) ||
                !decimal.TryParse(txtCost.Text, out decimal cost) ||
                !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Заполните обязательные поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasTime = int.TryParse(txtTime.Text, out int time);

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = _id.HasValue
                ? @"
UPDATE Продукция 
SET Артикул = @art, Наименование = @name, ID_материала = @mat, ID_типа_продукции = @type,
    Минимальная_цена = @minPrice, Время_изготовления = @time, Себестоимость = @cost, Количество_на_складе = @stock
WHERE ID_продукции = @id"
                : @"
INSERT INTO Продукция (ID_продукции, Артикул, Наименование, ID_материала, ID_типа_продукции,
    Минимальная_цена, Время_изготовления, Себестоимость, Количество_на_складе)
VALUES ((SELECT ISNULL(MAX(ID_продукции), 0) + 1 FROM Продукция), @art, @name, @mat, @type,
    @minPrice, @time, @cost, @stock)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@art", txtArticle.Text);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@mat", cmbMaterial.SelectedValue);
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedValue);
                        cmd.Parameters.AddWithValue("@minPrice", minPrice);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@time", hasTime ? (object)time : DBNull.Value);
                        if (_id.HasValue) cmd.Parameters.AddWithValue("@id", _id.Value);

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