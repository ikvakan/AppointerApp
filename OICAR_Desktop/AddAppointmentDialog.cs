
using ClassLibrary.DAL;
using ClassLibrary.DAL.Interfaces;
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
    public partial class AddAppointmentDialog : Form
    {

        private OpenFormHelper openForm;
        private UniteOfWork uow;
        private ModelContainer db;


        public AddAppointmentDialog()
        {

            InitializeComponent();
            InitRepo();
            InitHelperClass();
            FillStatus();
            FillDuration();
            PopulateClients();
            PopulateWorkers();
            PopulateService();

        }



        private void InitRepo()
        {
            db = new ModelContainer();
            uow = new UniteOfWork(db);

        }
        private void PopulateService()
        {
            cbService.DataSource = uow.Services.GetAll().ToList();
            cbService.DisplayMember = nameof(Service.Name);
            cbService.ValueMember = nameof(Service.IdService);
        }
        private void PopulateClients()
        {

            List<Client> clients = uow.Clients.GetAll().ToList();
            cbClients.DataSource = clients;
            cbClients.ValueMember = nameof(Client.IdClient);
            cbClients.DisplayMember = nameof(Client.FullName);
        }

        private void FillDuration()
        {

            cbDuration.DataSource = HelperMethods.FillDuration();

        }

        private void FillStatus()
        {

            cbStatus.DataSource = uow.Status.GetAll().ToList();
            cbStatus.DisplayMember = nameof(Status.Name);
            cbStatus.ValueMember = nameof(Status.IdStatus);
        }

        private void InitHelperClass()
        {
            openForm = new OpenFormHelper();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    Appointment appointment = GetAppointment();
                    uow.Apponitments.Insert(appointment);
                    uow.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Greška kod upisa termina.");
                }
                Close();
            }

        }

        private Appointment GetAppointment()
        {
            Appointment appointment = new Appointment();
            appointment.Date = DateTime.Parse(dtpDate.Value.ToShortDateString());
            appointment.Client = (Client)cbClients.SelectedItem;
            appointment.Time = DateTime.Parse(dtpTime.Value.ToShortTimeString());
            //appointment.Service = (Service)cbService.SelectedItem;
            appointment.Status = (Status)cbStatus.SelectedItem;
            appointment.Duration = (int)cbDuration.SelectedItem;
            //appointment.Worker = (Worker)cbWorker.SelectedItem;
            appointment.Remark = txtRemark.Text;

            return appointment;
        }

        private bool IsValid()
        {
            List<ComboBox> boxes = new List<ComboBox> { cbClients, cbService, cbWorker };
            foreach (var item in boxes)
            {
                if (item.SelectedItem == null)
                {
                    MessageBox.Show("Potrebno ispunit sva polja.");
                    return false;

                }
            }

            return true;
        }


        private void PopulateWorkers()
        {
            List<Worker> workers = uow.Workers.GetAll().ToList();
            cbWorker.DataSource = workers;
            cbWorker.ValueMember = nameof(Worker.IdWorker);
            cbWorker.DisplayMember = nameof(Worker.FullName);
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDuration();
        }

        private void SetDuration()
        {
            Service service = cbService.SelectedItem as Service;

            foreach (var item in cbDuration.Items)
            {
                if ((int)item == service.Duration)
                {
                    cbDuration.SelectedItem = item;
                }
            }
        }
    }
}
