// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// The one and only window of this program.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constructor

        /// <summary>
        /// Constructior, initializes the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitGui();
            InitObjectChoser(AnimalCategory.All);

            //var rb1 = new RadioButton();
            //rb1.Location = new System.Drawing.Point(0, 90);
            //panel1 = new Panel();
            //panel1.Controls.Add(rb1);
            ////animalpanel.
            //var animalPanel = AnimalHelper.AnimalPanel("Bear");
            //animalPanel.Location = new System.Drawing.Point(223, 145); // (257, 16);
            
            //groupBox1.Controls.Add(animalPanel);
            //animalPanel.BringToFront();
        }
        #endregion

        #region Fields

        /// <summary>
        /// The list of animals.
        /// </summary>
        readonly AnimalManager _animalManager = new AnimalManager();
        #endregion

        
        #region Initalization
        
        /// <summary>
        /// Initialize the list of animals, based on which category is selected.
        /// </summary>
        /// <param name="category"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void InitObjectChoser(AnimalCategory category)
        {
            switch (category)
            {
                    case AnimalCategory.Bird:
                        lbxAnimalObject.DataSource = new List<string>(Enum.GetNames(typeof(Birds)));
                        break;
                    case AnimalCategory.Mammal:
                        lbxAnimalObject.DataSource = new List<string>(Enum.GetNames(typeof(Mammals)));
                        break;
                    case AnimalCategory.All:
                        var birds = new List<string>(Enum.GetNames(typeof(Birds)));
                        var mammals = new List<string>(Enum.GetNames(typeof(Mammals)));
                        var choices = new List<string>(birds);
                        choices.AddRange(mammals);
                        lbxAnimalObject.DataSource = choices;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();                       
            }            
        }

        /// <summary>
        /// Define the columns of the listview used for animals
        /// </summary>
        private void InitAnimalList()
        {
            lvAnimals.Columns.Clear();
            lvAnimals.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Name", 100, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Age", 40, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Gender", 70, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Species", 70, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Special characteristics", 250, HorizontalAlignment.Center);
        }

        /// <summary>
        /// Convert a column number into a column name, used to define sorting of a column
        /// </summary>
        /// <param name="sortColumn">the number of the column to be sorted</param>
        /// <returns></returns>
        private string SortName(int sortColumn)
        {
            switch (sortColumn)
            {
                    case 0: 
                        return "ID";
                    case 1: 
                        return "Name";
                    case 2: 
                        return "Age";
                    default:
                        return "no sort";
            }
        }

        /// <summary>
        /// Set up the animal category chooser.
        /// </summary>
        private void InitCategoryBox()
        {
            lbxCategory.Items.Clear();
            lbxCategory.DataSource = new List<string>(Enum.GetNames(typeof(AnimalCategory)));
        }

        /// <summary>
        /// Set up the gender chooser.
        /// </summary>
        private void InitGenderBox()
        {
            lbxGender.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                lbxGender.Items.Add(item);
            }
        }

        /// <summary>
        /// Initialize GUI components that need initalization.
        /// </summary>
        private void InitGui()
        {
            InitGenderBox();
            InitCategoryBox();
            InitAnimalList();
            btnAdd.Enabled = ValidateInputs();
        }

        #endregion

        #region Callbacks

        /// <summary>
        /// Called when an animal category is selected. Calls the animal list setup with the chosen category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find which category was selected
            var index = lbxCategory.SelectedIndex;

            switch ((AnimalCategory) index)
            {
                case AnimalCategory.Bird:
                case AnimalCategory.Mammal:
                case AnimalCategory.All:
                    InitObjectChoser((AnimalCategory) index);
                    break;
                default:
                    throw  new ArgumentOutOfRangeException();
            }
            UpdateButton();
        }

        /// <summary>
        /// Called when the Add button is clicked. Adds an animal, if appropriate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var ageString = txtAge.Text;
            var gender = (Gender)lbxGender.SelectedIndex;
            var categoryProperty = txtCatProperty.Text;
            var speciesProperty = txtSpeciesProperty.Text;
            var species = lbxAnimalObject.SelectedItem.ToString();

            var ageOk = int.TryParse(ageString, out var age);

            var argumentsOk = ageOk;
            if (argumentsOk)
            {
                _animalManager.AddAnimal(AnimalHelper.MakeAnimal(name, age, gender, categoryProperty, speciesProperty, species));                
            }
                

            UpdateTable();
        }

        /// <summary>
        /// Convenience function, used to help me set good column widths. 
        /// Shows the width of the column whose width is currently being adjusted, in a label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnimals_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            var newWidth = e.NewWidth;
            lblBredd.Text = $@"Width of the adjusted column: {newWidth}";
        }

        /// <summary>
        /// Called when an animal is selected in the list of animals. Adjusts labels of input fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxAnimalObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lbxAnimalObject.SelectedItem;

            switch (item)
            {
                case "Bear":
                    lblCatProperty.Text = @"Number of teeth";
                    lblSpeciesProperty.Text = @"Berries eaten";
                    break;
                case "Gnu":
                    lblCatProperty.Text = @"Number of teeth";
                    lblSpeciesProperty.Text = @"Tons of grass eaten";
                    break;
                case "Eagle":
                    lblCatProperty.Text = @"Wing span";
                    lblSpeciesProperty.Text = @"Flight speed";
                    break;
                case "Penguin":
                    lblCatProperty.Text = @"Wing span";
                    lblSpeciesProperty.Text = @"Swim speed";
                    break;
            }
            UpdateButton();
        }

        /// <summary>
        /// Called when a colum (header) is clicked. If the column is sortable, the table is sorted on this column.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnimals_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            _animalManager.SortBy(SortName(e.Column));
            UpdateTable();
        }

        /// <summary>
        /// Called when a row of the table is clicked. Used to fill in the food schedule.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indices = lvAnimals.SelectedIndices;
            if (indices.Count == 1) // There will never be more than one row selected.
            {
                var index = indices[0];
                var animal = _animalManager.GetAnimal(index);
                txtEaterType.Text = animal.GetEaterType().ToString();

                lbxFoodSchedule.Items.Clear();
                var foods = animal.GetFoodSchedule();
                // TODO: hitta sätt att iterera över foodschedule.
                foreach (var food in foods)
                {
                    // TODO: Vad vill jag göra med maten?   
                    lbxFoodSchedule.Items.Add(food);
                }

            }
            // TODO: uppdatera saker med valt djur
        }

        #endregion

        /// <summary>
        /// Fill the ListVIEW for customers, with data from the list manager
        /// </summary>
        private void UpdateTable()
        {
            lvAnimals.Items.Clear();
            foreach (var customer in _animalManager.AnimalssAsRows)
            {
                // Create a row of the data
                var row = new ListViewItem(customer);
                // and add it to the ListView
                lvAnimals.Items.Add(row);
            }
        }

        /// <summary>
        /// Check if the input fields are valid for the creation of an animal.
        /// </summary>
        /// <returns></returns>
        private bool ValidateInputs()
        {
            var hasName = !string.IsNullOrEmpty(txtName.Text);
            var integerAge = int.TryParse(txtAge.Text, out _);
            var catPropOk = false;
            var speciesPropOk = false;

            switch (lbxAnimalObject.SelectedItem.ToString())
            {
                case "Bear":
                case "Gnu":
                    catPropOk = int.TryParse(txtCatProperty.Text, out _);
                    speciesPropOk = int.TryParse(txtSpeciesProperty.Text, out _);
                    break;
                case "Eagle":
                case "Penguin":
                    catPropOk = double.TryParse(txtCatProperty.Text, out _);
                    speciesPropOk = double.TryParse(txtSpeciesProperty.Text, out _);
                    break;
            }

            return hasName && integerAge && catPropOk && speciesPropOk;
        }

        /// <summary>
        /// Activate the Add button if the inputs are valid, disactivate it otherwise.
        /// </summary>
        private void UpdateButton()
        {
            btnAdd.Enabled = ValidateInputs();
        }

        /// <summary>
        /// Called when the name is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        /// <summary>
        /// Called when the age is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        /// <summary>
        /// Called when the gender is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        /// <summary>
        /// Called when the category is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCatProperty_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        /// <summary>
        /// Called when the selected species is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSpeciesProperty_TextChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        #region Validators

        /// <summary>
        /// Called when the age field is to be validated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            ValidateAge(txtAge, e, errorProvider1);
        }

        /// <summary>
        /// Validate age or another string as integer. 
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="e"></param>
        /// <param name="ep"></param>
        private static void ValidateAge(TextBox textBox, CancelEventArgs e, ErrorProvider ep)
        {
            if ((int.TryParse(textBox.Text, out var number)) && (number >= 0)) return;
            e.Cancel = true;
            ep.SetError(textBox, "Det ska vara ett heltal >= 0");
        }

        /// <summary>
        /// Called when the cursor is to leave the input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(txtAge, "");
        }

        /// <summary>
        /// Validate 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCatProperty_Validating(object sender, CancelEventArgs e)
        {
            if ((int.TryParse(txtCatProperty.Text, out var age)) && (age >= 0)) return;
            e.Cancel = true;
            errorProvider1.SetError(txtCatProperty, "Det ska vara ett heltal >= 0");
        }

        /// <summary>
        /// Called when the cursor is to leave the input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCatProperty_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(txtCatProperty, "");
        }

        /// <summary>
        /// Called when the gender field is to be validated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxGender_Validating(object sender, CancelEventArgs e)
        {
            if (lbxGender.SelectedIndex >= 0) return;
            e.Cancel = true;
            errorProvider1.SetError(lbxGender, "Du måste välja något");
        }

        /// <summary>
        /// Called when the cursor is to leave the input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxGender_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(lbxGender, "");
        }

        /// <summary>
        /// Called when the name field is to be validated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text)) return;
            e.Cancel = true;
            errorProvider1.SetError(txtName, "Fyll i ett namn");
        }

        /// <summary>
        /// Called when the cursor is to leave the input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(txtName, "");
        }

        #endregion

    }
}