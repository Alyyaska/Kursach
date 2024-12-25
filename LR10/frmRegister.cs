using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainKursach
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent(); // Инициализация компонентов
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-0U6SVCH\SQLEXPRESS;Initial Catalog=Kursach;Integrated Security=True";

            string fio = txtFio.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();
            DateTime birthDate;

            if (!DateTime.TryParse(txtBirthDate.Text.Trim(), out birthDate))
            {
                MessageBox.Show("Введите корректную дату рождения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Получение максимального КодПациента
                    int newPatientCode = 1; // Значение по умолчанию, если таблица пуста
                    string getMaxIdQuery = "SELECT ISNULL(MAX(КодПациента), 0) + 1 FROM Пациент";

                    using (SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection))
                    {
                        object result = getMaxIdCommand.ExecuteScalar();
                        if (result != null)
                        {
                            newPatientCode = Convert.ToInt32(result);
                        }
                    }

                    // Добавление новой записи в таблицу
                    string query = @"
                        INSERT INTO Пациент (КодПациента, ФИО, НомерТелефона, Пароль, ДатаРождения)
                        VALUES (@PatientCode, @Fio, @Phone, @Password, @BirthDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientCode", newPatientCode);
                        command.Parameters.AddWithValue("@Fio", fio);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Регистрация прошла успешно! Ваш код пациента: {newPatientCode}",
                                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при регистрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
