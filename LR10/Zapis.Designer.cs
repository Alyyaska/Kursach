namespace MainKursach
{
    partial class Zapis
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.Button btnReturnToMain;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowTemplate.Height = 25;
            this.dataGridViewRecords.Size = new System.Drawing.Size(651, 347);
            this.dataGridViewRecords.TabIndex = 0;
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.Location = new System.Drawing.Point(266, 373);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(129, 35);
            this.btnReturnToMain.TabIndex = 1;
            this.btnReturnToMain.Text = "Вернуться на главную";
            this.btnReturnToMain.UseVisualStyleBackColor = true;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // Zapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 417);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.dataGridViewRecords);
            this.Name = "Zapis";
            this.Text = "Мои записи";
            this.Load += new System.EventHandler(this.Zapis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
