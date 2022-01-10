using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OICAR_Desktop.Utility
{
   public class FormValidationHelper<TEntity> where TEntity : class
    {
        public bool IsValidForm(BindingSource bindingSource)
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
    }
}
