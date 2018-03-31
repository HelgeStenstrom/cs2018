﻿// Helge Stenström 
// ah7875
// C# del II 2018

using System;

namespace Assignment
{
    public class BadAnimal : AnimalBase
    {
        [Obsolete("Use zero-argument cunstructor instead.")]
        public BadAnimal(string givenId, string name, Gender gender, int age) : base(name, gender, age)
        {
        }

        public BadAnimal() : base(string.Empty, Gender.Unknown, 0)
        {
        }


        public override Animal Clone()
        {
            throw new NotImplementedException();
        }

        public override EaterType GetEaterType()
        {
            throw new NotImplementedException();
        }
    }
}
