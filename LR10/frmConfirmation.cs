using System;
using System.Windows.Forms;

namespace MainKursach
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму подтверждения и возвращаемся на главную
            this.Close();
        }
    }
}
