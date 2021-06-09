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
    public partial class StartForm : Form
    {

        private UniteOfWork uow;
        private OpenFormHelper openForm;
        private Panel _panel;
        public StartForm(Panel panel)
        {
            _panel = panel;
            openForm = new OpenFormHelper();
            InitializeComponent();
            InitiRepository();
            InitCalendar();
          
        }

        private void InitCalendar()
        {
            monthCalendar1.SelectionStart = DateTime.Now;
        }

        private void InitiRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnUpisiTermin_Click(object sender, EventArgs e)
        {
            AddAppointmentDialog addAppointmentForm = new AddAppointmentDialog();
            addAppointmentForm.Show();
            addAppointmentForm.FormClosed += AddAppointmentForm_FormClosed;

        }

        private void AddAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            OpenFormHelper.OpenChildForm(new StartForm(_panel), _panel);
        }

      

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var date = e.Start.ToShortDateString();
            
            PopulateGridByDate(DateTime.Parse(date));
            
        }

        private void PopulateGridByDate(DateTime date)
        {
            if (uow.Apponitments.GetAppointmentsByDate(date).Count() == 0)
            {
                dataGridView.Visible = false;
                lblInfo.Visible = true;
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
                dt.Columns.Add("Usluga");
                dt.Columns.Add("Djelatnik");
                dt.Columns.Add("Status");


                foreach (var item in uow.Apponitments.GetAppointmentsByDate(date))
                {


                    DataRow dr = dt.NewRow();

                    dr["IdTermin"] = item.IdAppointment;
                    dr["Klijent"] = item.Client.FullName;
                    dr["Datum"] = item.Date.ToShortDateString();
                    dr["Vrijeme"] = item.Time.ToShortTimeString();
                    dr["Trajanje"] = item.Duration;
                    dr["Usluga"] = item.Service.Name;
                    dr["Djelatnik"] = item.Worker.FullName;
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

    }
}
