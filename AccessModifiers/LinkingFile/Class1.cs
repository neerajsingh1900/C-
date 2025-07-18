using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkingFile
{
    public class Class1
    {
        private int tax;
        private int total;

        public void SetTax(int tax=0)
        {
            this.tax = tax;
        }

        public void SetTotal(int tx)
        {
            this.total = 7 * tx;
        }

        public int GetTax()
        {
            return 6*this.tax;
        }
        public int GetTotal()
        {
            return 7*this.total;
        }

        public static int All(Class1 c1, Class1 c2)
        {
            return c1.GetTotal() + c2.GetTotal();
        }

        public void change(ref double percentage)
        {
            percentage = 90.89;
        }

        protected internal static void DoubleChange(out int hell)
        {
            hell = 87;
        }
    }
}
