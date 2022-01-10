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
    public partial class MainForm : Form
    {
        
        private CompanyLogin _companyLogin;
        private readonly UniteOfWork uow;
       
        public MainForm(CompanyLogin companyLogin)
        {
            InitializeComponent();
            uow = new UniteOfWork(new ModelContainer());
            _companyLogin = companyLogin;
            SetWelcomeMessage();
            
        }

        private void SetWelcomeMessage()
        {
            
            lblWelcomeUser.Text =$"Dobrodošli {_companyLogin.UserName} ! ";
        }

        private void btnTermini_Click(object sender, EventArgs e)
        {
            HideWelcomePanel();
            OpenFormHelper.OpenChildForm(new AppointmentForm(pnlChildForm,_companyLogin),pnlChildForm);
        }

    
        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            HideWelcomePanel();

            OpenFormHelper.OpenChildForm(new ClientForm(pnlChildForm,_companyLogin),pnlChildForm);
        }


        private void btnPocetna_Click(object sender, EventArgs e)
        {
            HideWelcomePanel();

            OpenFormHelper.OpenChildForm(new StartForm(pnlChildForm,_companyLogin),pnlChildForm);
           
        }
        private void btnPostavke_Click(object sender, EventArgs e)
        {
            HideWelcomePanel();

            OpenFormHelper.OpenChildForm(new SetupForm(pnlChildForm,_companyLogin),pnlChildForm);
        }


        private void HideWelcomePanel()
        {
            pnlWelcome.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
