// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace Assignment
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

        }
        #endregion

        #region Fields

        /// <summary>
        /// The list of animals.
        /// </summary>
        private readonly AnimalManager _animalManager = new AnimalManager();

        /// <summary>
        /// Collection of recipes.
        /// </summary>
        private readonly RecipeManager _recipeManager = new RecipeManager();
        
        /// <summary>
        /// Collection of personell
        /// </summary>
        private readonly ListManager<string> _staff = new ListManager<string>();

        private bool _animalManagerChanged = false;
        // TODO: Se till att den sätts till true på rätt sätt
        // true när data ändras
        // false när det sparas.

        private string _fileName;

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
            ControlButtons();
        }

        #endregion

        #region Callbacks

        /// <summary>
        /// Add some food. Called when Add Food is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            RecipeForm recipeForm = new RecipeForm();
            DialogResult dialogResult = recipeForm.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            _recipeManager.Add(recipeForm.Recipe);
            UpdateDetails(_recipeManager);
        }


        /// <summary>
        /// Add some personell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            var staffForm = new StaffForm();
            DialogResult dialogResult = staffForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string description = staffForm.Staff.ToString();
                _staff.Add(description);
                UpdateDetails(_staff);
            }
        }

        /// <summary>
        /// Populate the animal list with some pre-prepared animals.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            var someAnimals = AnimalHelper.makeSomeAnimals();
            foreach (var animal in someAnimals)
                _animalManager.Add(animal);
            UpdateTable();
        }


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
                _animalManager.Add(AnimalHelper.MakeAnimal(name, age, gender, categoryProperty, speciesProperty, species));                
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
            switch(lvAnimals.Columns[e.Column].Text)
            {
                case "ID":
                    _animalManager.Sort(new CompareById());
                    break;
                case "Name":
                    _animalManager.Sort(new CompareByName());
                    break;
                case "Age":
                    _animalManager.Sort(new CompareByAge());
                    break;
                default: break;
            }
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
            if (ControlButtons()) // There will never be more than one row selected.
            {
                var index = indices[0];
                IAnimal animal = _animalManager.GetAt(index);
                txtEaterType.Text = animal.GetEaterType().ToString();

                lbxFoodSchedule.Items.Clear();
                IEnumerable<string> foods = animal.GetFoodSchedule();
                foreach (var food in foods)
                { 
                    lbxFoodSchedule.Items.Add(food);
                }
            }
            
        }
        
        
        /// <summary>
        ///  Called when Change is clicked. Do nothing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            // Do nothing, it's optional.
        }

        /// <summary>
        /// Delete the selected animal from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lvAnimals.SelectedIndices[0];
            _animalManager.DeleteAt(index);
            UpdateTable();
            ControlButtons();
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

        private void MnuFileExit_Click(object sender, EventArgs e)
        {

        }

        private void MnuFileXmlImport_Click(object sender, EventArgs e)
        {

        }

        private void MnuFileXmlExport_Click(object sender, EventArgs e)
        {

        }
        
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            bool animalManagerChanged = true;
            if (animalManagerChanged)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Current animal list will be lost, OK or Cancel?", 
                    "Confirmation", buttons);

                if (result == DialogResult.OK)
                {
                    _animalManager.Clear();
                    UpdateTable();
                }
            }
        }

        private void MnuFileOpen_Click(object sender, EventArgs e)
        {
            // Code from assignment
            AskUserIfSaveDataToFile(sender, e); // Save current data?
            // Show open dialog box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFileDialog1.FileName;
                string msg = ReadFile();

                if (msg != string.Empty)
                    MessageBox.Show(msg);
                else
                    UpdateTable();
            }
        }

        private void AskUserIfSaveDataToFile(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            // Code from assignment
            if (String.IsNullOrEmpty(_fileName))
            {
                MnuFileSaveAs_Click(sender, e);
            }
            else
                SaveToFile();
        }

        private void MnuFileSaveAs_Click(object sender, EventArgs e)
        {
            // Show save dialog box
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileName = saveFileDialog1.FileName;
                SaveToFile();
            }
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

        #region Sorter classes (helpers)

        /// <summary>
        /// Compare animals by age.
        /// </summary>
        private class CompareByAge : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (a1.Age.CompareTo(a2.Age));
            }
        }

        /// <summary>
        /// Compare animals by ID
        /// </summary>
        private class CompareById : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (string.CompareOrdinal(a1.Id, a2.Id));
            }
        }

        /// <summary>
        /// Compare animals by name.
        /// </summary>
        private class CompareByName : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (string.CompareOrdinal(a1.Name, a2.Name));
            }
        }

        #endregion

        /// <summary>
        /// Enable or disable Delete and Change buttons, depending on some data.
        /// </summary>
        /// <returns>true if the buttons are enabled.</returns>
        private bool ControlButtons()
        {
            bool enabled = (1 == lvAnimals.SelectedIndices.Count);
            
            if (enabled)
            {
                btnDelete.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnChange.Enabled = false;
            }

            return enabled;
        }

        /// <summary>
        /// Partial GUI update: list of food or staff.
        /// Called when the food list is updated.
        /// </summary>
        /// <param name="listManager"></param>
        /// <typeparam name="T"></typeparam>
        private void  UpdateDetails<T>(ListManager<T> listManager)
        {
            lbxFoodStaff.Items.Clear();
            lbxFoodStaff.Items.AddRange(listManager.ToStringArray());
        }        
        
        
        private string ReadFile()
        {
            // TODO: try catch finaly

            _animalManager.BinaryDeserialize(_fileName);
            return "";
        }

        private void SaveToFile()
        {
            this.Text = "Apu Animal Motel: " + _fileName;
            //throw new NotImplementedException();
            _animalManager.BinarySerialize(_fileName);
        }


    }
}