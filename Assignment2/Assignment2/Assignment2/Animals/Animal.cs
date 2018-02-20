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
        Gender Gender { get; set; }
        string Id { get;  }
        string Name { get; set; }
        EaterType GetEaterType();
        FoodSchedule GetFoodSchedule();
        string GetSpecies();
        string[] RowStrings { get; }
        Animal Clone();
        int Age { get; }
    }
}