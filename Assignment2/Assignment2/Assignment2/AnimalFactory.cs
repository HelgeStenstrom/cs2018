﻿// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    internal static class AnimalFactory
    {
        private static void Fixstuff(Control c)
        {
            c.Location = new Point(0,0);
            c.AutoSize = true;
        }
        
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


            // TODO: validate species as a class name, and switch on it.
            return panel;
        }

        public static Animal MakeAnimal(string species)
        {
            throw new NotImplementedException();

        }

        public static Animal MakeAnimal(string name, int age, Gender gender, string categoryProperty, string speciesProperty, string species, string Id)
        {
            int toothcount, numberEaten;
            double wingspan, speed;
            Animal animal = null; 
           

            switch (species)
            {
                case "Bear":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            animal = new Bear(Id, name, gender, age, toothcount, numberEaten);
                    }
                    break;
                case "Cat":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            animal = new Cat(Id, name, gender, age, toothcount, numberEaten);
                    }
                    break;
                case "Eagle":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            animal = new Eagle(Id, name, gender, age, wingspan, speed);
                    }
                    break;
                case "Penguin":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            animal = new Penguin(Id, name, gender, age, wingspan, speed);
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }

            // assert (animal != null);
            return animal;
        }


    }
}
