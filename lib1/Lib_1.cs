using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lib1
{
    public class Lib_1
    {
        public static void CalculateMyTask(DataGridView dgw, out int summ)
        {
            summ = 0;
            for (int i = 0; i < dgw.ColumnCount; i++)
            {
                if ((int)dgw[i, 0].Value > 5)
                {
                    summ += (int)dgw[i, 0].Value;
                }
            }
        }
    }
}
