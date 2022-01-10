
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
    public partial class WorkerForm : Form
    {

        private Panel _pnlContent;
        private UniteOfWork uow;
        private CompanyLogin _companyLogin;
        public WorkerForm(Panel pnlContent, CompanyLogin companyLogin)
        {
            _pnlContent = pnlContent;
            _companyLogin = companyLogin;
            InitializeComponent();
            InitiRepository();
            PopulateGrid();

        }



        private void InitiRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }




        private void PopulateGrid()
        {
            var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);
            var workers = uow.Workers.GetWorkersForCompany(company.IdCompany);

            if (workers.Count() == 0)
            {
                DisableGrid();
            }
            else
            {
                EnableGrid();

                DataTable dt = new DataTable();

                dt.Columns.Add("IdWorker");
                dt.Columns.Add("Djelatnik");
                dt.Columns.Add("Email");
                dt.Columns.Add("Kontakt");



                foreach (var item in workers)
                {

                    DataRow dr = dt.NewRow();

                    dr["IdWorker"] = item.IdWorker;
                    dr["Djelatnik"] = item.FullName;
                    dr["Email"] = item.Email;
                    dr["Kontakt"] = item.Contact;


                    dt.Rows.Add(dr);

                }

                dataGridView.DataSource = dt;
                dataGridView.Columns[0].Visible = false;
                SetupDataGrid();


            }

        }

        private void SetupDataGrid()
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = SystemColors.Control;


            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void EnableGrid()
        {
            dataGridView.Visible = true;
            lblInfo.Visible = false;
        }

        private void DisableGrid()
        {
            dataGridView.Visible = false;
            lblInfo.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var company = uow.Company.GetCompanyForUser(_companyLogin.IdCompanyLogin);

            AddWorkerForm form = new AddWorkerForm(company);
            OpenFormHelper.OpenChildForm(form, _pnlContent);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {
                var id = int.Parse(item.Cells[0].Value.ToString());

                var worker = uow.Workers.GetById(id);
                UpdateWorkerForm form = new UpdateWorkerForm(worker, _companyLogin);
                form.FormClosed += Form_FormClosed;
                OpenFormHelper.OpenChildForm(form, _pnlContent);
            }

        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenFormHelper.OpenChildForm(new WorkerForm(_pnlContent, _companyLogin), _pnlContent);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {


                var id = int.Parse(item.Cells[0].Value.ToString());

                var worker = uow.Workers.GetById(id);



                DialogResult deleteWorkerResult = HelperMethods.DialogHelper("Želite li obrisati djelatnika ?", "Potvrda brisanja.", MessageBoxButtons.YesNo);

                if (deleteWorkerResult == DialogResult.Yes)
                {
                    try
                    {

                        uow.Workers.Delete(worker);

                        uow.SaveChanges();
                        PopulateGrid();

                    }
                    catch (EntitySqlException ex)
                    {

                        MessageBox.Show("Greška kod brisanja.\n" + ex.Message);
                    }
                }

                //    List<Appointment> appointments = uow.Apponitments.Find(a => a.WorkerIdWorker == worker.IdWorker).ToList();
                //    if (appointments.Count() > 0)
                //    {
                //        if (DialogResult.Yes == MessageBox.Show("Djelatnik ima već zakazane termin, želite li obrisati i sve termine ?", "Potvrda brisanja.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                //        {
                //            foreach (var app in appointments)
                //            {
                //                uow.Apponitments.Delete(app);

                //            }
                //            uow.Workers.Delete(worker);


                //        }
                //    }

                //    else if (DialogResult.Yes == MessageBox.Show("Želite li obrisati djelatnika ?", "Potvrda brisanja.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                //    {
                //        uow.Workers.Delete(worker);

                //    }


                //}




            }
        }


    }

}
