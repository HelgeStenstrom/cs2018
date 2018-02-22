using System;
using System.Collections.Generic;

namespace AnimalDemo
{
    static class DemoProgram
    {
        [STAThread]
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            
            Dog lassie = new Dog();
            
            animals.Add(lassie);
            lassie.Bark();
            
            Animal båtsman = new Dog();
            animals.Add(båtsman);
            båtsman.ToothCount = 32;
            lassie.ToothCount = 23;

            ((Dog) båtsman).Bark();
            
            Cat pelle = new Cat();
            pelle.Purr();
            animals.Add(pelle);

            foreach (var animal in animals)
            {
                animal.ToothCount = 44;
                ((Dog)animal).Bark();
            }

        }
        
        static void Main2()
        {
            List<Animal> animals = new List<Animal>();
            
            Dog lassie = new Dog();
            lassie.Bark();
            
            animals.Add(lassie);
            
            Animal båtsman = new Dog();

            båtsman.ToothCount = 32;

            ((Dog)båtsman).Bark();
        }
    }
}