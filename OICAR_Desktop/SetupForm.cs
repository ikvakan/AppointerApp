
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
    public partial class SetupForm : Form
    {

        private Panel _childForm;
        private UniteOfWork uow;
        private CompanyLogin _companyLogin;

        public SetupForm(Panel childForm,CompanyLogin companyLogin)
        {
            _companyLogin = companyLogin;
            _childForm= childForm;
            
            InitializeComponent();
            InitRepository();
            

        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        public void btnCompany_Click(object sender, EventArgs e)
        { 
            var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);
            CompanyForm form = new CompanyForm(_companyLogin,company,_childForm);
            OpenFormHelper.OpenChildForm(form, pnlContent);
        }

        private void btnWorkingHours_Click(object sender, EventArgs e)
        {
            var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);
            var workingHorus = uow.WorkingHours.GetWorking_HoursForCompany(company.IdCompany).ToList();

            WorkingHoursForm form = new WorkingHoursForm(pnlContent,_childForm,_companyLogin,company,workingHorus);
            OpenFormHelper.OpenChildForm(form, pnlContent);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
        
            ServiceForm form = new ServiceForm(pnlContent,_companyLogin);
            OpenFormHelper.OpenChildForm(form,pnlContent);
            
            
        }

    

        private void btnWorkers_Click(object sender, EventArgs e)
        {
           
            WorkerForm form = new WorkerForm(pnlContent,_companyLogin);
            OpenFormHelper.OpenChildForm(form, pnlContent);
        }
    }
}
