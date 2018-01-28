using System;
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
        }

        private void InitializeGui()
        {
            InitGenderBox();
            InitCategoryBox();
            //lbCategory.Items.Clear();
            //lbAnimalCategory.Items.Clear();
//            throw new NotImplementedException();
        }

        private void InitCategoryBox()
        {
            cbxCategory.DataSource = Enum.GetValues(typeof(AnimalCategory));
            // TODO: se om raderna nedan kan parametriseras och göras till en funktion.
            lbxCategory.Items.Clear();
            foreach (var item in AnimalManager.MainTypes())
            {
                lbxCategory.Items.Add(item.Name);
            }
        }

        private void InitGenderBox()
        {
            cbxGender.DataSource = Enum.GetValues(typeof(Gender));
            lbxGender.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                lbxGender.Items.Add(item);
            }
        }


        /// <summary>
        /// Fill the ListVIEW for customers, with data from the customer manager
        /// </summary>
        private void UpdateTable()
        {
            listView1.Items.Clear();
            foreach (var customer in _animalManager.AnimalssAsRows)
            {
                // Create a row of the data
                ListViewItem row = new ListViewItem(customer);
                // and add it to the ListView
                listView1.Items.Add(row);
            }
        }


    }
}
