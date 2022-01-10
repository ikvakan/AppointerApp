using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICAR_Desktop.Utility
{
   public class HelperMethods
    {

        public static List<int> FillDuration()
        {
            List<int> interval = new List<int>();

            for (int i = 15; i <= 120; i += 15)
            {
                interval.Add(i);
            }

            return interval;
        }

        public bool IsValidForm<TEntity>(BindingSource bindingSource) where TEntity : class
        {
            bindingSource.EndEdit();

            TEntity entity = bindingSource.Current as TEntity;

            if (entity != null)
            {
                ValidationContext context = new ValidationContext(entity, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(entity, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Poruka.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;

                    }
                }
            }

            return true;
        }

        public static void ShowControl(Control control,Panel pnl)
        {
            pnl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            pnl.Controls.Add(control);
        }


        public static DialogResult DialogHelper(string message,string title,MessageBoxButtons messageBoxButtons)
        {

            MessageBoxButtons buttons = messageBoxButtons;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
        }
      
    }
}
