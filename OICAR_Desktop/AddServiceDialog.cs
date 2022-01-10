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
    public partial class AddServiceDialog : Form
    {
        private ModelContainer db;
        private UniteOfWork uow;
        private OpenFormHelper openForm;

        public AddServiceDialog()
        {
            InitializeComponent();
            InitRepository();
            InitValidationDataSource();
            FillDuration();
            FillServiceType();
            FillSpecialization();
           
        }

        private void FillSpecialization()
        {
            cbSpecialization.DataSource = uow.Specializations.GetAll();
            cbSpecialization.DisplayMember = nameof(Specialization.Name);
            cbSpecialization.ValueMember = nameof(Specialization.IdSpecialization);
        }

        private void FillServiceType()
        {
            cbServiceType.DataSource = uow.ServiceTypes.GetAll();
            cbServiceType.DisplayMember = nameof(Service_Type.Name);
            cbServiceType.ValueMember = nameof(Service_Type.IdServiceType);
        }

        private void InitRepository()
        {
           
            db = new ModelContainer();
            uow = new UniteOfWork(db);
        }

        private void FillDuration()
        {

            cbDuration.DataSource = HelperMethods.FillDuration();
        }

        private void InitValidationDataSource()

        {
            serviceMDBindingSource.DataSource = new ServiceMD();
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
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Greška kod unosa usluge.");
                }
                Close();
            }
        }

        private Service GetService()
        {
            Service service = new Service();
            service.Name = txtName.Text;
            service.Price = int.Parse(txtPrice.Text);
            service.Duration = (int)cbDuration.SelectedItem;
            service.Service_Type = cbServiceType.SelectedItem as Service_Type;
            service.Specialization = cbSpecialization.SelectedItem as Specialization;
            service.Description = txtDesciption.Text;

            return service;
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            AddServiceTypeDialog dialog = new AddServiceTypeDialog();
            dialog.Show();
            dialog.FormClosing += Dialog_FormClosing1;
        }

        private void Dialog_FormClosing1(object sender, FormClosingEventArgs e)
        {
            FillServiceType();
        }

        private bool IsValid()
        {
            //FormValidationHelper<ServiceMD> fvh = new FormValidationHelper<ServiceMD>();
            HelperMethods helper = new HelperMethods();
            return helper.IsValidForm<ServiceMD>(serviceMDBindingSource);
            
        }

        private void btnAddSpecialization_Click(object sender, EventArgs e)
        {
            AddSpecializationDialog dialog = new AddSpecializationDialog();
            dialog.Show();
            dialog.FormClosing += Dialog_FormClosing;
            
            
        }

        private void Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillSpecialization();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
