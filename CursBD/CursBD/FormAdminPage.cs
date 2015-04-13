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
        public partial class FormAdminPage : Form
        {
            public FormAdminPage()
            {
                InitializeComponent();
            }

            private void buttonExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void buttonMakeChanges_Click(object sender, EventArgs e)
            {
                try
                {
                    string table = comboBoxEditTables.SelectedItem.ToString();
                    if (radioButtonInsertInto.Checked == true)
                    {
                        switch (table)
                        {
                            case "���������� �����":
                                FormDistrictsDoctors formDistrictsDoctors = new FormDistrictsDoctors();
                                formDistrictsDoctors.ShowDialog();
                                break;
                            case "�����-�����������":
                                FormSpecialDoctors formSpecialDoctors = new FormSpecialDoctors();
                                formSpecialDoctors.ShowDialog();
                                break;
                            case "���������� ������������":
                                FormSpecialSheldure formSpecialSheldure = new FormSpecialSheldure();
                                formSpecialSheldure.ShowDialog();
                                break;
                            case "���������� ����������":
                                FormDistricsSheldure formDistricsSheldure = new FormDistricsSheldure();
                                formDistricsSheldure.ShowDialog();
                                break;
                            case "���������� ����������� ���������":
                                FormProcedureSheldure formProcedureSheldure = new FormProcedureSheldure();
                                formProcedureSheldure.ShowDialog();
                                break;
                            case "��������":
                                FormPacients formPacients = new FormPacients();
                                formPacients.ShowDialog();
                                break;
                            case "������":
                                FormServices formServices = new FormServices();
                                formServices.ShowDialog();
                                break;

                        }
                    }
                    else
                    {
                        if (radioButtonUpdate.Checked == true)
                        {
                            switch (table)
                            {
                                case "���������� �����":
                                    FormEditDistrictsDoctors formEditDistrictsDoctors = new FormEditDistrictsDoctors();
                                    formEditDistrictsDoctors.ShowDialog();
                                    break;
                                case "�����-�����������":
                                    FormEditSpecialDoctors formEditSpecialDoctors = new FormEditSpecialDoctors();
                                    formEditSpecialDoctors.ShowDialog();
                                    break;
                                case "���������� ������������":
                                    FormEditSpecialSheldure formEditSpecialSheldure = new FormEditSpecialSheldure();
                                    formEditSpecialSheldure.ShowDialog();
                                    break;
                                case "���������� ����������":
                                    FormEditDistricsSheldure formEditDistricsSheldure = new FormEditDistricsSheldure();
                                    formEditDistricsSheldure.ShowDialog();
                                    break;
                                case "���������� ����������� ���������":
                                    FormEditProcedureSheldure formEditProcedureSheldure = new FormEditProcedureSheldure();
                                    formEditProcedureSheldure.ShowDialog();
                                    break;
                                case "��������":
                                    FormEditPacients formEditPacients = new FormEditPacients();
                                    formEditPacients.ShowDialog();
                                    break;
                                case "������":
                                    FormEditServices formEditServices = new FormEditServices();
                                    formEditServices.ShowDialog();
                                    break;
                            }
                        }
                        else
                        {
                            if (radioButtonDelete.Checked == true)
                            {
                                switch (table)
                                {
                                    case "���������� �����":
                                        FormDeleteDistrictsDoctors formDeleteDistrictsDoctors = new FormDeleteDistrictsDoctors();
                                        formDeleteDistrictsDoctors.ShowDialog();
                                        break;
                                    case "�����-�����������":
                                        FormDeleteSpecialDoctors formDeleteSpecialDoctors = new FormDeleteSpecialDoctors();
                                        formDeleteSpecialDoctors.ShowDialog();
                                        break;
                                    case "���������� ������������":
                                        FormDeleteSpecialSheldure formDeleteSpecialSheldure = new FormDeleteSpecialSheldure();
                                        formDeleteSpecialSheldure.ShowDialog();
                                        break;
                                    case "���������� ����������":
                                        FormDeleteDistricsSheldure formDeleteDistricsSheldure = new FormDeleteDistricsSheldure();
                                        formDeleteDistricsSheldure.ShowDialog();
                                        break;
                                    case "���������� ����������� ���������":
                                        FormDeleteProcedureSheldure formDeleteProcedureSheldure = new FormDeleteProcedureSheldure();
                                        formDeleteProcedureSheldure.ShowDialog();
                                        break;
                                    case "��������":
                                        FormDeletePacients formDeletePacients = new FormDeletePacients();
                                        formDeletePacients.ShowDialog();
                                        break;
                                    case "������":
                                        FormDeleteServices formDeleteServices = new FormDeleteServices();
                                        formDeleteServices.ShowDialog();
                                        break;
                                }
                            }
                        }
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("�������� ������� ��� ���������", "������ ���������", MessageBoxButtons.OK);
                }
            }

            private void buttonViewTable_Click(object sender, EventArgs e)
            {
                try
                {
                    string table = comboBoxViewTables.SelectedItem.ToString();
                    switch (table)
                    {
                        case "���������� �����":
                            FormViewDistrictsDoctors formViewDistrictsDoctors = new FormViewDistrictsDoctors();
                            formViewDistrictsDoctors.ShowDialog();
                            break;
                        case "�����-�����������":
                            FormViewSpecialDoctors formViewSpecialDoctors = new FormViewSpecialDoctors();
                            formViewSpecialDoctors.ShowDialog();
                            break;
                        case "���������� ������������":
                            FormViewSpecialSheldure formViewSpecialSheldure = new FormViewSpecialSheldure();
                            formViewSpecialSheldure.ShowDialog();
                            break;
                        case "���������� ����������":
                            FormViewDistricsSheldure formViewDistricsSheldure = new FormViewDistricsSheldure();
                            formViewDistricsSheldure.ShowDialog();
                            break;
                        case "���������� ����������� ���������":
                            FormViewProcedureSheldure formViewProcedureSheldure = new FormViewProcedureSheldure();
                            formViewProcedureSheldure.ShowDialog();
                            break;
                        case "��������":
                            FormViewPacients formViewPacients = new FormViewPacients();
                            formViewPacients.ShowDialog();
                            break;
                        case "������":
                            FormViewServices formViewServices = new FormViewServices();
                            formViewServices.ShowDialog();
                            break;
                        case "�����":
                            FormViewRecieve formViewRecieve = new FormViewRecieve();
                            formViewRecieve.ShowDialog();
                            break;
                        case "�������":
                            FormViewDistricts formViewDistricts = new FormViewDistricts();
                            formViewDistricts.ShowDialog();
                            break;
                         case "�������":
                            FormViewCab formViewCab = new FormViewCab();
                            formViewCab.ShowDialog();
                            break;
                         case "����������� �������":
                            FormViewProcedureCab formViewProcedureCab = new FormViewProcedureCab();
                            formViewProcedureCab.ShowDialog();
                            break;
                         case "������":
                            FormViewRecord formViewRecord = new FormViewRecord();
                            formViewRecord.ShowDialog();
                            break;
                         case "��������� ������":
                            FormViewServicesRendered formViewServicesRendered = new FormViewServicesRendered();
                            formViewServicesRendered.ShowDialog();
                            break;
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("�������� ������� ��� ���������", "������ ���������", MessageBoxButtons.OK);
                }
            }

            private void comboBoxEditTables_SelectedIndexChanged(object sender, EventArgs e)
            {

            }         
        }
      }
    