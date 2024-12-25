using System;
using System.Windows.Forms;

namespace MainKursach
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            int patientId = 1; // Здесь укажите реальный ID пациента
            frmAppointment appointmentForm = new frmAppointment(patientId);
            appointmentForm.ShowDialog();
        }

        private void btnMyAppointments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция просмотра записей ещё не реализована.", "Мои записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция просмотра истории ещё не реализована.", "История", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Контакты: Адрес клиники, телефон, электронная почта.", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция оставления отзыва ещё не реализована.", "Оставить отзыв", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // Логика при загрузке формы
        }
    }
}
