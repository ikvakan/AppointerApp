using OICAR_Desktop.UserControls;
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
    public partial class SetupForm : Form
    {
        private Panel _childForm;
        public SetupForm(Panel childForm)
        {
            _childForm= childForm;
            InitializeComponent();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            CompanyControl ctrl = new CompanyControl();
            HelperMethods.ShowControl(ctrl,pnlContent);
        }

        private void btnWorkingHours_Click(object sender, EventArgs e)
        {

        }

        private void btnService_Click(object sender, EventArgs e)
        {
        

            ServiceForm form = new ServiceForm(pnlContent);
            OpenFormHelper.OpenChildForm(form,pnlContent);
            
            

        }

    

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            //WorkerControl ctrl = new WorkerControl();
            //ctrl.pnlContent = pnlContent;
            //HelperMethods.ShowControl(ctrl, pnlContent);

            WorkerForm form = new WorkerForm(pnlContent);
            OpenFormHelper.OpenChildForm(form, pnlContent);
        }
    }
}
