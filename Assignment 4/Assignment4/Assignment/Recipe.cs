﻿// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// A recipe behaves as a list of ingredients. 
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// The ingredients of this recipe
        /// </summary>
        private List<string> _ingredients = new List<string>();

        /// <summary>
        /// Return the ingredients of this recipe
        /// </summary>
        public List<string> Ingredients => _ingredients;

        /// <summary>
        /// Constructor, initialies an empty ingredient list.
        /// </summary>
        public Recipe()
        {
            //_ingredients = new ListManager<string>();
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
        /// Returns a string representatio of this recipe.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return $"{Name}: {string.Join(", ", _ingredients)}.";
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
        /// Replaces an ingredient in the recipe
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeAt(string item, int index)
        {
            try
            {
                _ingredients[index] = item;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            //return _ingredients.ChangeAt(item, index);
        }

        /// <summary>
        /// Delete an ingredient
        /// </summary>
        /// <param name="index">index of ingredient to be deleted</param>
        public void DeleteAt(int index)
        {
            _ingredients.RemoveAt(index);
        }

        /// <summary>
        /// Return all ingredients as an array of strings.
        /// </summary>
        /// <returns>all ingredients as an array of strings</returns>
        public string[] ToStringArray()
        {
            List<string> strings = new List<string>();
            foreach (var item in _ingredients)
            {
                strings.Add(item.ToString());
            }
            return strings.ToArray();
        }
    }
}