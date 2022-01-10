using ClassLibrary.DAL;
using ClassLibrary.Model;
using OICAR_Desktop.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICAR_Desktop
{
    public partial class WorkingHoursForm : Form
    {

        private Panel _pnlContent;
        private Panel _pnlChildForm;
        private UniteOfWork uow;
        private CompanyLogin _companyLogin;
        private List<string> listOfDays;
        private bool checkWorkingHours;
        private Company _company;
        private List<Working_Hours> _workingHours;


        public WorkingHoursForm(Panel pnlConent,Panel pnlChildForm, CompanyLogin companyLogin,Company company,List<Working_Hours> workingHours)
        {
            _pnlContent = pnlConent;
            _pnlChildForm = pnlChildForm;
            _companyLogin = companyLogin;
            _company = company;
            _workingHours = workingHours;
            InitializeComponent();
            InitiRepository();
            InitListOfDays();
            CheckIfDataExists();
        }

        private void CheckIfDataExists()
        {
           // var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);
           // var workingHorus = uow.WorkingHours.GetWorking_HoursForCompany(company.IdCompany);

            if (_workingHours.Count() != 0)
            {
                checkWorkingHours = false;
                SetAddUpdateButtonText(false);
                FillForm(_workingHours.ToList());
                
            }
            else
            {
                SetAddUpdateButtonText(true);
                checkWorkingHours = true;
            }
        }

        private void SetAddUpdateButtonText(bool result)
        {
            if (result)
            {
                btnSaveUpdate.Text = "Spremi";
            }
            else
                btnSaveUpdate.Text = "Ažuriraj";
        }

        private void FillForm(List<Working_Hours> workingHorus)
        {
            foreach (var item in workingHorus)
            {
                switch (item.Day)
                {
                    case "Ponedjeljak":
                        FillMonday(item.Start_Time, item.End_Time, item.Is_NonWorking);
                        break;
                    case "Utorak":
                        FillTuesday(item.Start_Time, item.End_Time, item.Is_NonWorking);
                        break;
                    case "Srijeda":
                        FillWednesday(item.Start_Time, item.End_Time, item.Is_NonWorking);
                        break;
                    case "Četvrtak":
                        FillThursday(item.Start_Time, item.End_Time, item.Is_NonWorking);
                        break;
                    case "Petak":
                        FillFriday(item.Start_Time, item.End_Time, item.Is_NonWorking);
                        break;
                    case "Subota":
                        FillSaturday(item.Start_Time, item.End_Time, item.Is_NonWorking);
                        break;
                    case "Nedjelja":
                        FillSunday(item.Start_Time, item.End_Time, item.Is_NonWorking);
                        break;


                }
            }
        }

        private void FillSunday(DateTime start_Time, DateTime end_Time, bool is_NonWorking)
        {
            dtSunFrom.Value = DateTime.Parse(start_Time.ToShortTimeString());
            dtSunTo.Value = DateTime.Parse(end_Time.ToShortTimeString());
            cbSun.Checked = is_NonWorking;
        }

        private void FillSaturday(DateTime start_Time, DateTime end_Time, bool is_NonWorking)
        {
            dtSatFrom.Value = DateTime.Parse(start_Time.ToShortTimeString());
            dtSatTo.Value = DateTime.Parse(end_Time.ToShortTimeString());
            cbSat.Checked = is_NonWorking;
        }

        private void FillFriday(DateTime start_Time, DateTime end_Time, bool is_NonWorking)
        {
            dtFriFrom.Value = DateTime.Parse(start_Time.ToShortTimeString());
            dtFriTo.Value = DateTime.Parse(end_Time.ToShortTimeString());
            cbFri.Checked = is_NonWorking;
        }

        private void FillThursday(DateTime start_Time, DateTime end_Time, bool is_NonWorking)
        {
            dtThFrom.Value = DateTime.Parse(start_Time.ToShortTimeString());
            dtThTo.Value = DateTime.Parse(end_Time.ToShortTimeString());
            cbTh.Checked = is_NonWorking;
        }

        private void FillWednesday(DateTime start_Time, DateTime end_Time, bool is_NonWorking)
        {
            dtWedFrom.Value = DateTime.Parse(start_Time.ToShortTimeString());
            dtWedTo.Value = DateTime.Parse(end_Time.ToShortTimeString());
            cbWed.Checked = is_NonWorking;
        }

        private void FillTuesday(DateTime start_Time, DateTime end_Time, bool is_NonWorking)
        {
            dtTueFrom.Value = DateTime.Parse(start_Time.ToShortTimeString());
            dtTueTo.Value = DateTime.Parse(end_Time.ToShortTimeString());
            cbTue.Checked = is_NonWorking;
        }

        private void FillMonday(DateTime start_Time, DateTime end_Time, bool is_NonWorking)
        {
            dtMonFrom.Value = DateTime.Parse(start_Time.ToShortTimeString());
            dtMonTo.Value = DateTime.Parse(end_Time.ToShortTimeString());
            cbMon.Checked = is_NonWorking;
        }

        private void InitListOfDays()
        {
            listOfDays = new List<string> { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };
        }

        private void InitiRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
           // var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);

            try
            {

                if (checkWorkingHours)
                {
                    foreach (var day in listOfDays)
                    {

                        Working_Hours workingHours = GetWorkingHours(day, _company.IdCompany);
                        uow.WorkingHours.Insert(workingHours);

                    }

                    DialogResult addedResult = HelperMethods.DialogHelper("Radni dani uspješno dodani.", "Dodavanje", MessageBoxButtons.OK);

                    if (addedResult==DialogResult.OK)
                    {
                        Close();
                        uow.SaveChanges();

                    }


                }
                else
                {
                    foreach (var day in listOfDays)
                    {

                        //var workDay = uow.WorkingHours.GetWorkingHoursByDayForCompany(day,company.IdCompany);
                       // var workDayId = uow.WorkingHours.GetWorkingHoursIdByDayForCompany(day,company.IdCompany);

                        Working_Hours workingHours=GetWorkingHoursUpdate(day,_company.IdCompany);
                        uow.WorkingHours.Update(workingHours);

                    }

                    DialogResult updatedResult = HelperMethods.DialogHelper("Radni dani uspješno ažurirani.", "Ažuriranje", MessageBoxButtons.OK);

                    if (updatedResult == DialogResult.OK)
                    {
                        Close();
                        uow.SaveChanges();

                    }


                }

                //uow.SaveChanges();

            

            }
            catch (EntitySqlException ex)
            {

                MessageBox.Show("Greška.\n" + ex.Message);
            }
        }

        private Working_Hours GetWorkingHoursUpdate(string day, int idCompany)
        {

            switch (day)
            {
                case "Ponedjeljak":
                    return UpdateDayOfWeek(day, dtMonFrom, dtMonTo, cbMon, idCompany);
                case "Utorak":
                    return UpdateDayOfWeek(day, dtTueFrom, dtTueTo, cbTue, idCompany);
                case "Srijeda":
                    return UpdateDayOfWeek( day,dtWedFrom, dtWedTo, cbWed, idCompany);
                case "Četvrtak":
                    return UpdateDayOfWeek( day,dtThFrom, dtThTo, cbTh, idCompany);
                case "Petak":
                    return UpdateDayOfWeek(day, dtFriFrom, dtFriTo, cbFri, idCompany);
                case "Subota":
                    return UpdateDayOfWeek(day, dtSatFrom, dtSatTo, cbSat, idCompany);
                case "Nedjelja":
                    return UpdateDayOfWeek(day, dtSunFrom, dtSunTo, cbSun, idCompany);
            }

            return null;
        }

        private Working_Hours UpdateDayOfWeek(string day, DateTimePicker dtFrom, DateTimePicker dtTo, CheckBox cbIsNonWorking, int idCompany)
        {
            var id = uow.WorkingHours.GetWorkingHoursIdByDayForCompany(day, idCompany);

            Working_Hours working_Hours = new Working_Hours();
            working_Hours.IdWorkingHours = id;
            working_Hours.Day = day;
            working_Hours.Start_Time = DateTime.Parse(dtFrom.Value.ToShortTimeString());
            working_Hours.End_Time = dtTo.Value;
            working_Hours.Is_NonWorking = cbIsNonWorking.Checked;
            working_Hours.CompanyIdCompany = idCompany;

            return working_Hours;


         
        }

        private Working_Hours GetWorkingHours(string day, int idCompany)
        {

            switch (day)
            {
                case "Ponedjeljak":
                    return SetDayOfWeek(day, dtMonFrom, dtMonTo, cbMon, idCompany);
                case "Utorak":
                    return SetDayOfWeek(day, dtTueFrom, dtTueTo, cbTue, idCompany);
                case "Srijeda":
                    return SetDayOfWeek(day, dtWedFrom, dtWedTo, cbWed, idCompany);
                case "Četvrtak":
                    return SetDayOfWeek(day, dtThFrom, dtThTo, cbTh, idCompany);
                case "Petak":
                    return SetDayOfWeek(day, dtFriFrom, dtFriTo, cbFri, idCompany);
                case "Subota":
                    return SetDayOfWeek(day, dtSatFrom, dtSatTo, cbSat, idCompany);
                case "Nedjelja":
                    return SetDayOfWeek(day, dtSunFrom, dtSunTo, cbSun, idCompany);

            }

            return null;

        }



        private Working_Hours SetDayOfWeek(string day, DateTimePicker dtFrom, DateTimePicker dtTo, CheckBox cbIsNonWorking, int idCompany)
        {
            return new Working_Hours
            {
                Day = day,
                Start_Time = DateTime.Parse(dtFrom.Value.ToShortTimeString()),
                End_Time = dtTo.Value,
                Is_NonWorking = cbIsNonWorking.Checked,
                CompanyIdCompany = idCompany
            };
        }

        private void WorkingHoursForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetupForm setupForm = new SetupForm(_pnlContent, _companyLogin);
            OpenFormHelper.OpenChildForm(setupForm, _pnlChildForm);
        }
    }
}
