using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICAR_Desktop.Utility
{


    public class OpenFormHelper
    {

        public static void OpenChildForm(Form childForm, Panel pnlChildForm)
        {
            Form activeForm = null;

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            // pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }



}

