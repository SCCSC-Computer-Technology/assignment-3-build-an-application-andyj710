using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT206_AndyJablonski_Lab3
{
    public partial class StatesForm : Form
    {
        public StatesForm()
        {
            InitializeComponent();

            var populateCombo = from state in db.States
                                orderby state.STATE_NAME ascending
                                select state.STATE_NAME;

            stateComboBox.DataSource = populateCombo.ToList();
            
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void searchStateButton_Click(object sender, EventArgs e)
        {
            string selectionNo = stateComboBox.Text;
            

            if (!string.IsNullOrEmpty(selectionNo))
            {
                
                DataFormDisplay dataform = new DataFormDisplay(selectionNo);
                dataform.ShowDialog();

                var results = from state in db.States
                                orderby state.STATE_NAME
                                where state.STATE_NAME == selectionNo
                                select state;
            }
            else
            {
                MessageBox.Show("You must select a state from the combo box!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
