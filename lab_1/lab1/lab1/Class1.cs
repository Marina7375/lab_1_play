using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyLib
{
    /// Calculation of mathematical functions
    public class MyClass
    {
        /// <summary>
        /// Sin(x)
        /// </summary>
        /// <param name="x">the angle in radians - the first argument of the Sin function</param>
        /// <param name="n">the exponent - the second argument of the Sin function</param>
        /// <returns>Returns the value of the Sin function for a given angle</returns>
        public static int Sred(int k, int x)
        {
            int result;

            result = (k + x) / 2;

            return result;
        }

        public static double Suma(double n, int x)
        {
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma =suma +(Math.Pow((-1),(i - 1))*Math.Pow(x, (2*i-1)))/ F(2 * i - 1) ;//(Math.Pow((-1), i) * Math.Pow(x, (2 * i + 1))) / F(2 * i + 1);
            }
            return suma;
        }
        static double F(int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
        public static double F_obch(double n, double x)
        {
          
            double result = 0;
          
            for (int i = 0; i < n; i++)
            {
                result = result + (Math.Pow(x, 2 * i)/F(2*i+1));
               
                i++; ;
            }
            return result;
        }
        }

    }

