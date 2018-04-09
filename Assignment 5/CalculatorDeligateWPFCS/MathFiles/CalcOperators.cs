using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaclulatorDelegateCS.MathLib
{
    //A helper class that handles math  operators
    public class CalcOperators
    {
        public enum Operators
        {
            Add,
            Substract,
            Multiply,
            Divide,
            Power
        }
        private static string[] symbols = {
		"+",
		"-",
		"*",
		"/",
		"x^y"

	};
        public static string GetSymbol(Operators func)
        {
            return symbols[Convert.ToInt32(func)];
        }

        public static string[] GetSymbols()
        {
            //Send a clone copy of symbols
            int size = symbols.Length;
            string[] symbolsOut = new string[size];

            for (int i = 0; i <= size - 1; i++)
            {
                symbolsOut[i] = symbols[i];
            }

            return symbolsOut;
        }
    }
}
