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
    public partial class AddSpecializationDialog : Form
    {

        private UniteOfWork uow;
        public AddSpecializationDialog()
        {
            InitializeComponent();
            InitValidation();
            InitRepository();
            FillWorkers();
        }

        private void FillWorkers()
        {
            cbWorker.DataSource = uow.Workers.GetAll();
            cbWorker.DisplayMember = nameof(Worker.FullName);
            cbWorker.ValueMember = nameof(Worker.IdWorker);
        }

        private void InitValidation()
        {
            specializationMDBindingSource.DataSource = new SpecializationMD();
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
                    Specialization specialization = new Specialization { Name = txtSpecialization.Text };
                    uow.Specializations.Insert(specialization);
                    Worker worker = cbWorker.SelectedItem as Worker;
                    uow.WorkerSpecializations.Insert(new Worker_Specializations { Specialization = specialization, Worker = worker });
                    
                    uow.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Greška." );
                }
                Close();
            }
        }

 

        private bool IsValid()
        {
            //FormValidationHelper<SpecializationMD> fvh = new FormValidationHelper<SpecializationMD>();
            //return fvh.IsValidForm(specializationMDBindingSource) && IsWorkerSelected();

            HelperMethods helper = new HelperMethods();
            return helper.IsValidForm<SpecializationMD>(specializationMDBindingSource) && IsWorkerSelected();
        }

        private bool IsWorkerSelected()
        {
            if (cbWorker.SelectedItem==null)
            {
                MessageBox.Show("Mora biti izabran djelatnik.");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
