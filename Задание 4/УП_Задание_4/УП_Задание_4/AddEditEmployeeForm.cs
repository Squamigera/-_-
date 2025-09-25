using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace УП_Задание_4
{
    public partial class AddEditEmployeeForm : Form
    {
        private int? _id;

        public AddEditEmployeeForm()
        {
            InitializeComponent();
        }

        public AddEditEmployeeForm(int id) : this()
        {
            _id = id;
            LoadData(id);
            Text = "Редактирование сотрудника";
        }

        private void LoadData(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT ФИО, Дата_рождения, Паспортные_данные, 
                       Банковские_реквизиты, Должность 
                FROM Сотрудники WHERE ID_сотрудника = @id";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtFullName.Text = reader["ФИО"].ToString();
                        dtpBirthDate.Value = (DateTime)reader["Дата_рождения"];
                        txtPassport.Text = reader["Паспортные_данные"].ToString();
                        txtBank.Text = reader["Банковские_реквизиты"].ToString();
                        txtPosition.Text = reader["Должность"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPassport.Text) ||
                string.IsNullOrWhiteSpace(txtBank.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = _id.HasValue
                ? @"
UPDATE Сотрудники 
SET ФИО = @fio, Дата_рождения = @birth, Паспортные_данные = @passport,
    Банковские_реквизиты = @bank, Должность = @pos
WHERE ID_сотрудника = @id"
                : @"
INSERT INTO Сотрудники (ID_сотрудника, ФИО, Дата_рождения, Паспортные_данные,
    Банковские_реквизиты, Должность)
VALUES ((SELECT ISNULL(MAX(ID_сотрудника), 0) + 1 FROM Сотрудники), @fio, @birth, @passport, @bank, @pos)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fio", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@birth", dtpBirthDate.Value);
                        cmd.Parameters.AddWithValue("@passport", txtPassport.Text);
                        cmd.Parameters.AddWithValue("@bank", txtBank.Text);
                        cmd.Parameters.AddWithValue("@pos", txtPosition.Text);
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