using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KasenovAE.Sprint2.TaskReview.V4.Lib
{
    public class DataService
    {
        public bool InGraph(double x, double y)
        {
            if ((y >= 0) && (x*x + y*y <= 1) && ((y > 0) && (x*x + y*y >= 0.3)))
            {
                return true;
            }
            return false;
        }
    }
}
