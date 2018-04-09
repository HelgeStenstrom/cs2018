//Programming using .NET, advanced Course
//Event-delegate example
//Farid Naisan March 2011


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BidHouseWPFCS
{
    /// <summary>
    /// This class contains Shared methods which parse and validate floating point expression conversions.
    /// </summary>
    /// <remarks>
    /// Shared methods are practical to use as  helpfunctions.  The methods can be called without
    /// need for creating objects of the class. 
    /// </remarks>
    /// <author>Farid Naisabn</author>
    public class ToDecimal
    {

        /// <summary>
        /// Converts a string representated Decimal value into a Decimal type, and validates
        /// the converted value to be within (and inclusive) a range, defined by minLimit and 
        /// maxLimit.
        /// </summary>
        /// <param name="stringToConvert">string representing the Decimal value.</param>
        /// <param name="minLimit">The output value should be greather or equal to minLimit.</param>
        /// <param name="maxLimit">The output value should be less than or equal to minLimit</param>
        /// <returns>true if the conversion is sucessful and the converted value is within the
        /// given range.
        /// </returns>
        public static decimal GetDecimal(string stringToConvert, 
                                            decimal minLimit, 
                                            decimal maxLimit, 
                                            out bool convertOK, 
                                            bool checkLimits)
        {

            decimal dblOutValue = 0.0m;

            //Try parse a string encoded Decimal into a Decimal data type.
            convertOK = decimal.TryParse(stringToConvert, out dblOutValue);

            //Return true if the converted Decimal is with in the Limit specified by 
            //the parametrs minLimit and maxLimit.
            if (checkLimits)
            {
                convertOK = (dblOutValue >= minLimit && dblOutValue <= maxLimit);
            }

            return dblOutValue;
        }

        public static decimal GetDecimal(string stringToConvert, 
                                            decimal minLimit, 
                                            decimal maxLimit, 
                                            out bool convertOK)
        {
            return GetDecimal(stringToConvert, minLimit, maxLimit, out convertOK, true);
        }

        public static decimal GetDecimal(string stringToConvert, 
                                            decimal minLimit, 
                                            out bool convertOK)
        {
            return GetDecimal(stringToConvert, minLimit, minLimit + 1, out convertOK);

        }

        public static decimal GetDecimal(string stringToConvert, decimal minLimit)
        {
            bool convertOK = true;
            return GetDecimal(stringToConvert, minLimit, minLimit + 1, out convertOK);

        }

        public static decimal GetDecimal(string stringToConvert)
        {
            bool convertOK = true; //not used
            
            return GetDecimal(stringToConvert, 0, 0, out convertOK, false);
        }


    }


}
