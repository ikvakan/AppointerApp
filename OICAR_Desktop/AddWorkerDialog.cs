
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
    public partial class AddWorkerDialog : Form
    {
        
        private UniteOfWork uow;
        public AddWorkerDialog()
        {
            InitializeComponent();
            InitValidationDataSource();
            InitRepository();

        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void InitValidationDataSource()
        {
            workerMDBindingSource.DataSource = new WorkerMD();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                try
                {
                    Worker worker = GetWorker();
                    uow.Workers.Insert(worker);
                    uow.SaveChanges();
                   // ResetForm();
                  
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Pogreška kod dodavanja djelatnika.");
                }

                Close();
            }

        }

        private void ResetForm()
        {
            List<TextBox> fields = new List<TextBox> {txtName,txtSurname,txtEmail,txtContact };
            fields.ForEach(f => f.Text = String.Empty);
        }

        private Worker GetWorker()
        {
            Worker worker = new Worker();
            worker.Name = txtName.Text;
            worker.Surname = txtSurname.Text;
            worker.Email = txtEmail.Text;
            worker.Contact = txtContact.Text;
            return worker;
        }

        private bool IsValid()
        {
            //FormValidationHelper<WorkerMD> fvh = new FormValidationHelper<WorkerMD>();
            //return fvh.IsValidForm(workerMDBindingSource);

            HelperMethods helper = new HelperMethods();
            return helper.IsValidForm<WorkerMD>(workerMDBindingSource);
        }

 
    }
}
