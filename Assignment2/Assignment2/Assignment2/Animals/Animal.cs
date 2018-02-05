namespace Assignment2
{
    public interface Animal
    {
        Gender Gender { get; set; }
        string Id { get;  }
        string Name { get; set; }
        EaterType GetEaterType();
        FoodSchedule GetFoodSchedule();
        string GetSpecies();
    }
}