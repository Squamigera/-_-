using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace УП_Задание_4
{
    public partial class AddEditProductTypeForm : Form
    {
        private int? _id;

        public AddEditProductTypeForm()
        {
            InitializeComponent();
        }

        public AddEditProductTypeForm(int id) : this()
        {
            _id = id;
            LoadData(id);
            Text = "Редактирование типа продукции";
        }

        private void LoadData(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Название_типа, Описание FROM ТипыПродукции WHERE ID_типа_продукции = @id";

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
                        txtDescription.Text = reader["Описание"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните название типа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = _id.HasValue
                ? "UPDATE ТипыПродукции SET Название_типа = @name, Описание = @desc WHERE ID_типа_продукции = @id"
                : "INSERT INTO ТипыПродукции (ID_типа_продукции, Название_типа, Описание) VALUES ((SELECT ISNULL(MAX(ID_типа_продукции), 0) + 1 FROM ТипыПродукции), @name, @desc)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
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