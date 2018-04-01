// Helge Stenström 
// ah7875
// C# del II 2018

using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// This interface is an attempt to simplify the transition to a dictionary based class,
    /// but that never happened, so the interface doesn't provide anything useful
    /// It requires that the FoodSchedule implements the IEnumerable interface.
    /// </summary>
    public interface IFoodSchedule : IEnumerable<string>
    {
    }
}
