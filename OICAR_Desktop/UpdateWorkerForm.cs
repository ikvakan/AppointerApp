
using ClassLibrary.DAL;
using ClassLibrary.Model;
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
    public partial class UpdateWorkerForm : Form
    {

        private UniteOfWork uow;

        private Worker _worker;
        private CompanyLogin _companyLogin;
        public UpdateWorkerForm(Worker worker,CompanyLogin companyLogin)
        {
            _worker = worker;
            _companyLogin = companyLogin;
            InitializeComponent();
            InitRepository();
            SetWorker();
        }

        private void SetWorker()
        {
            txtName.Text = _worker.Name;
            txtSurname.Text = _worker.Surname;
            txtEmail.Text = _worker.Email;
            txtContact.Text = _worker.Contact;
        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Worker worke = GetWorker();

            uow.Workers.Update(worke);

            try
            {
                uow.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greška kod ažuriranja.");
            }

        }

        private Worker GetWorker()
        {
            var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);

            Worker worker = new Worker();
            worker.IdWorker = _worker.IdWorker;
            worker.Name = txtName.Text;
            worker.Surname = txtSurname.Text;
            worker.Email = txtEmail.Text;
            worker.Contact = txtContact.Text;
            worker.CompanyIdCompany = company.IdCompany;

            return worker;
        }

       
    }
}
