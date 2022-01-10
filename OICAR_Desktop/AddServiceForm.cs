
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
    public partial class AddServiceForm : Form
    {
      
        private UniteOfWork uow;
        private CompanyLogin _companyLogin;

        public AddServiceForm(CompanyLogin companyLogin)
        {
            _companyLogin = companyLogin;
            InitializeComponent();
            InitRepository();
            InitValidation();
            FillDuration();
            FillServiceType();
           
           
        }

        private void FillDuration()
        {
            cbDuration.DataSource = HelperMethods.FillDuration();
        }

        private void FillServiceType()
        {
            var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);

            cbServiceType.DataSource = uow.ServiceTypes.GetServiceTypeForCompany(company.IdCompany);
            cbServiceType.DisplayMember = nameof(Service_Type.Name);
            cbServiceType.ValueMember = nameof(Service_Type.IdServiceType);
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
            AddServiceTypeDialog dialog = new AddServiceTypeDialog(_companyLogin);
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



                try
                {
                    Service service = GetService();
                    uow.Services.Insert(service);
                    uow.SaveChanges();
                    ResetForm();
                }
                catch (Exception ex)
                {

                    ErrorMessage(ex);
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
            
        }

        private Service GetService()
        {
            //var company= uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);

            Service service = new Service();
            service.Name = txtName.Text;
            service.Price = int.Parse(txtPrice.Text);
            service.Duration = (int)cbDuration.SelectedItem;
            var serviceType = cbServiceType.SelectedItem as Service_Type;
            service.Service_TypeIdServiceType = serviceType.IdServiceType;
            service.Description = txtDesciption.Text;
            
            return service;
        }

        private void ErrorMessage(Exception ex)
        {
            MessageBox.Show("Greška kod unosa. \n" + ex.Message);
        }

        private bool IsValid()
        {
            HelperMethods helper = new HelperMethods();
            return helper.IsValidForm<ServiceMD>(serviceMDBindingSource) && cbServiceType.Items.Count > 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
