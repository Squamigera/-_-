using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace УП_Задание_4
{
    public partial class AddEditMaterialTypeForm : Form
    {
        private int? _id;

        public AddEditMaterialTypeForm()
        {
            InitializeComponent();
        }

        public AddEditMaterialTypeForm(int id) : this()
        {
            _id = id;
            LoadData(id);
            Text = "Редактирование типа материала";
        }

        private void LoadData(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Название_типа, Описание FROM ТипыМатериалов WHERE ID_типа_материала = @id";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtName.Text = reader["Название_типа"].ToString();
                        txtDesc.Text = reader["Описание"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = _id.HasValue
                ? "UPDATE ТипыМатериалов SET Название_типа = @name, Описание = @desc WHERE ID_типа_материала = @id"
                : "INSERT INTO ТипыМатериалов (ID_типа_материала, Название_типа, Описание) VALUES ((SELECT ISNULL(MAX(ID_типа_материала), 0) + 1 FROM ТипыМатериалов), @name, @desc)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
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