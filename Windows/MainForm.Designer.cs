namespace Butchershop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Invate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login1
            // 
            this.Login1.Location = new System.Drawing.Point(82, 16);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(192, 20);
            this.Login1.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(82, 47);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(192, 20);
            this.Password.TabIndex = 1;
            // 
            // Invate
            // 
            this.Invate.Location = new System.Drawing.Point(199, 90);
            this.Invate.Name = "Invate";
            this.Invate.Size = new System.Drawing.Size(75, 23);
            this.Invate.TabIndex = 2;
            this.Invate.Text = "Войти";
            this.Invate.UseVisualStyleBackColor = true;
            this.Invate.Click += new System.EventHandler(this.Invate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Invate);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Invate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

