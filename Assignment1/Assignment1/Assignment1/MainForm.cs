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
        AnimalManager _animalManager = new AnimalManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
            InitObjectChoser(AnimalCategory.All);
        }

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
                        break;
            }
            
        }

        private void InitializeGui()
        {
            gbxBird.Location = gbxMammal.Location;
            InitGenderBox();
            InitCategoryBox();
            InitAnimalList();

        }

        private void InitAnimalList()
        {
            lvAnimals.Columns.Clear();
            lvAnimals.Columns.Add("ID1", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("ID2", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Name", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Age", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Gender", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Species", 50, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("Special characteristics", 50, HorizontalAlignment.Center);
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
            throw new NotImplementedException();
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
                case "Bear": break;
                case "Cat": break;
                case "Eagle": break;
                case "Penguine": break;
                default: break;
            }
        }
    }
}
