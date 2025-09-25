using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace УП_Задание_4
{
    public partial class AddEditSupplierForm : Form
    {
        private int? _id;

        public AddEditSupplierForm()
        {
            InitializeComponent();
        }

        public AddEditSupplierForm(int id) : this()
        {
            _id = id;
            LoadData(id);
            Text = "Редактирование поставщика";
        }

        private void LoadData(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Наименование, ИНН, Тип_поставщика, Контактные_данные FROM Поставщики WHERE ID_поставщика = @id";

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
                        txtINN.Text = reader["ИНН"].ToString();
                        txtType.Text = reader["Тип_поставщика"].ToString();
                        txtContacts.Text = reader["Контактные_данные"]?.ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtINN.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text) ||
                !double.TryParse(txtINN.Text, out double inn))
            {
                MessageBox.Show("Заполните обязательные поля. ИНН должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = _id.HasValue
                ? "UPDATE Поставщики SET Наименование = @name, ИНН = @inn, Тип_поставщика = @type, Контактные_данные = @contacts WHERE ID_поставщика = @id"
                : "INSERT INTO Поставщики (ID_поставщика, Наименование, ИНН, Тип_поставщика, Контактные_данные) VALUES ((SELECT ISNULL(MAX(ID_поставщика), 0) + 1 FROM Поставщики), @name, @inn, @type, @contacts)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@inn", inn);
                        cmd.Parameters.AddWithValue("@type", txtType.Text);
                        cmd.Parameters.AddWithValue("@contacts", string.IsNullOrWhiteSpace(txtContacts.Text) ? (object)DBNull.Value : txtContacts.Text);
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