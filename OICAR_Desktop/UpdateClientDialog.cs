using OICAR_Desktop.DAL;
using OICAR_Desktop.Model;
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
    public partial class UpdateClientDialog : Form
    {
        private UniteOfWork uow;
        private Client _client;
        public UpdateClientDialog(Client client)
        {
            _client = client;
            InitializeComponent();
            InitRepository();
            FillForm();
        }

        private void FillForm()
        {
            txtName.Text = _client.Name;
            txtSurname.Text = _client.Surname;
            txtContact.Text = _client.Contact;
            txtEmail.Text = _client.Email;
            txtCity.Text = _client.City;
            txtAdress.Text = _client.Adress;
            txtOib.Text = _client.OIB;
        }

        private void InitRepository()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = GetClient();
                uow.Clients.Update(client);
                uow.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greška" + ex.Message);
            }
            Close();
        }

        private Client GetClient()
        {
            Client client = new Client();
            client.IdClient = _client.IdClient;
            client.Name = txtName.Text;
            client.Surname = txtSurname.Text;
            client.Contact = txtContact.Text;
            client.Email = txtEmail.Text;
            client.Adress = txtAdress.Text;
            client.City = txtCity.Text;
            client.OIB = txtOib.Text;
            
            return client;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
