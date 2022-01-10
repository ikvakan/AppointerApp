using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICAR_Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.UserConfirmed)
            {

                Application.Run(new MainForm(loginForm.CompanyLogin));
            }
            
            
        }
    }
}
