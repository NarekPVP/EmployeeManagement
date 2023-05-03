namespace EmployeeManagement
{
    partial class Form1
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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.employeeRank = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(4, 27);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.Size = new System.Drawing.Size(784, 383);
            this.mainDataGridView.TabIndex = 0;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(626, 415);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(162, 23);
            this.AddEmployeeButton.TabIndex = 1;
            this.AddEmployeeButton.Text = "New employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(458, 415);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(162, 23);
            this.EditEmployeeButton.TabIndex = 2;
            this.EditEmployeeButton.Text = "Edit employee";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(290, 415);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(162, 23);
            this.DeleteEmployeeButton.TabIndex = 3;
            this.DeleteEmployeeButton.Text = "Delete Employee";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.Location = new System.Drawing.Point(12, 415);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(104, 23);
            this.SupportButton.TabIndex = 5;
            this.SupportButton.Text = "SupportMe";
            this.SupportButton.UseVisualStyleBackColor = true;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // employeeRank
            // 
            this.employeeRank.FormattingEnabled = true;
            this.employeeRank.Location = new System.Drawing.Point(123, 416);
            this.employeeRank.Name = "employeeRank";
            this.employeeRank.Size = new System.Drawing.Size(161, 21);
            this.employeeRank.TabIndex = 6;
            this.employeeRank.SelectedIndexChanged += new System.EventHandler(this.employeeRank_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsCsvToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportAsCsvToolStripMenuItem
            // 
            this.exportAsCsvToolStripMenuItem.Name = "exportAsCsvToolStripMenuItem";
            this.exportAsCsvToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAsCsvToolStripMenuItem.Text = "Export as csv";
            this.exportAsCsvToolStripMenuItem.Click += new System.EventHandler(this.exportAsCsvToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeRank);
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Employee management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.ComboBox employeeRank;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

