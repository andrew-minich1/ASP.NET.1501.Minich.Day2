using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethodLogicLayer
{
    public static class NewtonMethod
    {
        public static double Radical(double number, int power, double accurancy)
        {
            if (number == 0) return 0;
            double x = 0, result = 1;
            do
            {
                x = result;
                result = ((power - 1) * x + number / Math.Pow(x, power - 1)) / power;

            } while (Math.Abs(x - result) > accurancy);
            return result;
        }
    }
}
