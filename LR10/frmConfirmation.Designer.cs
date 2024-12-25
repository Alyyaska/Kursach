using System.Windows.Forms;
namespace MainKursach
{
    partial class frmConfirmation
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMessage;
        private Button btnReturnToMain;

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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMessage.Location = new System.Drawing.Point(56, 45);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(241, 42);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Запись успешно подтверждена!\nСпасибо за оказанное доверие!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReturnToMain.Location = new System.Drawing.Point(70, 120);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(202, 35);
            this.btnReturnToMain.TabIndex = 1;
            this.btnReturnToMain.Text = "Вернуться на главную";
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(358, 203);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReturnToMain);
            this.Name = "frmConfirmation";
            this.Text = "Подтверждение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

