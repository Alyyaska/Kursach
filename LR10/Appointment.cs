using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainKursach
{
    public partial class frmAppointment : Form
    {
        private int patientId;

        public frmAppointment(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            LoadServices();
            LoadDoctors();
            datePicker.MinDate = DateTime.Today.AddDays(1); // Установка минимальной даты для выбора
        }

        private void LoadServices()
        {
            string connectionString = @"Data Source=DESKTOP-0U6SVCH\SQLEXPRESS;Initial Catalog=Kursach;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Описание FROM Услуга";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbService.Items.Add(reader["Описание"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки услуг: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            string connectionString = @"Data Source=DESKTOP-0U6SVCH\SQLEXPRESS;Initial Catalog=Kursach;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ФИО FROM Врач";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbDoctor.Items.Add(reader["ФИО"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки врачей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-0U6SVCH\SQLEXPRESS;Initial Catalog=Kursach;Integrated Security=True";

            string selectedService = cmbService.SelectedItem?.ToString();
            string selectedDoctor = cmbDoctor.SelectedItem?.ToString();
            string complaints = txtComplaints.Text.Trim();
            string selectedDate = datePicker.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(selectedService) || string.IsNullOrEmpty(selectedDoctor))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Прием (КодПациента, Услуга, Дата, Врач, Жалобы) 
                        VALUES (@PatientId, @Service, @Date, @Doctor, @Complaints)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientId", patientId);
                        command.Parameters.AddWithValue("@Service", selectedService);
                        command.Parameters.AddWithValue("@Date", selectedDate);
                        command.Parameters.AddWithValue("@Doctor", selectedDoctor);
                        command.Parameters.AddWithValue("@Complaints", complaints);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Запись успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при создании записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
