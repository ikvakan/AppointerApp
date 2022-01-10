
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
    public partial class UpdateAppointmentDialog : Form
    {
        private Appointment _appointment;

        private UniteOfWork uow;
        private CompanyLogin _companyLogin;

      
        public UpdateAppointmentDialog(Appointment appointment,CompanyLogin companyLogin)
        {
            _companyLogin = companyLogin;
            _appointment= appointment;
            InitializeComponent();
            InitiRepository();
            FillStatus();
            FillDuration();
            FillTime();
            FillDate();
            FillRemark();
            //PopulateClients();
            //PopulateWorkers();
            
        }

        private void FillRemark()
        {
            txtRemark.Text = _appointment.Remark;
        }

        private void InitiRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }
        private void FillDate()
        {
            dtpDate.Value = _appointment.Date;
        }

        private void FillTime()
        {
            dtpTime.Value = _appointment.Time;
        }

        //private void PopulateWorkers()
        //{
            
        //    List<Worker> workers = uow.Workers.GetAll().Where(w=>w.CompanyIdCompany==_companyLogin.IdCompanyLogin).ToList();
        //    cbWorker.DataSource = workers;
        //    cbWorker.ValueMember = nameof(Worker.IdWorker);
        //    cbWorker.DisplayMember = nameof(Worker.FullName);


        //    //foreach (Worker item in cbWorker.Items)
        //    //{
        //    //    if (item.FullName == _appointment.Company.Worker.FirstOrDefault(w=>w.FullName))
        //    //    {
        //    //        cbWorker.SelectedItem = item;
        //    //    }
        //    //}
        //}

        //private void PopulateClients()
        //{
        //    List<Client> clients = uow.Clients.GetAll().ToList();
        //    cbClients.DataSource = clients;
        //    cbClients.ValueMember = nameof(Client.IdClient);
        //    cbClients.DisplayMember = nameof(Client.FullName);

        //    foreach (Client item in cbClients.Items)
        //    {
        //        if (item.FullName == _appointment.Client.FullName)
        //        {
        //            cbClients.SelectedItem = item;
        //        }
        //    }
        //}

        private void FillDuration()
        {
            cbDuration.DataSource = HelperMethods.FillDuration();

            foreach (var item in cbDuration.Items)
            {
                if ((int)item ==_appointment.Duration)
                {
                    cbDuration.SelectedItem = item; 
                }
            }

            
        }

        private void FillStatus()
        {
            cbStatus.DataSource = uow.Status.GetAll().ToList();
            cbStatus.DisplayMember = nameof(Status.Name);
            cbStatus.ValueMember = nameof(Status.IdStatus);

            

            foreach (Status item in cbStatus.Items)
            {
                if (item.Name ==_appointment.Status.Name)
                {
                    cbStatus.SelectedItem = item;
                }
            }

        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment appointment = GetAppointment();
                uow.Apponitments.Update(appointment);
                uow.SaveChanges();
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greška" + ex.InnerException);
            }

            Close();
          
        }

     

        private Appointment GetAppointment()
        {
            Appointment appointment = new Appointment();
            Status status = (Status)cbStatus.SelectedItem;
            appointment.IdAppointment = _appointment.IdAppointment;
            appointment.ClientIdClient = _appointment.ClientIdClient;
            appointment.CompanyIdCompany = _appointment.CompanyIdCompany;                    
            appointment.StatusIdStatus = status.IdStatus;
            appointment.Date = DateTime.Parse(dtpDate.Value.ToShortDateString());
            appointment.Time = DateTime.Parse(dtpTime.Value.ToShortTimeString());
            appointment.Duration = (int)cbDuration.SelectedItem;
            appointment.Remark = txtRemark.Text;

            return appointment;
        }
    }
}
