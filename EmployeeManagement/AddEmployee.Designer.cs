namespace EmployeeManagement
{
    partial class AddEmployee
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
            this.Name = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Rank = new System.Windows.Forms.Label();
            this.rankComboBox = new System.Windows.Forms.ComboBox();
            this.languagesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployeeToCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(9, 18);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Location = new System.Drawing.Point(9, 79);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(33, 13);
            this.Rank.TabIndex = 2;
            this.Rank.Text = "Rank";
            // 
            // rankComboBox
            // 
            this.rankComboBox.FormattingEnabled = true;
            this.rankComboBox.Location = new System.Drawing.Point(12, 108);
            this.rankComboBox.Name = "rankComboBox";
            this.rankComboBox.Size = new System.Drawing.Size(204, 21);
            this.rankComboBox.TabIndex = 3;
            // 
            // languagesCheckedListBox
            // 
            this.languagesCheckedListBox.FormattingEnabled = true;
            this.languagesCheckedListBox.Location = new System.Drawing.Point(12, 157);
            this.languagesCheckedListBox.Name = "languagesCheckedListBox";
            this.languagesCheckedListBox.Size = new System.Drawing.Size(204, 79);
            this.languagesCheckedListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select programming languages";
            // 
            // AddEmployeeToCSV
            // 
            this.AddEmployeeToCSV.Location = new System.Drawing.Point(15, 257);
            this.AddEmployeeToCSV.Name = "AddEmployeeToCSV";
            this.AddEmployeeToCSV.Size = new System.Drawing.Size(200, 23);
            this.AddEmployeeToCSV.TabIndex = 6;
            this.AddEmployeeToCSV.Text = "Add Employee";
            this.AddEmployeeToCSV.UseVisualStyleBackColor = true;
            this.AddEmployeeToCSV.Click += new System.EventHandler(this.AddEmployeeToCSV_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 292);
            this.Controls.Add(this.AddEmployeeToCSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languagesCheckedListBox);
            this.Controls.Add(this.rankComboBox);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Name);
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.ComboBox rankComboBox;
        private System.Windows.Forms.CheckedListBox languagesCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEmployeeToCSV;
    }
}