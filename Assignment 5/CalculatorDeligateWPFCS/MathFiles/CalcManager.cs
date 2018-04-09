using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaclulatorDelegateCS.MathLib
{
    public delegate double CalculateHandler(double value1, double value2);

    public class CalcManager
    {
  
        /// <summary>
        /// Method that performs the required calculation by delegating the job to the 
        /// delegate CalculateHandler
        /// </summary>
        /// 
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public double DoCalculate(double value1, double value2, CalcOperators.Operators operation)
        {
            //what happens 
            //CalculateHandler calcDelegate;
            //calcDelegate = new CalculateHandler ( Calculator.Add );
            //calcDelegate += Calculator.Subtract;
            //calcDelegate += Calculator.Divide;
            //calcDelegate += Calculator.Multiply;
            //calcDelegate += Calculator.Power;

            //which function? don't know until runtime
            // declared but not created
           CalculateHandler calcDelegate = GetMethod ( operation );
            return calcDelegate(value1, value2);
        }

        //return a delegate
        public CalculateHandler GetMethod(CalcOperators.Operators operation)
        {
            CalculateHandler calcMethod = null;

            switch (operation)
            {
                case CalcOperators.Operators.Add:
                    calcMethod = Calculator.Add;
                    break;

                case CalcOperators.Operators.Substract:
                    calcMethod = Calculator.Subtract;
                    break;

                case CalcOperators.Operators.Multiply:
                    calcMethod = Calculator.Multiply;
                    break;

                case CalcOperators.Operators.Divide:
                    calcMethod = Calculator.Divide;
                    break;

                case CalcOperators.Operators.Power:
                    calcMethod = Calculator.Power;
                    break;
            }
   
            return calcMethod;
        }
        public double PerformCalc(CalculateHandler method,double value1, double value2)
        {
            return method ( value1, value2 );

        }

    }
}
