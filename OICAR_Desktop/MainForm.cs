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

       
        

        public MainForm()
        {
            InitializeComponent();
            
            
        }

    

     


        private void btnTermini_Click(object sender, EventArgs e)
        {

            OpenFormHelper.OpenChildForm(new AppointmentForm(pnlChildForm),pnlChildForm);
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            OpenFormHelper.OpenChildForm(new ClientForm(pnlChildForm),pnlChildForm);
        }


        private void btnPocetna_Click(object sender, EventArgs e)
        {
            OpenFormHelper.OpenChildForm(new StartForm(pnlChildForm),pnlChildForm);
           
        }
        private void btnPostavke_Click(object sender, EventArgs e)
        {
            OpenFormHelper.OpenChildForm(new SetupForm(pnlChildForm),pnlChildForm);
        }

        
    }
}
