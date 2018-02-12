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
            lassie.bark();
            
            Animal båtsman = new Dog();
            animals.Add(båtsman);
            båtsman.toothCount = 32;
            lassie.toothCount = 23;

            ((Dog) båtsman).bark();
            
            Cat pelle = new Cat();
            pelle.purr();
            animals.Add(pelle);

            foreach (var animal in animals)
            {
                animal.toothCount = 44;
                ((Dog)animal).bark();
            }

        }
        
        static void main2()
        {
            List<Animal> animals = new List<Animal>();
            
            Dog Lassie = new Dog();
            Lassie.bark();
            
            animals.Add(Lassie);
            
            Animal Båtsman = new Dog();

            Båtsman.toothCount = 32;

            ((Dog)Båtsman).bark();
        }
    }
}