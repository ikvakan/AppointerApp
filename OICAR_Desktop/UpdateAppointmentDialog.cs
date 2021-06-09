using OICAR_Desktop.DAL;
using OICAR_Desktop.Model;
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

      
        public UpdateAppointmentDialog(Appointment appointment)
        {
           
            _appointment= appointment;
            InitializeComponent();
            InitiRepository();
            FillStatus();
            FillDuration();
            FillTime();
            FillDate();
            PopulateClients();
            PopulateWorkers();
            PopulateService();
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

        private void PopulateService()
        {
            cbService.DataSource = uow.Services.GetAll().ToList();
            cbService.DisplayMember = nameof(Service.Name);
            cbService.ValueMember = nameof(Service.IdService);

            foreach (Service item in cbService.Items)
            {
                if (item.Name==_appointment.Service.Name)
                {
                    cbService.SelectedItem = item;
                }
            }
        }

        private void PopulateWorkers()
        {
            List<Worker> workers = uow.Workers.GetAll().ToList();
            cbWorker.DataSource = workers;
            cbWorker.ValueMember = nameof(Worker.IdWorker);
            cbWorker.DisplayMember = nameof(Worker.FullName);


            foreach (Worker item in cbWorker.Items)
            {
                if (item.FullName== _appointment.Worker.FullName)
                {
                    cbWorker.SelectedItem = item;
                }
            }
        }

        private void PopulateClients()
        {
            List<Client> clients = uow.Clients.GetAll().ToList();
            cbClients.DataSource = clients;
            cbClients.ValueMember = nameof(Client.IdClient);
            cbClients.DisplayMember = nameof(Client.FullName);

            foreach (Client item in cbClients.Items)
            {
                if (item.FullName == _appointment.Client.FullName)
                {
                    cbClients.SelectedItem = item;
                }
            }
        }

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

                MessageBox.Show("Greška" + ex.Message);
            }

            Close();
          
        }

     

        private Appointment GetAppointment()
        {
            Appointment appointment = new Appointment();
            Client client = (Client)cbClients.SelectedItem;
            Service service = (Service)cbService.SelectedItem;
            Status status = (Status)cbStatus.SelectedItem;
            Worker worker = (Worker)cbWorker.SelectedItem;

            appointment.IdAppointment = _appointment.IdAppointment;
            appointment.ClientIdClient = client.IdClient;
            appointment.WorkerIdWorker = worker.IdWorker;
            appointment.ServiceIdService = service.IdService;
            appointment.StatusIdStatus = status.IdStatus;
            appointment.Date = DateTime.Parse(dtpDate.Value.ToShortDateString());
            appointment.Client= (Client)cbClients.SelectedItem; 
            appointment.Time = DateTime.Parse(dtpTime.Value.ToShortTimeString());
            appointment.Service = (Service)cbService.SelectedItem;
            appointment.Status = (Status)cbStatus.SelectedItem;
            appointment.Duration = (int)cbDuration.SelectedItem;
            appointment.Worker = (Worker)cbWorker.SelectedItem;
            appointment.Remark = txtRemark.Text;

     


            return appointment;
        }
    }
}
