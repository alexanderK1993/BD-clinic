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
    public partial class FormDistrictsDoctors : Form
    {
        public FormDistrictsDoctors()
        {
            SqlCommand cmd = FormMain.conn.CreateCommand();
            InitializeComponent();
            cmd.CommandText = "SELECT [номер кабинета] FROM room";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {            
               comboBoxCab.Items.Add(reader["номер кабинета"].ToString());
            }
            comboBoxCab.Refresh();
            reader.Close();
            cmd.CommandText = "SELECT [номер участка] FROM Districts";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxNumberDistrict.Items.Add(reader["номер участка"].ToString());
            }
            reader.Close();
            comboBoxNumberDistrict.Update();
            

        }

        private void FormDistrictsDoctors_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    {SqlCommand cmd = FormMain.conn.CreateCommand();
        cmd.CommandText = "EXECUTE HPAddDistrictDoctors @Номер,@Фамилия, @Имя,@Отчество,@Кабинет,@НомерУчастка";
        cmd.Parameters.Add("@Номер,", SqlDbType.Int).Value = textBoxNumber.Text;
        cmd.Parameters.Add("@Фамилия,", SqlDbType.Char).Value = textBoxFamily.Text;
        cmd.Parameters.Add("@Имя", SqlDbType.Char).Value = textBoxName.Text;
        cmd.Parameters.Add("@Отчество", SqlDbType.Char).Value = textBoxOtch.Text;
         cmd.Parameters.Add("@Кабинет", SqlDbType.Int).Value =comboBoxCab.SelectedItem.ToString().Trim();
         cmd.Parameters.Add("@Номер участка", SqlDbType.Int).Value =comboBoxNumberDistrict.SelectedItem.ToString().Trim();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Препарат успешно добавлен на склад", "Добавление препарата на склад", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка добавления препарата на склад", "Добавление препарата на склад", MessageBoxButtons.OK);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Ошибка подключения к серверу", "Добавление препарата на склад", MessageBoxButtons.OK);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Корректно заполните все необходимые поля", "Добавление препарата на склад", MessageBoxButtons.OK);
            }
                    }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void comboBoxNumberDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}