
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
    public partial class AppointmentForm : Form
    {
        private UniteOfWork uow;
        private Panel _childForm;
        private CompanyLogin _companyLogin;
        public AppointmentForm(Panel childForm,CompanyLogin companyLogin)
        {
            // ofh = new OpenFormHelper();
            _companyLogin = companyLogin;
            _childForm = childForm;
            InitializeComponent();
            InitRepository();
            FillStatus();

        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void FillStatus()
        {
            cbAppointment.DataSource = uow.Status.GetAll().ToList();
            cbAppointment.DisplayMember = nameof(Status.Name);
            cbAppointment.ValueMember = nameof(Status.IdStatus);
            
        }
        private void AppointmentForm_Load(object sender, EventArgs e)
        {

            lblStatus.Text = "Svi termini";
            PopulateGrid();
            
            

        }


        private void PopulateGrid()
        {
            lblStatus.Text = "Svi termini";

            var appointments = uow.Apponitments.GetAllAppointments().Where(a => a.CompanyIdCompany == _companyLogin.IdCompanyLogin).ToList();

            if (appointments.Count()==0)
            {
                dataGridView.Visible = false;
                lblInfo.Visible = true;
                //DisableButtons();

            }
            else
            {
                
                dataGridView.Visible = true;
                lblInfo.Visible = false;

                DataTable dt = new DataTable();

                dt.Columns.Add("IdTermin");
                dt.Columns.Add("Klijent");
                dt.Columns.Add("Datum");
                dt.Columns.Add("Vrijeme");
                dt.Columns.Add("Trajanje");
                //dt.Columns.Add("Usluga");
                dt.Columns.Add("Firma");
                dt.Columns.Add("Status");


                foreach (var item in appointments)
                {

                    DataRow dr = dt.NewRow();

                    dr["IdTermin"] = item.IdAppointment;
                    dr["Klijent"] = item.Client.FullName;
                    dr["Datum"] = item.Date.ToShortDateString();
                    dr["Vrijeme"] = item.Time.ToShortTimeString();
                    dr["Trajanje"] = item.Duration;
                    //dr["Usluga"] = item.Service.Name;
                    dr["Firma"] = item.Company.Name;
                    dr["Status"] = item.Status.Name;
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

        private void cbAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status status = (Status)cbAppointment.SelectedItem;
            lblStatus.Text = status.Name;
            PopulateGridByStatus(status.Name);
        }
        private void PopulateGridByStatus(string name)
        {

            if (uow.Apponitments.GetAppointmentsByStatusForCompany(name,_companyLogin.IdCompanyLogin).Count() == 0)
            {
                dataGridView.Visible = false;
                lblInfo.Visible = true;
                lblStatus.Text = "";
               
            }
            else
            {
                
                dataGridView.Visible = true;
                lblInfo.Visible = false;
                DataTable dt = new DataTable();

                dt.Columns.Add("IdTermin");
                dt.Columns.Add("Klijent");
                dt.Columns.Add("Datum");
                dt.Columns.Add("Vrijeme");
                dt.Columns.Add("Trajanje");
                dt.Columns.Add("Firma");
                dt.Columns.Add("Status");


                foreach (var item in uow.Apponitments.GetAppointmentsByStatusForCompany(name,_companyLogin.IdCompanyLogin))
                {


                    DataRow dr = dt.NewRow();

                    dr["IdTermin"] = item.IdAppointment;
                    dr["Klijent"] = item.Client.FullName;
                    dr["Datum"] = item.Date.ToShortDateString();
                    dr["Vrijeme"] = item.Time.ToShortTimeString();
                    dr["Trajanje"] = item.Duration;
                    //dr["Usluga"] = item.Service.Name;
                    dr["Firma"] = item.Company.Name;
                    dr["Status"] = item.Status.Name;
                    dt.Rows.Add(dr);

                }



                dataGridView.DataSource = dt;
                dataGridView.Columns[0].Visible = false;
                SetupDataGrid();
            }

        }

        private void EnableButtons()
        {
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
        }
        private void DisableButtons()
        {
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var appointments = uow.Apponitments.GetAllAppointments().Where(a => a.CompanyIdCompany == _companyLogin.IdCompanyLogin).ToList();

            if ( appointments.Count()== 0)
            {
                return;
            }


            Appointment appointment = new Appointment();
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {

                var id = int.Parse(item.Cells[0].Value.ToString());
                appointment = uow.Apponitments.SingleOrDefault(p => p.IdAppointment == id);

            }

            UpdateAppointmentDialog dialog = new UpdateAppointmentDialog(appointment,_companyLogin);
            dialog.Show();
            dialog.FormClosed += Dialog_FormClosed;

        }



        private void Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {

            Close();
            OpenFormHelper.OpenChildForm(new AppointmentForm(_childForm,_companyLogin), _childForm);


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {


                var id = int.Parse(item.Cells[0].Value.ToString());

                Appointment appointment = uow.Apponitments.SingleOrDefault(p => p.IdAppointment == id);

                if (DialogResult.Yes == MessageBox.Show("Želite li obrisati označene podatke ?", "Potvrda brisanja.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    uow.Apponitments.Delete(appointment);
                    uow.SaveChanges();

                }



            }

            PopulateGrid();


        }

       
    }
}

