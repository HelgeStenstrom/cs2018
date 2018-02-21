// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment2
{
    /// <summary>
    /// Interface for all Animals.
    /// About the name: following advice from Robert C. Martin in Clean Code:
    /// These are sometimes a special case for encodings. For example, say you are building an ABSTRACT FACTORY
    /// for the creation of shapes. This factory will be an interface and will be implemented by a concrete class.
    /// What should you name them? IShapeFactory and ShapeFactory? I prefer to leave interfaces unadorned.
    /// The preceding I, so common in today’s legacy wads, is a distraction at best and too much information
    /// at worst. I don’t want my users knowing that I’m handing them an interface. I just want them to know that
    /// it’s a ShapeFactory. So if I must encode either the interface or the implementation, I choose the
    /// implementation. Calling it ShapeFactoryImp, or even the hideous CShapeFactory, is preferable to
    /// encoding the interface.
    /// </summary>
    public interface Animal
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
        FoodSchedule GetFoodSchedule();

        /// <summary>
        /// The species of the animal, which is the same as its class name.
        /// </summary>
        /// <returns>The species of the animal</returns>
        string GetSpecies();


        /// <summary>
        /// Make a clone of this animal. The clone has the same ID number.
        /// </summary>
        /// <returns>A copy of the original animal, with the same ID number</returns>
        Animal Clone();
    }
}