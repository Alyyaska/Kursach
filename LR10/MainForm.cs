using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainKursach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fio = txtFio.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-0U6SVCH\SQLEXPRESS;Initial Catalog=Kursach;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT COUNT(*) 
                        FROM dbo.Пациент 
                        WHERE ФИО = @Fio AND Пароль = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Fio", fio);
                        command.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show($"Добро пожаловать, {fio}!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Открытие главного меню
                            frmMainMenu mainMenu = new frmMainMenu();
                            mainMenu.Show(); // или mainMenu.ShowDialog();

                            this.Hide(); // Скрыть текущую форму
                        }
                        else
                        {
                            MessageBox.Show("Неверное ФИО или пароль. Попробуйте снова.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Логика, выполняемая при загрузке формы.
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog(); // Открыть форму регистрации
        }
    }
}
