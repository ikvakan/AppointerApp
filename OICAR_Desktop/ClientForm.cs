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
    public partial class ClientForm : Form
    {

        private UniteOfWork uow;
        OpenFormHelper ofh;
        private Panel _pnlContent;
        public ClientForm(Panel pnlContent)
        {
            
            _pnlContent= pnlContent;
            InitializeComponent();
            InitRepository();
            PopulateGrid();
            
        }

        private void SetupDataGrid()
        {
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

        private void PopulateGrid()
        {
            if (uow.Clients.GetAll().Count() == 0)
            {
                dataGridView.Visible = false;
                lblInfo.Visible = true;

            }
            else
            {
                dataGridView.Visible = true;
                bindingSource.DataSource = uow.Clients.GetAll();

            }
            SetupDataGrid();

        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientDialog dialog = new AddClientDialog();
            OpenFormHelper.OpenChildForm(dialog, _pnlContent);
            dialog.FormClosed += Dialog_FormClosed;
            //dialog.Show();
        }

        private void Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Client client = new Client();
            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {


                var id = int.Parse(item.Cells[0].Value.ToString());

                client = uow.Clients.SingleOrDefault(c => c.IdClient == id);

            }

            UpdateClientDialog dialog = new UpdateClientDialog(client);
            OpenFormHelper.OpenChildForm(dialog,_pnlContent);
            dialog.FormClosed += Dialog_FormClosed1;
        }

        private void Dialog_FormClosed1(object sender, FormClosedEventArgs e)
        {

            //PopulateGrid();
            OpenFormHelper.OpenChildForm(new ClientForm(_pnlContent), _pnlContent);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridView.SelectedRows)
            {


                var id = int.Parse(item.Cells[0].Value.ToString());

                Client client = uow.Clients.SingleOrDefault(c => c.IdClient == id);

                List<Appointment> appointments = uow.Apponitments.Find(a => a.ClientIdClient == client.IdClient).ToList();
                if (appointments.Count() > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Klijent ima već zakazane termin, želite li obrisati i sve termine ?", "Potvrda brisanja.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        foreach (var app in appointments)
                        {
                            uow.Apponitments.Delete(app);
                            uow.Clients.Delete(client);

                        }
                        uow.SaveChanges();

                    }
                }

                else if (DialogResult.Yes == MessageBox.Show("Želite li obrisati klijenta ?", "Potvrda brisanja.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {


                    uow.Clients.Delete(client);


                    uow.SaveChanges();

                }


            }


            PopulateGrid();
        }
    }
}
