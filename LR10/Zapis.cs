using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainKursach
{
    public partial class Zapis : Form
    {
        private int patientId; // Идентификатор пациента

        public Zapis(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            LoadRecords();
        }

        private void LoadRecords()
        {
            string connectionString = @"Data Source=DESKTOP-0U6SVCH\SQLEXPRESS;Initial Catalog=Kursach;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            z.ДатаЗаписи AS 'Дата', 
                            u.Описание AS 'Услуга', 
                            v.ФИО AS 'Врач'
                        FROM Запись z
                        INNER JOIN Услуга u ON z.КодУслуги = u.КодУслуги
                        INNER JOIN Врач v ON z.КодВрача = v.КодВрача
                        WHERE z.КодПациента = @PatientId AND z.ДатаЗаписи >= CAST(GETDATE() AS DATE)
                        ORDER BY z.ДатаЗаписи ASC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientId", patientId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable recordsTable = new DataTable();
                            adapter.Fill(recordsTable);

                            if (recordsTable.Rows.Count > 0)
                            {
                                dataGridViewRecords.DataSource = recordsTable;
                            }
                            else
                            {
                                MessageBox.Show("У вас нет активных записей.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки записей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Zapis_Load(object sender, EventArgs e)
        {
            // Логика при загрузке формы, если необходима
        }
    }
}
