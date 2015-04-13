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
                            case "Участковые врачи":
                                FormDistrictsDoctors formDistrictsDoctors = new FormDistrictsDoctors();
                                formDistrictsDoctors.ShowDialog();
                                break;
                            case "Врачи-специалисты":
                                FormSpecialDoctors formSpecialDoctors = new FormSpecialDoctors();
                                formSpecialDoctors.ShowDialog();
                                break;
                            case "Расписание специалистов":
                                FormSpecialSheldure formSpecialSheldure = new FormSpecialSheldure();
                                formSpecialSheldure.ShowDialog();
                                break;
                            case "Расписание участковых":
                                FormDistricsSheldure formDistricsSheldure = new FormDistricsSheldure();
                                formDistricsSheldure.ShowDialog();
                                break;
                            case "Расписание процедурных кабинетов":
                                FormProcedureSheldure formProcedureSheldure = new FormProcedureSheldure();
                                formProcedureSheldure.ShowDialog();
                                break;
                            case "Пациенты":
                                FormPacients formPacients = new FormPacients();
                                formPacients.ShowDialog();
                                break;
                            case "Услуги":
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
                                case "Участковые врачи":
                                    FormEditDistrictsDoctors formEditDistrictsDoctors = new FormEditDistrictsDoctors();
                                    formEditDistrictsDoctors.ShowDialog();
                                    break;
                                case "Врачи-специалисты":
                                    FormEditSpecialDoctors formEditSpecialDoctors = new FormEditSpecialDoctors();
                                    formEditSpecialDoctors.ShowDialog();
                                    break;
                                case "Расписание специалистов":
                                    FormEditSpecialSheldure formEditSpecialSheldure = new FormEditSpecialSheldure();
                                    formEditSpecialSheldure.ShowDialog();
                                    break;
                                case "Расписание участковых":
                                    FormEditDistricsSheldure formEditDistricsSheldure = new FormEditDistricsSheldure();
                                    formEditDistricsSheldure.ShowDialog();
                                    break;
                                case "Расписание процедурных кабинетов":
                                    FormEditProcedureSheldure formEditProcedureSheldure = new FormEditProcedureSheldure();
                                    formEditProcedureSheldure.ShowDialog();
                                    break;
                                case "Пациенты":
                                    FormEditPacients formEditPacients = new FormEditPacients();
                                    formEditPacients.ShowDialog();
                                    break;
                                case "Услуги":
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
                                    case "Участковые врачи":
                                        FormDeleteDistrictsDoctors formDeleteDistrictsDoctors = new FormDeleteDistrictsDoctors();
                                        formDeleteDistrictsDoctors.ShowDialog();
                                        break;
                                    case "Врачи-специалисты":
                                        FormDeleteSpecialDoctors formDeleteSpecialDoctors = new FormDeleteSpecialDoctors();
                                        formDeleteSpecialDoctors.ShowDialog();
                                        break;
                                    case "Расписание специалистов":
                                        FormDeleteSpecialSheldure formDeleteSpecialSheldure = new FormDeleteSpecialSheldure();
                                        formDeleteSpecialSheldure.ShowDialog();
                                        break;
                                    case "Расписание участковых":
                                        FormDeleteDistricsSheldure formDeleteDistricsSheldure = new FormDeleteDistricsSheldure();
                                        formDeleteDistricsSheldure.ShowDialog();
                                        break;
                                    case "Расписание процедурных кабинетов":
                                        FormDeleteProcedureSheldure formDeleteProcedureSheldure = new FormDeleteProcedureSheldure();
                                        formDeleteProcedureSheldure.ShowDialog();
                                        break;
                                    case "Пациенты":
                                        FormDeletePacients formDeletePacients = new FormDeletePacients();
                                        formDeletePacients.ShowDialog();
                                        break;
                                    case "Услуги":
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
                    MessageBox.Show("Выберите таблицу для изменения", "Ошибка изменения", MessageBoxButtons.OK);
                }
            }

            private void buttonViewTable_Click(object sender, EventArgs e)
            {
                try
                {
                    string table = comboBoxViewTables.SelectedItem.ToString();
                    switch (table)
                    {
                        case "Участковые врачи":
                            FormViewDistrictsDoctors formViewDistrictsDoctors = new FormViewDistrictsDoctors();
                            formViewDistrictsDoctors.ShowDialog();
                            break;
                        case "Врачи-специалисты":
                            FormViewSpecialDoctors formViewSpecialDoctors = new FormViewSpecialDoctors();
                            formViewSpecialDoctors.ShowDialog();
                            break;
                        case "Расписание специалистов":
                            FormViewSpecialSheldure formViewSpecialSheldure = new FormViewSpecialSheldure();
                            formViewSpecialSheldure.ShowDialog();
                            break;
                        case "Расписание участковых":
                            FormViewDistricsSheldure formViewDistricsSheldure = new FormViewDistricsSheldure();
                            formViewDistricsSheldure.ShowDialog();
                            break;
                        case "Расписание процедурных кабинетов":
                            FormViewProcedureSheldure formViewProcedureSheldure = new FormViewProcedureSheldure();
                            formViewProcedureSheldure.ShowDialog();
                            break;
                        case "Пациенты":
                            FormViewPacients formViewPacients = new FormViewPacients();
                            formViewPacients.ShowDialog();
                            break;
                        case "Услуги":
                            FormViewServices formViewServices = new FormViewServices();
                            formViewServices.ShowDialog();
                            break;
                        case "Прием":
                            FormViewRecieve formViewRecieve = new FormViewRecieve();
                            formViewRecieve.ShowDialog();
                            break;
                        case "Участки":
                            FormViewDistricts formViewDistricts = new FormViewDistricts();
                            formViewDistricts.ShowDialog();
                            break;
                         case "Кабинет":
                            FormViewCab formViewCab = new FormViewCab();
                            formViewCab.ShowDialog();
                            break;
                         case "Процедурный кабинет":
                            FormViewProcedureCab formViewProcedureCab = new FormViewProcedureCab();
                            formViewProcedureCab.ShowDialog();
                            break;
                         case "Запись":
                            FormViewRecord formViewRecord = new FormViewRecord();
                            formViewRecord.ShowDialog();
                            break;
                         case "Оказанные услуги":
                            FormViewServicesRendered formViewServicesRendered = new FormViewServicesRendered();
                            formViewServicesRendered.ShowDialog();
                            break;
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Выберите таблицу для просмотра", "Ошибка просмотра", MessageBoxButtons.OK);
                }
            }

            private void comboBoxEditTables_SelectedIndexChanged(object sender, EventArgs e)
            {

            }         
        }
      }
    