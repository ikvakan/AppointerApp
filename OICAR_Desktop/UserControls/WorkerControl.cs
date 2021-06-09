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

namespace OICAR_Desktop.UserControls
{
    public partial class WorkerControl : UserControl
    {

        private UniteOfWork uow;
        public Panel pnlContent { get; set; }
        public WorkerControl()
        {
            pnlContent = new Panel();
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
            if (uow.Workers.GetAll().Count() == 0)
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
                
                

                foreach (var item in uow.Workers.GetAll())
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
            AddWorkerControl control = new AddWorkerControl();
            control.pnlContent = pnlContent;
            HelperMethods.ShowControl(control, pnlContent);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddWorkerControl control = new AddWorkerControl();
            control.pnlContent = pnlContent;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
