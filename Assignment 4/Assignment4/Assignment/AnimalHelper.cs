// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// A place to do experiments for future improvements of this program. 
    /// The intention is to try move as much as possible animal-specific stuff 
    /// from MainForm to this class. 
    /// Such as:
    /// * Animal creatation
    /// * Panels or GroupBoxes that are animal-specific
    /// </summary>
    internal static class AnimalHelper
    {
        /// <summary>
        /// Set a few properties of a control to standard values.
        /// </summary>
        /// <param name="control">the control to work on</param>
        private static void Fixstuff(Control control)
        {
            control.Location = new Point(0,0); // Put the control at the local origin
            control.AutoSize = true;           // Make the control require as much area as it needs.
        }
        
        /// <summary>
        /// Experimental panel for animal parameters.
        /// </summary>
        /// <param name="species">the species that the panel should support.</param>
        /// <returns>a panel object for the given species</returns>
        public static Panel AnimalPanel(string species)
        {
            Panel panel = new Panel();
            panel.Size = new Size(0, 0);
            panel.AutoSize = true;
            
            var lblMammal1 = new Label();
            Fixstuff(lblMammal1);
            
            var txtMammal1 = new TextBox();
            Fixstuff(txtMammal1);
            
            var lblSpecies = new Label();
            lblSpecies.Location = new Point(0, 0);
            lblSpecies.Size = new Size(0, 0);
            lblSpecies.AutoSize = true;
            
            var txtSpecies = new TextBox();
            switch (species)
            {
                case "Bear":
                    lblMammal1.Text = @"Ett däggdjur";
                    panel.Controls.Add(lblMammal1);
                    lblSpecies.Text = @"En rackarns stor En björn igen!";
                    panel.Controls.Add(lblSpecies);
                    panel.Controls.Add(txtSpecies);
                    panel.Controls.Add(txtMammal1);
                    break;
                case "Cat":
                    lblSpecies.Text = @"En rackarns stor katt!";
                    panel.Controls.Add(lblSpecies);
                    break;
                default:
                    lblSpecies.Text = @"Det här ska inte synas";
                    panel.Controls.Add(lblSpecies);
                    break;
            }
            lblMammal1.Location = new Point(0,0);
            txtMammal1.Location = new Point(lblMammal1.Right + 5, lblMammal1.Top);
            lblSpecies.Location = new Point(0, lblMammal1.Bottom + 5);
            txtSpecies.Location = new Point(lblSpecies.Right + 5, lblSpecies.Top);

            return panel;
        }

        /// <summary>
        /// Return an animal of the wanted type, so that the MainForm or AnimalManager don't have to.
        /// Most arguments are strings. They need to be pre-validated.
        /// </summary>
        /// <param name="name">the name of this individual animal</param>
        /// <param name="age">the age of this individual animal</param>
        /// <param name="gender">the gender of this animal</param>
        /// <param name="categoryProperty">a property that is relevant for the category of this animal, such as for mammals or for birds.</param>
        /// <param name="speciesProperty">a property that is relevant for the species that this animal belongs to.</param>
        /// <param name="species">the species of the animal to be returned. Used to interpret the property arguments.</param>
        /// <returns>an Animal of the requested kind.</returns>
        public static IAnimal MakeAnimal(string name,
            int age,
            Gender gender,
            string categoryProperty,
            string speciesProperty,
            string species)
        {
            int toothcount, numberEaten;
            double wingspan, speed;
            IAnimal animal = null; 
           

            switch (species)
            {
                case "Bear":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            animal = new Bear(name, gender, age, toothcount, numberEaten);
                    }
                    break;
                case "Gnu":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            animal = new Gnu(name, gender, age, toothcount, numberEaten);
                    }
                    break;
                case "Eagle":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            animal = new Eagle(name, gender, age, wingspan, speed);
                    }
                    break;
                case "Penguin":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            animal = new Penguin(name, gender, age, wingspan, speed);
                    }
                    break;
                default:
                    // If execution arrives here, an unsupported species has been requested.
                    throw new NotImplementedException();
            }

            return animal;
        }
        
        /// <summary>
        /// Create a list of three animals, useful for populating a list with no typing.
        /// </summary>
        /// <returns> a list of three animals</returns>
        public static List<IAnimal> MakeSomeAnimals()
        {
            var some = new List<IAnimal>();
            some.Add(new Bear("Teddy", Gender.Male, 13, 42, 4711));
            some.Add(new Bear("Freddie", Gender.Female, 13, 42, 3141));
            some.Add(new Gnu("Richard M Stallman", Gender.Male, 63, 32, 172));
            return some;
        }
        
    }
}
