namespace CursBD
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIntegratedSecurity = new System.Windows.Forms.ComboBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxInitialCatalog = new System.Windows.Forms.TextBox();
            this.textBoxDataSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIDPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelIDPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Проверка подлинности";
            // 
            // comboBoxIntegratedSecurity
            // 
            this.comboBoxIntegratedSecurity.FormattingEnabled = true;
            this.comboBoxIntegratedSecurity.Items.AddRange(new object[] {
            "Проверка подлинности SQL-сервер",
            "Проверка подлинности Windows"});
            this.comboBoxIntegratedSecurity.Location = new System.Drawing.Point(133, 81);
            this.comboBoxIntegratedSecurity.Name = "comboBoxIntegratedSecurity";
            this.comboBoxIntegratedSecurity.Size = new System.Drawing.Size(303, 21);
            this.comboBoxIntegratedSecurity.TabIndex = 5;
            this.comboBoxIntegratedSecurity.SelectedIndexChanged += new System.EventHandler(this.comboBoxItegratedSecurity_SelectedIndexChanged);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(191, 240);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(87, 23);
            this.buttonTest.TabIndex = 10;
            this.buttonTest.Text = "Подключить";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxInitialCatalog
            // 
            this.textBoxInitialCatalog.Location = new System.Drawing.Point(177, 41);
            this.textBoxInitialCatalog.Name = "textBoxInitialCatalog";
            this.textBoxInitialCatalog.Size = new System.Drawing.Size(188, 20);
            this.textBoxInitialCatalog.TabIndex = 14;
            this.textBoxInitialCatalog.Text = "043_3_bolnica";
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Location = new System.Drawing.Point(177, 12);
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(188, 20);
            this.textBoxDataSource.TabIndex = 13;
            this.textBoxDataSource.Text = "MICROSOF-9CC985\\SQLEXPRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Целевой каталог";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя сервера";
            // 
            // panelIDPassword
            // 
            this.panelIDPassword.Controls.Add(this.textBoxPassword);
            this.panelIDPassword.Controls.Add(this.textBoxUserID);
            this.panelIDPassword.Controls.Add(this.label5);
            this.panelIDPassword.Controls.Add(this.label4);
            this.panelIDPassword.Location = new System.Drawing.Point(34, 117);
            this.panelIDPassword.Name = "panelIDPassword";
            this.panelIDPassword.Size = new System.Drawing.Size(402, 100);
            this.panelIDPassword.TabIndex = 15;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(196, 62);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 13;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(196, 19);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логин";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 298);
            this.Controls.Add(this.panelIDPassword);
            this.Controls.Add(this.textBoxInitialCatalog);
            this.Controls.Add(this.textBoxDataSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.comboBoxIntegratedSecurity);
            this.Controls.Add(this.label3);
            this.Name = "ConnectionForm";
            this.Text = "Подключение соединения";
            this.panelIDPassword.ResumeLayout(false);
            this.panelIDPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIntegratedSecurity;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxInitialCatalog;
        private System.Windows.Forms.TextBox textBoxDataSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIDPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}