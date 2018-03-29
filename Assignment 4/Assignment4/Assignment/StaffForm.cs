// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Windows.Forms;

namespace Assignment
{
    /// <summary>
    /// For for entering the qualifications of a staff person.
    /// Similar to RecipeForm.
    /// </summary>
    public partial class StaffForm : Form
    {
        /// <summary>
        /// staff object that the form works on.
        /// </summary>
        private StaffPerson staff;

        /// <summary>
        /// Staff property to be returned to the caller.
        /// </summary>
        public StaffPerson Staff => new StaffPerson(staff);

        /// <summary>
        /// Constructor. Initializes the form with an empty staff
        /// </summary>
        public StaffForm()
        {
            InitializeComponent();
            if (staff == null)
                staff = new StaffPerson();
        }

        #region callbacks

        /// <summary>
        /// Called when a ingredient is selected. Currently does nothing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do nothing
        }

        /// <summary>
        /// Called when OK is clicked. The form will close, but not because of this code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btkOk_Click(object sender, EventArgs e)
        {
            // Do nothing.
        }

        /// <summary>
        /// Called when Add is clicked.
        /// Add a qualification to the person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            staff.Add(txtQualification.Text);
            UpdateGui();
        }

        /// <summary>
        /// Unfinished code, called when a Change is clicked.
        /// Should change the selected qualification.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            var index = lbxQualifications.SelectedIndex;
            var ingredient = txtQualification.Text;
            staff.ChangeAt(ingredient, index);
            UpdateGui();

        }

        /// <summary>
        /// Called when Delete is clicked
        /// Delete the selected qualification.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lbxQualifications.SelectedIndex;
            staff.DeleteAt(index);
            UpdateGui();
        }

        /// <summary>
        /// Called when the Name field is changed.
        /// Updates the name of the staff person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            staff.Name = txtName.Text;
        }
        

        #endregion
        
        /// <summary>
        /// Update the qualification list from the staff object.
        /// </summary>
        private void UpdateGui()
        {
            lbxQualifications.Items.Clear();
            lbxQualifications.Items.AddRange(staff.ToStringArray());
        }
    }
}
