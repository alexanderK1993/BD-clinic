namespace CursBD
{
    partial class FormAdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPage));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapterDistrictDoctors = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSetDistrictDoctors1 = new CursBD.DataSetDistrictDoctors();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxViewTables = new System.Windows.Forms.ComboBox();
            this.buttonViewTable = new System.Windows.Forms.Button();
            this.groupBoxModify = new System.Windows.Forms.GroupBox();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertInto = new System.Windows.Forms.RadioButton();
            this.comboBoxEditTables = new System.Windows.Forms.ComboBox();
            this.buttonMakeChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDistrictDoctors1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=MICROSOF-9CC985\\SQLEXPRESS;Initial Catalog=043_3_bolnica;Integrated S" +
                "ecurity=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapterDistrictDoctors
            // 
            this.sqlDataAdapterDistrictDoctors.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapterDistrictDoctors.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "DistrictDoctors", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("number", "number"),
                        new System.Data.Common.DataColumnMapping("номер участка", "номер участка"),
                        new System.Data.Common.DataColumnMapping("Фамилия", "Фамилия"),
                        new System.Data.Common.DataColumnMapping("Имя", "Имя"),
                        new System.Data.Common.DataColumnMapping("Отчество", "Отчество"),
                        new System.Data.Common.DataColumnMapping("кабинет", "кабинет")})});
            // 
            // dataSetDistrictDoctors1
            // 
            this.dataSetDistrictDoctors1.DataSetName = "DataSetDistrictDoctors";
            this.dataSetDistrictDoctors1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(419, 200);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxViewTables);
            this.groupBox1.Controls.Add(this.buttonViewTable);
            this.groupBox1.Location = new System.Drawing.Point(281, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр таблиц";
            // 
            // comboBoxViewTables
            // 
            this.comboBoxViewTables.FormattingEnabled = true;
            this.comboBoxViewTables.Items.AddRange(new object[] {
            "Участковые врачи",
            "Врачи-специалисты",
            "Расписание специалистов",
            "Расписание участковых",
            "Расписание процедурных кабинетов",
            "Пациенты",
            "Услуги",
            "Прием",
            "Участки",
            "Кабинет",
            "Процедурный кабинет",
            "Запись",
            "Оказанные услуги"});
            this.comboBoxViewTables.Location = new System.Drawing.Point(26, 28);
            this.comboBoxViewTables.Name = "comboBoxViewTables";
            this.comboBoxViewTables.Size = new System.Drawing.Size(151, 21);
            this.comboBoxViewTables.TabIndex = 1;
            this.comboBoxViewTables.Text = "Таблица для просмотра";
            // 
            // buttonViewTable
            // 
            this.buttonViewTable.Location = new System.Drawing.Point(62, 70);
            this.buttonViewTable.Name = "buttonViewTable";
            this.buttonViewTable.Size = new System.Drawing.Size(75, 23);
            this.buttonViewTable.TabIndex = 0;
            this.buttonViewTable.Text = "Просмотр";
            this.buttonViewTable.UseVisualStyleBackColor = true;
            this.buttonViewTable.Click += new System.EventHandler(this.buttonViewTable_Click);
            // 
            // groupBoxModify
            // 
            this.groupBoxModify.Controls.Add(this.radioButtonDelete);
            this.groupBoxModify.Controls.Add(this.radioButtonUpdate);
            this.groupBoxModify.Controls.Add(this.radioButtonInsertInto);
            this.groupBoxModify.Controls.Add(this.comboBoxEditTables);
            this.groupBoxModify.Controls.Add(this.buttonMakeChange);
            this.groupBoxModify.Location = new System.Drawing.Point(25, 12);
            this.groupBoxModify.Name = "groupBoxModify";
            this.groupBoxModify.Size = new System.Drawing.Size(218, 167);
            this.groupBoxModify.TabIndex = 6;
            this.groupBoxModify.TabStop = false;
            this.groupBoxModify.Text = "Редактирование таблиц";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(27, 95);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(107, 17);
            this.radioButtonDelete.TabIndex = 4;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Удалить запись";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(27, 71);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(145, 17);
            this.radioButtonUpdate.TabIndex = 3;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Редактировать таблицу";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsertInto
            // 
            this.radioButtonInsertInto.AutoSize = true;
            this.radioButtonInsertInto.Location = new System.Drawing.Point(27, 47);
            this.radioButtonInsertInto.Name = "radioButtonInsertInto";
            this.radioButtonInsertInto.Size = new System.Drawing.Size(148, 17);
            this.radioButtonInsertInto.TabIndex = 2;
            this.radioButtonInsertInto.TabStop = true;
            this.radioButtonInsertInto.Text = "Добавить новую запись";
            this.radioButtonInsertInto.UseVisualStyleBackColor = true;
            // 
            // comboBoxEditTables
            // 
            this.comboBoxEditTables.FormattingEnabled = true;
            this.comboBoxEditTables.Items.AddRange(new object[] {
            "Участковые врачи",
            "Врачи-специалисты",
            "Расписание специалистов",
            "Расписание участковых",
            "Расписание процедурных кабинетов",
            "Пациенты",
            "Услуги"});
            this.comboBoxEditTables.Location = new System.Drawing.Point(27, 19);
            this.comboBoxEditTables.Name = "comboBoxEditTables";
            this.comboBoxEditTables.Size = new System.Drawing.Size(180, 21);
            this.comboBoxEditTables.TabIndex = 0;
            this.comboBoxEditTables.Text = "Таблица для редактирования";
            this.comboBoxEditTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditTables_SelectedIndexChanged);
            // 
            // buttonMakeChange
            // 
            this.buttonMakeChange.Location = new System.Drawing.Point(37, 129);
            this.buttonMakeChange.Name = "buttonMakeChange";
            this.buttonMakeChange.Size = new System.Drawing.Size(121, 23);
            this.buttonMakeChange.TabIndex = 1;
            this.buttonMakeChange.Text = "Внести изменения";
            this.buttonMakeChange.UseVisualStyleBackColor = true;
            this.buttonMakeChange.Click += new System.EventHandler(this.buttonMakeChanges_Click);
            // 
            // FormAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 235);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxModify);
            this.Name = "FormAdminPage";
            this.Text = "Режим администратора";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDistrictDoctors1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxModify.ResumeLayout(false);
            this.groupBoxModify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterDistrictDoctors;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private DataSetDistrictDoctors dataSetDistrictDoctors1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxViewTables;
        private System.Windows.Forms.Button buttonViewTable;
        private System.Windows.Forms.GroupBox groupBoxModify;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsertInto;
        private System.Windows.Forms.ComboBox comboBoxEditTables;
        private System.Windows.Forms.Button buttonMakeChange;
    }
}