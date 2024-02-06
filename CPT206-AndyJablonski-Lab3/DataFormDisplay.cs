using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Statelab3ClassLibrary;

namespace CPT206_AndyJablonski_Lab3
{
    public partial class DataFormDisplay : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public DataFormDisplay(string statename)
        {
            InitializeComponent();


            var results = from state in db.States
                          orderby state.STATE_NAME
                          where state.STATE_NAME == statename
                          select state;
            
            if (!string.IsNullOrEmpty(statename))
            {
                stateDataGridView.DataSource = results.ToList();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //this assigns the textbox a variable and trims extra space and decapitalizes it
            string searchTerm = userSearchTextBox.Text.Trim().ToLower();

            //LINQ statement to search through every column to match with what the user enters
            var searchData = db.States.Where(state =>
                state.STATE_NAME.ToLower().Contains(searchTerm) ||
                state.STATE_POPULATION.ToString().Contains(searchTerm) ||
                state.FLAG_DESCRIPTION.ToLower().Contains(searchTerm) ||
                state.STATE_FLOWER.ToLower().Contains(searchTerm) ||
                state.STATE_BIRD.ToLower().Contains(searchTerm) ||
                state.STATE_COLOR.ToLower().Contains(searchTerm) ||
                state.LARGEST_CITIES.ToLower().Contains(searchTerm) ||
                state.STATE_CAPITAL.ToLower().Contains(searchTerm) ||
                state.MEDIAN_INCOME.ToString().Contains(searchTerm) ||
                state.COMPUTER_JOB_PERCENTAGE.ToString().Contains(searchTerm)

            ).ToList(); //sends everything that was found to a list

            //this sends the list of state data to the datagrid
            stateDataGridView.DataSource = searchData;
        }

        //Here you can enter anything to update the value of the Median income
        private void updateButton_Click(object sender, EventArgs e)
        {
            //if you enter a letter or empty value it will error handle
            if (!decimal.TryParse(userUpdateTextBox.Text, out decimal updatedValue) && updatedValue >=0)
            {
                //the use of my state class and errormessage
                ErrorClass errorMessage = new ErrorClass();
                MessageBox.Show(errorMessage.GetErrors());
                return;
            }

            //gets the current cell selected row and assigns to variable
            int rowIndex = stateDataGridView.CurrentCell.RowIndex;

            //gets the current column that contains the decimal and assigns to variable
            int columnIndex = stateDataGridView.Columns["MEDIAN_INCOME"].Index;

            //this "updates" the value in the datagrid
            stateDataGridView.Rows[rowIndex].Cells[columnIndex].Value = updatedValue;

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            //once the button is clicked it runs the method below with the
            //argument of true to ascend because ascending is true in the method
            SortData(true);
        }

        private void sortDescendingButton_Click(object sender, EventArgs e)
        {
            //class library stuff
            //SortBool sortData = new SortBool();


            //once the button is clicked it runs the method below with the
            //argument of false to not ascend because ascending is false
            SortData(false);
        }

        //method to sort in ascending or descending
        private void SortData(bool ascending)
        {
                            //this ? is a quick way of writing an if statement so if ascending is true it executes
                            //ascending by the orderby method based on the column i gave to sort by
            var sortedData = ascending ? db.States.OrderBy(item => item.STATE_POPULATION).ToList()

                            //if ascending is false then Order by descending is executed based on column i chose
                                       : db.States.OrderByDescending(item => item.STATE_POPULATION).ToList();

            // Update the DataGridView with the sorted data
            stateDataGridView.DataSource = sortedData;
        }

        private void stateColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = stateColorComboBox.SelectedItem.ToString();

            // Filter data from the database based on the selected color
            var populateCombo = from state in db.States
                                orderby state.STATE_COLOR ascending
                                where state.STATE_COLOR == selectedColor
                                select state;


            // Update the BindingSource with the filtered data
            stateDataGridView.DataSource = populateCombo.ToList();
        }

        private void DataFormDisplay_Load(object sender, EventArgs e)
        {
            var populateCombo = from state in db.States
                                orderby state.STATE_COLOR ascending
                                select state.STATE_COLOR;

            stateColorComboBox.DataSource = populateCombo.ToList();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
