using System;

namespace MainKursach
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFio;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;

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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFio
            // 
            this.txtFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFio.Location = new System.Drawing.Point(100, 93);
            this.txtFio.Name = "txtFio";
            this.txtFio.Size = new System.Drawing.Size(273, 26);
            this.txtFio.TabIndex = 0;
            this.txtFio.Text = "Введите ФИО";
            this.txtFio.GotFocus += new System.EventHandler(this.txtFio_GotFocus);
            this.txtFio.LostFocus += new System.EventHandler(this.txtFio_LostFocus);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(100, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(273, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Введите пароль";
            this.txtPassword.GotFocus += new System.EventHandler(this.txtPassword_GotFocus);
            this.txtPassword.LostFocus += new System.EventHandler(this.txtPassword_LostFocus);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegister.Location = new System.Drawing.Point(100, 200);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(131, 30);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Location = new System.Drawing.Point(264, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(96, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро пожаловать в нашу клинику!";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFio);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
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

        private System.Windows.Forms.Label label1;
    }
}
