// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Windows.Forms;

namespace Assignment
{
    /// <summary>
    /// Form for entering a recipe
    /// </summary>
    public partial class RecipeForm : Form
    {
        /// <summary>
        /// The recipe that the form will create
        /// </summary>
        private Recipe _recipe = new Recipe();

        
        /// <summary>
        /// Recipe to be returned when the form is done
        /// </summary>
        public Recipe Recipe => new Recipe(_recipe);

        /// <summary>
        /// Constructor
        /// </summary>
        public RecipeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when an ingredient is clicked in the list.
        /// Currently does nothing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do nothing
        }

        /// <summary>
        /// Called when OK is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btkOk_Click(object sender, EventArgs e)
        {
            // The form will return, due to properties on the connected button.
        }

        /// <summary>
        /// Called when Add is clicked. Add the entered ingredient to the recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _recipe.Add(txtIngredient.Text);
           UpdateGui();
        }

        /// <summary>
        /// Called when Change is clicked. Allows the user to replace an ingredient with another ingredient.
        /// Not implemented yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            var index = lbxIngredients.SelectedIndex;
            // Does nothing more. Implementation missing.
            
        }

        /// <summary>
        /// Called when Delete is clicked. Deletes the selected ingredient from the recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lbxIngredients.SelectedIndex;
            _recipe.DeleteAt(index);
            UpdateGui();
        }

        /// <summary>
        /// Updates the ingedient list with the contents of the recipe.
        /// </summary>
        private void UpdateGui()
        {
            lbxIngredients.Items.Clear();
            lbxIngredients.Items.AddRange(_recipe.ToStringArray());
        }

        /// <summary>
        /// Updates the name of the recipe. Called when the text box is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _recipe.Name = txtName.Text;
        }
    }
}
