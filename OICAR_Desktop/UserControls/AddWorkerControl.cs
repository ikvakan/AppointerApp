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
    public partial class AddWorkerControl : UserControl
    {

        public Panel pnlContent { get; set; }

        public Worker Worker{ get; set; }
        public AddWorkerControl()
        {
            pnlContent = new Panel();
            InitializeComponent();
        }

      
    }
}
