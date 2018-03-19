using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RecipeForm : Form
    {
        private Recipe _recipe = new Recipe();

        public Recipe Recipe => new Recipe(_recipe);

        public RecipeForm()
        {
            InitializeComponent();
        }

        private void lbxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btkOk_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _recipe.Add(txtIngredient.Text);
           UpdateGui();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var index = lbxIngredients.SelectedIndex;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lbxIngredients.SelectedIndex;
            _recipe.DeleteAt(index);
            UpdateGui();
        }

        private void UpdateGui()
        {
            lbxIngredients.Items.Clear();
            lbxIngredients.Items.AddRange(_recipe.ToStringArray());
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _recipe.Name = txtName.Text;
        }
    }
}
