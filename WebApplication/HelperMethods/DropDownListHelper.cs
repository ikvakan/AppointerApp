using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.HelperMethods
{
    public class DropDownListHelper
    {
        
        public static void FillCategoryList()
        {
            IEnumerable<SelectListItem> categoryList = new List<SelectListItem>
            {
                new SelectListItem{Text="Salon ljepote",Value="Salon ljepote"},
                new SelectListItem{Text="Salon ljepote",Value="Salon ljepote"},
            };
        }

    }
}