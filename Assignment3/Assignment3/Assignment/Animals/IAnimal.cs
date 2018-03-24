// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment
{
    /// <summary>
    /// Interface for all Animals.
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// The age of the animal
        /// </summary>
        int Age { get; }

        /// <summary>
        /// The gender (or sex) of the animal is returned by this property.
        /// </summary>
        Gender Gender { get; set; }

        /// <summary>
        /// The unique identification of the animal
        /// </summary>
        string Id { get;  }

        /// <summary>
        /// The name of this individual animal (not to be confused with species)
        /// </summary>
        string Name { get; }

        /// <summary>
        /// An array of strings that can describe the animal in a table.
        /// The number of strings and their contents must match the columns of the table.
        /// </summary>
        string[] RowStrings { get; }

        /// <summary>
        /// What the animal eats.
        /// </summary>
        /// <returns>the eater type of the animal</returns>
        EaterType GetEaterType();

        /// <summary>
        /// How the animal is to be fed every day.
        /// </summary>
        /// <returns>The food schedule of the animal</returns>
        IFoodSchedule GetFoodSchedule();

        /// <summary>
        /// The species of the animal, which is the same as its class name.
        /// </summary>
        /// <returns>The species of the animal</returns>
        string GetSpecies();


        /// <summary>
        /// Make a clone of this animal. The clone has the same ID number.
        /// </summary>
        /// <returns>A copy of the original animal, with the same ID number</returns>
        IAnimal Clone();
    }
}