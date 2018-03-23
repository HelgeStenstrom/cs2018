using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{
    /// <summary>
    /// A recipe behaves as a list of ingredients. 
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// Constructor, initialies an empty ingredient list.
        /// </summary>
        public Recipe()
        {
            _ingredients = new ListManager<string>();
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Recipe(Recipe other)
        {
            this.Name = other.Name;
            this._ingredients = other._ingredients;
        }

        /// <summary>
        /// Name of this recipe
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Return the ingredients of this recipe
        /// </summary>
        public ListManager<string> Ingredients => _ingredients;

        /// <summary>
        /// The ingredients of this recipe
        /// </summary>
        private ListManager<string> _ingredients;
        
        /// <summary>
        /// Returns a string representatio of this recipe.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + ": " + string.Join(", ", _ingredients) + ".";
        }

        /// <summary>
        /// Add an ingredient
        /// </summary>
        /// <param name="item">ingredient to be added</param>
        public void Add(string item)
        {
            _ingredients.Add(item);
        }

        /// <summary>
        /// Delete an ingredient
        /// </summary>
        /// <param name="index">index of ingredient to be deleted</param>
        public void DeleteAt(int index)
        {
            _ingredients.DeleteAt(index);
        }

        /// <summary>
        /// Return all ingredients as an array of strings.
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            return _ingredients.ToStringArray();
        }
    }
}