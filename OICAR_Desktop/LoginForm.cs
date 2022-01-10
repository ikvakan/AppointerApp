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
    public partial class LoginForm : Form
    {
        private readonly UniteOfWork uow;
        public bool UserConfirmed { get; set; }

        public Company Company { get; set; }

        public CompanyLogin CompanyLogin { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            uow = new UniteOfWork(new ModelContainer());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (uow.CompanyLogin.CheckCompanyLoginCredentials(txtUserName.Text, txtPassword.Text))
            {
                var companyLogin = uow.CompanyLogin.GetCompanyLogin(txtUserName.Text, txtPassword.Text);

                DialogResult loginSuccess = HelperMethods.DialogHelper("Korisnik uspješno logiran", "Login", MessageBoxButtons.OK);

                if (loginSuccess==DialogResult.OK)
                {
                    //Company = uow.Company.GetCompanyForUser(companyLogin.IdCompanyLogin);
                    CompanyLogin = companyLogin;
                    UserConfirmed = true;
                    Close();


                }

            }
            else
            {
                DialogResult loginFailed = HelperMethods.DialogHelper("Neuspješan login", "Login fail", MessageBoxButtons.OK);

                if (loginFailed==DialogResult.OK)
                {
                    UserConfirmed = false;
                    ResetLoginForm();
                    return;
                }
            }

        }

        private void ResetLoginForm()
        {
            List<TextBox> fields = new List<TextBox> { txtPassword, txtUserName };

            fields.ForEach(f => f.Text = String.Empty);
        }
    }
}
