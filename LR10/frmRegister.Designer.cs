using System;

namespace MainKursach
{
    partial class frmRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFio;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFio = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFio
            // 
            this.txtFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFio.Location = new System.Drawing.Point(31, 39);
            this.txtFio.Name = "txtFio";
            this.txtFio.Size = new System.Drawing.Size(319, 26);
            this.txtFio.TabIndex = 0;
            this.txtFio.Text = "Введите ФИО";
            this.txtFio.GotFocus += new System.EventHandler(this.txtFio_GotFocus);
            this.txtFio.LostFocus += new System.EventHandler(this.txtFio_LostFocus);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhone.Location = new System.Drawing.Point(31, 82);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(319, 26);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "Введите номер телефона";
            this.txtPhone.GotFocus += new System.EventHandler(this.txtPhone_GotFocus);
            this.txtPhone.LostFocus += new System.EventHandler(this.txtPhone_LostFocus);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(31, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(319, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Введите пароль";
            this.txtPassword.GotFocus += new System.EventHandler(this.txtPassword_GotFocus);
            this.txtPassword.LostFocus += new System.EventHandler(this.txtPassword_LostFocus);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBirthDate.Location = new System.Drawing.Point(31, 173);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(319, 26);
            this.txtBirthDate.TabIndex = 3;
            this.txtBirthDate.Text = "Введите дату рождения (ГГГГ-ММ-ДД)";
            this.txtBirthDate.GotFocus += new System.EventHandler(this.txtBirthDate_GotFocus);
            this.txtBirthDate.LostFocus += new System.EventHandler(this.txtBirthDate_LostFocus);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(292, 215);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Сохранить";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(91, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите свои данные";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRegister
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(415, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFio);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmRegister";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtFio_GotFocus(object sender, EventArgs e)
        {
            if (txtFio.Text == "Введите ФИО")
            {
                txtFio.Text = "";
            }
        }

        private void txtFio_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFio.Text))
            {
                txtFio.Text = "Введите ФИО";
            }
        }

        private void txtPhone_GotFocus(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Введите номер телефона")
            {
                txtPhone.Text = "";
            }
        }

        private void txtPhone_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = "Введите номер телефона";
            }
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Введите пароль")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Введите пароль";
            }
        }

        private void txtBirthDate_GotFocus(object sender, EventArgs e)
        {
            if (txtBirthDate.Text == "Введите дату рождения (ГГГГ-ММ-ДД)")
            {
                txtBirthDate.Text = "";
            }
        }

        private void txtBirthDate_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthDate.Text))
            {
                txtBirthDate.Text = "Введите дату рождения (ГГГГ-ММ-ДД)";
            }
        }

        private System.Windows.Forms.Label label1;
    }
}
