using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.Utility
{
   public static class FillDurationHelper
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

    }
}
