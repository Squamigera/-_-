using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace УП_Задание_4
{
    public partial class AddEditPartnerForm : Form
    {
        private int? _id;

        public AddEditPartnerForm()
        {
            InitializeComponent();
        }

        public AddEditPartnerForm(int id) : this()
        {
            _id = id;
            LoadData(id);
            Text = "Редактирование партнера";
        }

        private void LoadData(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT Наименование, Юридический_адрес, ИНН, ФИО_директора,
                       Телефон, Email, Рейтинг, Тип_партнера
                FROM Партнеры WHERE ID_партнера = @id";

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
                        txtAddress.Text = reader["Юридический_адрес"].ToString();
                        txtINN.Text = reader["ИНН"].ToString();
                        txtDirector.Text = reader["ФИО_директора"]?.ToString();
                        txtPhone.Text = reader["Телефон"]?.ToString();
                        txtEmail.Text = reader["Email"]?.ToString();
                        txtRating.Text = reader["Рейтинг"].ToString();
                        txtPartnerType.Text = reader["Тип_партнера"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtINN.Text) ||
                string.IsNullOrWhiteSpace(txtRating.Text) ||
                string.IsNullOrWhiteSpace(txtPartnerType.Text))
            {
                MessageBox.Show("Заполните обязательные поля: Наименование, Адрес, ИНН, Рейтинг, Тип партнера.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtINN.Text, out double inn))
            {
                MessageBox.Show("ИНН должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtRating.Text, out double rating))
            {
                MessageBox.Show("Рейтинг должен быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = _id.HasValue
                ? @"
UPDATE Партнеры 
SET Наименование = @name, Юридический_адрес = @addr, ИНН = @inn,
    ФИО_директора = @dir, Телефон = @phone, Email = @email,
    Рейтинг = @rating, Тип_партнера = @type
WHERE ID_партнера = @id"
                : @"
INSERT INTO Партнеры (ID_партнера, Наименование, Юридический_адрес, ИНН,
    ФИО_директора, Телефон, Email, Рейтинг, Тип_партнера)
VALUES ((SELECT ISNULL(MAX(ID_партнера), 0) + 1 FROM Партнеры), @name, @addr, @inn,
    @dir, @phone, @email, @rating, @type)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@addr", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@inn", inn);
                        cmd.Parameters.AddWithValue("@dir", string.IsNullOrWhiteSpace(txtDirector.Text) ? (object)DBNull.Value : txtDirector.Text);
                        cmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(txtPhone.Text) ? (object)DBNull.Value : txtPhone.Text);
                        cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@type", txtPartnerType.Text);
                        if (_id.HasValue)
                            cmd.Parameters.AddWithValue("@id", _id.Value);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}