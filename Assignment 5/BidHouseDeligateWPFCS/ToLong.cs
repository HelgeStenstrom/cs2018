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
    /// This class contains Shared methods which parse and validate whole number conversions.
    /// </summary>
    /// <remarks>
    /// Shared methods are practical to use as  helpfunctions.  The methods can be called without
    /// need for creating objects of the class. 
    /// </remarks>
    /// <author>Farid Naisabn</author>
    /// 
    public class ToLong
    {
        /// <summary>
        /// Converts a string representated Long value into a Long type, and validates
        /// the converted value to be within (and inclusive) a range, defined by minLimit and 
        /// maxLimit.
        /// </summary>
        /// <param name="stringToConvert">string representing the Long value.</param>
        /// <param name="minLimit">The output value should be greather or equal to minLimit.</param>
        /// <param name="maxLimit">The output value should be less than or equal to minLimit</param>
        /// <returns>true if the conversion is sucessful and the converted value is within the
        /// given range.
        /// </returns>
        public static long GetLong(string stringToConvert, 
                                    long minLimit, 
                                    long maxLimit, 
                                    out bool convertOK, 
                                    bool checkLimits)
        {

            long lOutValue = 0;

            //Try parse a string encoded Long into a Long data type.
            convertOK = long.TryParse(stringToConvert, out lOutValue);

            //Return true if the converted Long is with in the Limit specified by 
            //the parametrs minLimit and maxLimit.
            if (checkLimits)
            {
                convertOK = (lOutValue >= minLimit && lOutValue <= maxLimit);
            }

            return lOutValue;
        }

        public static long GetLong(string stringToConvert, long minLimit, long maxLimit, out bool convertOK)
        {
            return GetLong(stringToConvert, minLimit, maxLimit, out convertOK, true);
        }

        public static long GetLong(string stringToConvert, long minLimit, out bool convertOK)
        {
            return GetLong(stringToConvert, minLimit, minLimit + 1, out convertOK);

        }

        public static long GetLong(string stringToConvert, long minLimit)
        {
            bool convertOK = true;
            return GetLong(stringToConvert, minLimit, minLimit + 1, out convertOK);

        }

        public static long GetLong(string stringToConvert)
        {
            bool convertOK = true;
            // not used
            return GetLong(stringToConvert, 0, 0, out convertOK, false);
        }

        public static int GetInteger32(string stringToConvert, int minLimit)
        {
            return Convert.ToInt32(GetLong(stringToConvert, minLimit));
        }
    }

}
