using ClassLibrary.DAL;
using ClassLibrary.Model;

using OICAR_Desktop.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICAR_Desktop
{
    public partial class AddClientDialog : Form
    {

       
        private ModelContainer db;
        private UniteOfWork uow;
        

        public AddClientDialog()
        {
            
            InitializeComponent();
            InitRepository();
            InitValidationDataSource();

        }

        private void InitValidationDataSource()
        {
            bindingSourceClientMD.DataSource = new ClientMD();
        }

        private void InitRepository()
        {
          
            db = new ModelContainer();
            uow = new UniteOfWork(db);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                try
                {
                    Client client = GetClient();
                    uow.Clients.Insert(client);
                    client.ClientLogins = new ClientLogin
                    {
                        UserName = "korisnik",
                        Password = "123"
                    };
                    
                    

                    uow.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Pogreška kod dodavanja novog klijenta." + ex.Message);
                }
                ResetForm();

                Close();
            }
        }

        private void ResetForm()
        {
            List<TextBox> fields = new List<TextBox> { txtName, txtSurname, txtAdress, txtContact, txtEmail, txtOib, txtCity };
            fields.ForEach(f => f.Text = "");

        }

        private Client GetClient()
        {
            Client client = new Client();
            client.Name = txtName.Text;
            client.Surname = txtSurname.Text;
            client.Email = txtEmail.Text;
            client.Contact = txtContact.Text;
            client.OIB = txtOib.Text;
            client.Adress = txtAdress.Text;
            client.City = txtCity.Text;


            return client;
        }

        private bool IsValid()
        {
            
            HelperMethods helper = new HelperMethods();
            return helper.IsValidForm<ClientMD>(bindingSourceClientMD);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
