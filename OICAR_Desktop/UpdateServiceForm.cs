
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
    public partial class UpdateServiceForm : Form
    {
  

        private UniteOfWork uow;
        

        //public Panel pnlContent { get; set; }

        private Service _service;
        private Service_Type _serviceType;
        private Company _company;

        public UpdateServiceForm(Service service, Service_Type service_Type,Company company)
        {
            // _pnlContent = content;
            //pnlContent = new Panel();
            _company = company;
            _service = service;
            _serviceType = service_Type;
            InitializeComponent();

            InitRepository();
            FillServiceType();
            FillDuration();

            SetService();
        }

        private void SetService()
        {
            txtName.Text = _service.Name;
            txtPrice.Text = _service.Price.ToString();
            txtDesciption.Text = _service.Description;

        }


        private void FillDuration()
        {
            cbDuration.DataSource = HelperMethods.FillDuration();
            foreach (var item in cbDuration.Items)
            {
                if ((int)item == _service.Duration)
                {
                    cbDuration.SelectedItem = item;
                }
            }
        }

        private void FillServiceType()
        {
            cbServiceType.DataSource = uow.ServiceTypes.GetServiceTypeForCompany(_company.IdCompany);
            cbServiceType.DisplayMember = nameof(Service_Type.Name);
            cbServiceType.ValueMember = nameof(Service_Type.IdServiceType);

            foreach (Service_Type item in cbServiceType.Items)
            {
                if (item.IdServiceType == _serviceType.IdServiceType)
                {
                    cbServiceType.SelectedItem = item;
                }
            }
        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {


            Service service = GetService();

            uow.Services.Update(service);

            try
            {
                uow.SaveChanges();

            }
            catch (Exception)
            {

                ErrorMessage();
            }

            Close();


        }

        private Service GetService()
        {
            Service service = new Service();
            service.IdService = _service.IdService;
            service.Name = txtName.Text;
            service.Price = int.Parse(txtPrice.Text);
            service.Duration = (int)cbDuration.SelectedItem;
            service.Description = txtDesciption.Text;
            var service_Type = cbServiceType.SelectedItem as Service_Type;
            service.Service_TypeIdServiceType = service_Type.IdServiceType;
            
            


            return service;
        }

        private void ErrorMessage()
        {
            MessageBox.Show("Greška kod unosa.");
        }

      
    }
}

