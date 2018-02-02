using System;
using System.Collections.Generic;
using System.Windows.Forms;

// TODO: Man ska kunna lägga till nya djur
// TODO: Man ska kunna ange data för ett djur
// TODO: Man ska kunna ange en kategori för ett djur man vill lägga till

namespace Assignment1
{
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
        AnimalManager _animalManager = new AnimalManager();

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

        private void InitAnimalList()
        {
            lvAnimals.Columns.Clear();
            lvAnimals.Columns.Add("ID1", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("ID2", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Name", 100, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Age", 40, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Gender", 70, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Species", 70, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Special characteristics", 250, HorizontalAlignment.Center);
        }

        private void InitCategoryBox()
        {
            lbxCategory.Items.Clear();
            lbxCategory.DataSource = new List<string>(Enum.GetNames(typeof(AnimalCategory)));
        }

        private void InitGenderBox()
        {
            lbxGender.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                lbxGender.Items.Add(item);
            }
        }

        private void InitGui()
        {
            InitGenderBox();
            InitCategoryBox();
            InitAnimalList();

        }

        #endregion

        #region Callbacks

        private void lbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find which category was selected
            var index = lbxCategory.SelectedIndex;
            var category = lbxCategory.SelectedItem;
            var name = lbxCategory.SelectedItem.ToString();

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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            string ageString = txtAge.Text;
            var gender = (Gender)lbxGender.SelectedIndex;
            string categoryProperty = txtCatProperty.Text;
            string speciesProperty = txtSpeciesProperty.Text;
            string species = lbxAnimalObject.SelectedItem.ToString();

            int age = 17;
            bool ageOK = int.TryParse(ageString, out age);

            bool argumentsOK = ageOK;
            if (argumentsOK)
                _animalManager.AddAnimal(name, age, gender, categoryProperty, speciesProperty, species);

            UpdateTable();
        }


        private void lvAnimals_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            var newWidth = e.NewWidth;
            lblBredd.Text = newWidth.ToString();
        }

        private void lbxAnimalObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lbxAnimalObject.SelectedIndex;
            var item = lbxAnimalObject.SelectedItem;
            var name = lbxAnimalObject.SelectedItem.ToString();

            switch (item)
            {
                case "Bear":
                    lblCatProperty.Text = "Number of teeth";
                    lblSpeciesProperty.Text = "Berries eaten";
                    break;
                case "Cat":
                    lblCatProperty.Text = "Number of teeth";
                    lblSpeciesProperty.Text = "Mice eaten";
                    break;
                case "Eagle":
                    lblCatProperty.Text = "Wing span";
                    lblSpeciesProperty.Text = "Flight speed";
                    break;
                case "Penguin":
                    lblCatProperty.Text = "Wing span";
                    lblSpeciesProperty.Text = "Swim speed";
                    break;
                default: break;
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
                ListViewItem row = new ListViewItem(customer);
                // and add it to the ListView
                lvAnimals.Items.Add(row);
            }
        }
    }
}