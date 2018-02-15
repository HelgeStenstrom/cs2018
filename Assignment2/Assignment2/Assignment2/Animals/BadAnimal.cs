using System;

namespace Assignment2
{
    public class BadAnimal : AnimalBase
    {
        [Obsolete("Use zero-argument cunstructor instead.")]
        public BadAnimal(string givenId, string name, Gender gender, int age) : base(givenId, name, gender, age)
        {
        }

        public BadAnimal() : base(string.Empty, string.Empty, Gender.Unknown, 0)
        {
        }

        public override EaterType GetEaterType()
        {
            throw new NotImplementedException();
        }

        public override FoodSchedule GetFoodSchedule()
        {
            throw new NotImplementedException();
        }

        public override string GetSpecies()
        {
            throw new NotImplementedException();
        }
    }
}