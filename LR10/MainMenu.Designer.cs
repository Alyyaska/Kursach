namespace MainKursach
{
    partial class frmMainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnMyAppointments;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnFeedback;

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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnMyAppointments = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcome.Location = new System.Drawing.Point(50, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(328, 42);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Рады приветствовать в нашем приложении!\nМы заботимся о вашей улыбке!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAppointment.Location = new System.Drawing.Point(100, 80);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(200, 34);
            this.btnAppointment.TabIndex = 1;
            this.btnAppointment.Text = "Записаться на приём";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnMyAppointments
            // 
            this.btnMyAppointments.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMyAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMyAppointments.Location = new System.Drawing.Point(100, 120);
            this.btnMyAppointments.Name = "btnMyAppointments";
            this.btnMyAppointments.Size = new System.Drawing.Size(200, 30);
            this.btnMyAppointments.TabIndex = 2;
            this.btnMyAppointments.Text = "Мои записи";
            this.btnMyAppointments.UseVisualStyleBackColor = false;
            this.btnMyAppointments.Click += new System.EventHandler(this.btnMyAppointments_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHistory.Location = new System.Drawing.Point(100, 160);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(200, 30);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "История";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnContacts.Location = new System.Drawing.Point(100, 200);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(200, 30);
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Text = "Контакты";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFeedback.Location = new System.Drawing.Point(100, 240);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(200, 30);
            this.btnFeedback.TabIndex = 5;
            this.btnFeedback.Text = "Оставить отзыв";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // frmMainMenu
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnMyAppointments);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnFeedback);
            this.Name = "frmMainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
