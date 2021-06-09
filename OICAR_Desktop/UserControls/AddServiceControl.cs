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

namespace OICAR_Desktop.UserControls
{
    public partial class AddServiceControl : UserControl
    {

        private UniteOfWork uow;
        public AddServiceControl()
        {
            InitializeComponent();
            InitRepository();
            FillServiceType();
            FillDuration();
            InitValidation();
        }

        private void FillDuration()
        {
            cbDuration.DataSource=HelperMethods.FillDuration();
        }

        private void FillServiceType()
        {
            cbServiceType.DataSource = uow.ServiceTypes.GetAll();
            cbServiceType.DisplayMember = nameof(Service_Type.Name);
            cbServiceType.ValueMember= nameof(Service_Type.IdServiceType);
        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void InitValidation()
        {
            serviceMDBindingSource.DataSource = new ServiceMD();
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            AddServiceTypeDialog dialog = new AddServiceTypeDialog();
            dialog.Show();
            dialog.FormClosed += Dialog_FormClosed;
        }

        private void Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillServiceType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
               
                    Service service = GetService();

                    uow.Services.Insert(service);

                try
                {
                    uow.SaveChanges();
                    ResetForm();
                }
                catch (Exception)
                {

                    ErrorMessage();
                }
                
            }
            else
            {
                MessageBox.Show("Vrsta usluge je obavezna.");
            }
        }

        private void ResetForm()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtDesciption.Text = "";
            cbDuration.SelectedIndex = 0;
            cbServiceType.SelectedIndex = 0;
        }

        private Service GetService()
        {
            Service service = new Service();
            service.Name = txtName.Text;
            service.Price = int.Parse(txtPrice.Text);
            service.Duration = (int)cbDuration.SelectedItem;
            var serviceType = cbServiceType.SelectedItem as Service_Type;
           
            service.Service_Type = serviceType;
            service.Description = txtDesciption.Text;

            return service;
        }

        private void ErrorMessage()
        {
            MessageBox.Show("Greška kod unosa.");
        }

        private bool IsValid()
        {
            HelperMethods helper = new HelperMethods();
            return helper.IsValidForm<ServiceMD>(serviceMDBindingSource) && cbServiceType.Items.Count>0;
        }
    }
}
