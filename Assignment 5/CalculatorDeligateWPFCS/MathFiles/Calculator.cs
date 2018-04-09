using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaclulatorDelegateCS.MathLib
{
    //This class contains methods that will be used with the delegate by
    //a subcriber class (class that will use the delegate).
    public class Calculator
    {
        //Methods to connect to delegate
        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public static double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
        public static double Divide(double value1, double value2)
        {
            return (value2 != 0) ? value1 / value2 : 0.0;
        }

        public static double Power(double value1, double value2)
        {
            return Math.Pow(value1, value2);
        }

    }
}
