using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{
    public class Recipe
    {
        public Recipe()
        {
            _ingredients = new ListManager<string>();
        }

        public Recipe(Recipe other)
        {
            this.Name = other.Name;
            this._ingredients = other._ingredients;
        }

        public string Name { get; set; }

        public ListManager<string> Ingredients => _ingredients;

        private ListManager<string> _ingredients;
        
        public override string ToString()
        {
            return Name + ": " + string.Join(", ", _ingredients) + ".";
        }

        public void Add(string item)
        {
            _ingredients.Add(item);
        }

        public void DeleteAt(int index)
        {
            _ingredients.DeleteAt(index);
        }

        public string[] ToStringArray()
        {
            return _ingredients.ToStringArray();
        }
    }
}