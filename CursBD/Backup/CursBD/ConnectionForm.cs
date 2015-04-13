using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CursBD
{
        public partial class ConnectionForm : Form
        {
            public ConnectionForm()
            {
                InitializeComponent();
                comboBoxIntegratedSecurity.SelectedItem = comboBoxIntegratedSecurity.Items[1];
            }

            private void comboBoxItegratedSecurity_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBoxIntegratedSecurity.SelectedItem == comboBoxIntegratedSecurity.Items[1])
                {
                    panelIDPassword.Visible = false;
                }
                else
                {
                    panelIDPassword.Visible = true;
                }
            }

            private void buttonTest_Click(object sender, EventArgs e)
            {
                string dataSource, initialCatalog, integratedSecurity, userID = "", password = "";
                try
                {
                    dataSource = textBoxDataSource.Text.ToString();
                    initialCatalog = textBoxInitialCatalog.Text.ToString();
                    if (comboBoxIntegratedSecurity.SelectedItem == comboBoxIntegratedSecurity.Items[0])
                    {
                        integratedSecurity = "false";
                        userID = textBoxUserID.Text.ToString();
                        password = textBoxPassword.Text.ToString();
                    }
                    else
                    {
                        integratedSecurity = "true";
                    }
                }
                catch
                {
                    return;
                }
                FormMain.conn.ConnectionString = "Data Source=" + dataSource +
                                       ";Initial Catalog=" + initialCatalog + ";";
                if (comboBoxIntegratedSecurity.SelectedItem == comboBoxIntegratedSecurity.Items[0])
                {
                    FormMain.conn.ConnectionString += "User ID=" + userID +
                                            ";Password=" + password + ";";
                }
                else
                {
                    FormMain.conn.ConnectionString += "Integrated Security=" + integratedSecurity + ";";
                }
                try
                {
                    FormMain.conn.Open();
                    MessageBox.Show("Подключение успешно выполнено", "Проверка подключения", MessageBoxButtons.OK);
                    buttonTest.Visible = false;
                    this.Hide();
                   // buttonCancel.Visible = true;
                }
                catch (System.Data.SqlClient.SqlException ex1)
                {
                    MessageBox.Show("Не удалось выполнить подключение, проверьте корректность введенных данных", "Проверка подключения", MessageBoxButtons.OK);
                }
            }
        }
    

}