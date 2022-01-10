
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
    public partial class AddServiceTypeDialog : Form
    {

        private UniteOfWork uow;

        private CompanyLogin _companyLogin;
        public AddServiceTypeDialog(CompanyLogin companyLogin)
        {
            _companyLogin = companyLogin;
            InitializeComponent();
            InitRepository();
            InitValidationDataSource();
        }

        private void InitValidationDataSource()
        {
            service_TypeMDBindingSource.DataSource = new Service_TypeMD();
        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);
                    
                    uow.ServiceTypes.Insert(new Service_Type { Name = txtServiceType.Text ,CompanyIdCompany=company.IdCompany});
                    uow.SaveChanges();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Greška.");
                }
                Close();
            }
        }

        private bool IsValid()
        {
            
            HelperMethods helper = new HelperMethods();
            return helper.IsValidForm<Service_TypeMD>(service_TypeMDBindingSource);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
