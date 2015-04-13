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
            cmd.CommandText = "SELECT [����� ��������] FROM room";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {            
               comboBoxCab.Items.Add(reader["����� ��������"].ToString());
            }
            comboBoxCab.Refresh();
            reader.Close();
            cmd.CommandText = "SELECT [����� �������] FROM Districts";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxNumberDistrict.Items.Add(reader["����� �������"].ToString());
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
        cmd.CommandText = "EXECUTE HPAddDistrictDoctors @�����,@�������, @���,@��������,@�������,@������������";
        cmd.Parameters.Add("@�����,", SqlDbType.Int).Value = textBoxNumber.Text;
        cmd.Parameters.Add("@�������,", SqlDbType.Char).Value = textBoxFamily.Text;
        cmd.Parameters.Add("@���", SqlDbType.Char).Value = textBoxName.Text;
        cmd.Parameters.Add("@��������", SqlDbType.Char).Value = textBoxOtch.Text;
         cmd.Parameters.Add("@�������", SqlDbType.Int).Value =comboBoxCab.SelectedItem.ToString().Trim();
         cmd.Parameters.Add("@����� �������", SqlDbType.Int).Value =comboBoxNumberDistrict.SelectedItem.ToString().Trim();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("�������� ������� �������� �� �����", "���������� ��������� �� �����", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("������ ���������� ��������� �� �����", "���������� ��������� �� �����", MessageBoxButtons.OK);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("������ ����������� � �������", "���������� ��������� �� �����", MessageBoxButtons.OK);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("��������� ��������� ��� ����������� ����", "���������� ��������� �� �����", MessageBoxButtons.OK);
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