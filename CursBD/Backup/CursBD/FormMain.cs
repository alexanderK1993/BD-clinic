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
    public partial class FormMain : Form
    {
        public static SqlConnection conn = new SqlConnection();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectionForm conForm = new ConnectionForm();
            conForm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            try
            {
                if (radioButtonAdmin.Checked == true)
                {
                    SqlCommand cmd = FormMain.conn.CreateCommand();
                    cmd.CommandText = "EXECUTE HPCheckAdmin @Логин, @Пароль,@Тип, @Код OUTPUT";
                    cmd.Parameters.Add("@Логин", SqlDbType.Char).Value = login;
                    cmd.Parameters.Add("@Пароль", SqlDbType.Char).Value = password;
                    cmd.Parameters.Add("@Тип", SqlDbType.Char).Value ="админ";
                    cmd.Parameters.Add(new SqlParameter("@Код", SqlDbType.Int));
                    cmd.Parameters["@Код"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    int code = Convert.ToInt32(cmd.Parameters["@Код"].Value.ToString().Trim());
                    if (code == 0)
                    {
                        this.Hide();
                        FormAdminPage formAdminPage = new FormAdminPage();
                        if (formAdminPage.ShowDialog() == DialogResult.Cancel)
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверная пара логин-пароль", "Ошибка входа", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (radioButtonPacient.Checked == true)
                    {
                        this.Hide();
                        FormPacient formPacient = new FormPacient();
                        if (formPacient.ShowDialog() == DialogResult.Cancel)
                        {
                            this.Show();
                        }
                    }
                    else
                        if (radioButtonDoctor.Checked == true)
                        {
                            SqlCommand cmd = FormMain.conn.CreateCommand();
                            cmd.CommandText = "EXECUTE HPCheckAdmin @Логин, @Пароль,@Тип, @Код OUTPUT";
                            cmd.Parameters.Add("@Логин", SqlDbType.Char).Value = login;
                            cmd.Parameters.Add("@Пароль", SqlDbType.Char).Value = password;
                            cmd.Parameters.Add("@Тип", SqlDbType.Char).Value = "врач";
                            cmd.Parameters.Add(new SqlParameter("@Код", SqlDbType.Int));
                            cmd.Parameters["@Код"].Direction = ParameterDirection.Output;
                            cmd.ExecuteNonQuery();
                            int code = Convert.ToInt32(cmd.Parameters["@Код"].Value.ToString().Trim());
                            if (code == 0)
                            {
                                this.Hide();
                                FormDoctorPage formDoctorPage = new FormDoctorPage();
                                if (formDoctorPage.ShowDialog() == DialogResult.Cancel)
                                {
                                    this.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверная пара логин-пароль", "Ошибка входа", MessageBoxButtons.OK);
                            }

                        }
                    /*if (radioButtonSeller.Checked == true)
                    {
                        SqlCommand cmd = FormMain.conn.CreateCommand();
                        cmd.CommandText = "EXECUTE HPCheckAdmin @Логин, @Пароль, @Код OUTPUT";
                        cmd.Parameters.Add("@Логин", SqlDbType.Char).Value = login;
                        cmd.Parameters.Add("@Пароль", SqlDbType.Char).Value = password;
                        cmd.Parameters.Add(new SqlParameter("@Код", SqlDbType.Int));
                        cmd.Parameters["@Код"].Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        int code = Convert.ToInt32(cmd.Parameters["@Код"].Value.ToString().Trim());
                        if (code == 0)
                        {
                            this.Hide();
                            FormSellerPage formSellerPage = new FormSellerPage();
                            if (formSellerPage.ShowDialog() == DialogResult.Cancel)
                            {
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверная пара логин-пароль", "Ошибка входа", MessageBoxButtons.OK);
                        }
                    }
                    else*/
                    {
                        //this.Hide();
                       /* FormPacient formPacientPage = new FormPacient(login);
                        if (formPacientPage.ShowDialog() == DialogResult.Cancel)
                        {
                            this.Show();
                        }*/
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                this.buttonConnect_Click(sender, e);
                this.Show();
                this.buttonLogin_Click(sender, e);
            }
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}