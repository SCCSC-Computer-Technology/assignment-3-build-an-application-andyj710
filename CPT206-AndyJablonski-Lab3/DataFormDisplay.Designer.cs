
namespace CPT206_AndyJablonski_Lab3
{
    partial class DataFormDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stateDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.sortAscendingButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.userSearchTextBox = new System.Windows.Forms.TextBox();
            this.userUpdateTextBox = new System.Windows.Forms.TextBox();
            this.sortDescendingButton = new System.Windows.Forms.Button();
            this.stateColorComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stateDataGridView
            // 
            this.stateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateDataGridView.Location = new System.Drawing.Point(12, 12);
            this.stateDataGridView.Name = "stateDataGridView";
            this.stateDataGridView.RowHeadersWidth = 51;
            this.stateDataGridView.RowTemplate.Height = 24;
            this.stateDataGridView.Size = new System.Drawing.Size(1406, 516);
            this.stateDataGridView.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(23, 604);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(141, 32);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "&Search:";
            this.toolTip1.SetToolTip(this.searchButton, "This searches the data in the database");
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(580, 604);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(141, 44);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "&Update:";
            this.toolTip1.SetToolTip(this.updateButton, "This Updates the data in the database based on what you type");
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // sortAscendingButton
            // 
            this.sortAscendingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sortAscendingButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortAscendingButton.Location = new System.Drawing.Point(580, 552);
            this.sortAscendingButton.Name = "sortAscendingButton";
            this.sortAscendingButton.Size = new System.Drawing.Size(141, 39);
            this.sortAscendingButton.TabIndex = 5;
            this.sortAscendingButton.Text = "Sort &Ascending";
            this.toolTip1.SetToolTip(this.sortAscendingButton, "This Sorts the data in the database in ascending order according to State populat" +
        "ion\r\n");
            this.sortAscendingButton.UseVisualStyleBackColor = false;
            this.sortAscendingButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // userSearchTextBox
            // 
            this.userSearchTextBox.Location = new System.Drawing.Point(170, 614);
            this.userSearchTextBox.Name = "userSearchTextBox";
            this.userSearchTextBox.Size = new System.Drawing.Size(368, 22);
            this.userSearchTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.userSearchTextBox, "Type anything to search for through the database and will display in the datagrid" +
        " when you select Search:");
            // 
            // userUpdateTextBox
            // 
            this.userUpdateTextBox.Location = new System.Drawing.Point(727, 614);
            this.userUpdateTextBox.Name = "userUpdateTextBox";
            this.userUpdateTextBox.Size = new System.Drawing.Size(368, 22);
            this.userUpdateTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.userUpdateTextBox, "Type a valid value here and click on the row to update the value Median Income, t" +
        "hen press update to enforce changes.");
            // 
            // sortDescendingButton
            // 
            this.sortDescendingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sortDescendingButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDescendingButton.Location = new System.Drawing.Point(580, 658);
            this.sortDescendingButton.Name = "sortDescendingButton";
            this.sortDescendingButton.Size = new System.Drawing.Size(141, 50);
            this.sortDescendingButton.TabIndex = 6;
            this.sortDescendingButton.Text = "Sort &Descending";
            this.toolTip1.SetToolTip(this.sortDescendingButton, "This Sorts the data in the database in descending order according to State popula" +
        "tion");
            this.sortDescendingButton.UseVisualStyleBackColor = false;
            this.sortDescendingButton.Click += new System.EventHandler(this.sortDescendingButton_Click);
            // 
            // stateColorComboBox
            // 
            this.stateColorComboBox.DataSource = this.stateBindingSource;
            this.stateColorComboBox.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateColorComboBox.FormattingEnabled = true;
            this.stateColorComboBox.Location = new System.Drawing.Point(307, 664);
            this.stateColorComboBox.Name = "stateColorComboBox";
            this.stateColorComboBox.Size = new System.Drawing.Size(231, 28);
            this.stateColorComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.stateColorComboBox, "Choose from the dropdown which state color to display in the datagrid!");
            this.stateColorComboBox.SelectedIndexChanged += new System.EventHandler(this.stateColorComboBox_SelectedIndexChanged);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(CPT206_AndyJablonski_Lab3.State);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1238, 683);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 40);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitButton, "This Sorts the data in the database in ascending order according to State populat" +
        "ion\r\n");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DataFormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1450, 754);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.stateColorComboBox);
            this.Controls.Add(this.sortDescendingButton);
            this.Controls.Add(this.userUpdateTextBox);
            this.Controls.Add(this.userSearchTextBox);
            this.Controls.Add(this.sortAscendingButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.stateDataGridView);
            this.Name = "DataFormDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataFormDisplay";
            this.Load += new System.EventHandler(this.DataFormDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stateDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button sortAscendingButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox userSearchTextBox;
        private System.Windows.Forms.TextBox userUpdateTextBox;
        private System.Windows.Forms.Button sortDescendingButton;
        private System.Windows.Forms.ComboBox stateColorComboBox;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.Button exitButton;
    }
}