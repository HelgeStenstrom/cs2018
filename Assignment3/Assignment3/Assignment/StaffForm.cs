using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class StaffForm : Form
    {
        private Staff staff;

        public Staff Staff => staff;


        public StaffForm()
        {
            InitializeComponent();
            if (staff == null)
                staff = new Staff();
        }

        private void lbxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btkOk_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            staff.Add(txtIngredient.Text);
           UpdateGui();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var index = lbxIngredients.SelectedIndex;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lbxIngredients.SelectedIndex;
            staff.DeleteAt(index);
            UpdateGui();
        }

        private void UpdateGui()
        {
            lbxIngredients.Items.Clear();
            lbxIngredients.Items.AddRange(staff.ToStringArray());
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            staff.Name = txtName.Text;
        }
    }
}
