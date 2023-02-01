using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Extracredit
    {
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;

            foreach (int i in ListNumbers)
            {
                total += i;
            }

            return total;   
        }
    }
}
