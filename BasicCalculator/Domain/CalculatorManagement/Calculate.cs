using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Domain.CalculatorManagement
{
    internal class Calculate
    {
         double inputOne = 0;
         double inputTwo = 0;
         double result;

        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }
        public double CubeRoot(double b)
        {
            return Math.Cbrt(b);
        }
    }
}
