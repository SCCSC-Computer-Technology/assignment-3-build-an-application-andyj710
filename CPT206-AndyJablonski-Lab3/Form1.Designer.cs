
namespace CPT206_AndyJablonski_Lab3
{
    partial class StatesForm
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
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.searchStateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataSource = this.stateBindingSource;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(373, 28);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(166, 24);
            this.stateComboBox.TabIndex = 0;
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(CPT206_AndyJablonski_Lab3.State);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a State from this dropdown to load all of it\'s data:";
            // 
            // searchStateButton
            // 
            this.searchStateButton.Location = new System.Drawing.Point(559, 23);
            this.searchStateButton.Name = "searchStateButton";
            this.searchStateButton.Size = new System.Drawing.Size(107, 32);
            this.searchStateButton.TabIndex = 1;
            this.searchStateButton.Text = "&Search";
            this.searchStateButton.UseVisualStyleBackColor = true;
            this.searchStateButton.Click += new System.EventHandler(this.searchStateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(672, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 36);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StatesForm
            // 
            this.AcceptButton = this.searchStateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(803, 105);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchStateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateComboBox);
            this.Name = "StatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateForm";
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.Button searchStateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

