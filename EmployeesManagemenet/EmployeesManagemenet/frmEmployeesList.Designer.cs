namespace EmployeesManagemenet
{
    partial class frmEmployeesList
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
            this.EmployeeListForm = new System.Windows.Forms.Panel();
            this.lstEmployeesListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditButton = new System.Windows.Forms.Button();
            this.btnRemoveButton = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.lblemployeeNamesLabel = new System.Windows.Forms.Label();
            this.btnExitButton = new System.Windows.Forms.Button();
            this.EmployeeListForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeListForm
            // 
            this.EmployeeListForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeListForm.Controls.Add(this.lstEmployeesListView);
            this.EmployeeListForm.Controls.Add(this.btnEditButton);
            this.EmployeeListForm.Controls.Add(this.btnRemoveButton);
            this.EmployeeListForm.Controls.Add(this.btnAddButton);
            this.EmployeeListForm.Controls.Add(this.lblemployeeNamesLabel);
            this.EmployeeListForm.Location = new System.Drawing.Point(8, 8);
            this.EmployeeListForm.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeListForm.Name = "EmployeeListForm";
            this.EmployeeListForm.Size = new System.Drawing.Size(507, 284);
            this.EmployeeListForm.TabIndex = 0;
            // 
            // EmployeesListView
            // 
            this.lstEmployeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.Birthdate});
            this.lstEmployeesListView.FullRowSelect = true;
            this.lstEmployeesListView.HideSelection = false;
            this.lstEmployeesListView.Location = new System.Drawing.Point(11, 21);
            this.lstEmployeesListView.MultiSelect = false;
            this.lstEmployeesListView.Name = "EmployeesListView";
            this.lstEmployeesListView.Size = new System.Drawing.Size(482, 229);
            this.lstEmployeesListView.TabIndex = 5;
            this.lstEmployeesListView.UseCompatibleStateImageBehavior = false;
            this.lstEmployeesListView.View = System.Windows.Forms.View.Details;
            this.lstEmployeesListView.SelectedIndexChanged += new System.EventHandler(this.EmployeesListView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.DisplayIndex = 2;
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Name
            // 
            this.Name.DisplayIndex = 0;
            this.Name.Text = "Name";
            this.Name.Width = 371;
            // 
            // Birthdate
            // 
            this.Birthdate.DisplayIndex = 1;
            this.Birthdate.Text = "Birthdate";
            this.Birthdate.Width = 105;
            // 
            // EditButton
            // 
            this.btnEditButton.Location = new System.Drawing.Point(191, 254);
            this.btnEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditButton.Name = "EditButton";
            this.btnEditButton.Size = new System.Drawing.Size(86, 20);
            this.btnEditButton.TabIndex = 4;
            this.btnEditButton.Text = "Edit";
            this.btnEditButton.UseVisualStyleBackColor = true;
            this.btnEditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.btnRemoveButton.Location = new System.Drawing.Point(101, 254);
            this.btnRemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveButton.Name = "RemoveButton";
            this.btnRemoveButton.Size = new System.Drawing.Size(86, 20);
            this.btnRemoveButton.TabIndex = 3;
            this.btnRemoveButton.Text = "Remove";
            this.btnRemoveButton.UseVisualStyleBackColor = true;
            this.btnRemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(11, 254);
            this.btnAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddButton.Name = "AddButton";
            this.btnAddButton.Size = new System.Drawing.Size(86, 20);
            this.btnAddButton.TabIndex = 2;
            this.btnAddButton.Text = "Add";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // employeeNamesLabel
            // 
            this.lblemployeeNamesLabel.AutoSize = true;
            this.lblemployeeNamesLabel.Location = new System.Drawing.Point(8, 5);
            this.lblemployeeNamesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemployeeNamesLabel.Name = "employeeNamesLabel";
            this.lblemployeeNamesLabel.Size = new System.Drawing.Size(155, 13);
            this.lblemployeeNamesLabel.TabIndex = 1;
            this.lblemployeeNamesLabel.Text = "Employee names and birthdate:";
            // 
            // ExitButton
            // 
            this.btnExitButton.Location = new System.Drawing.Point(429, 300);
            this.btnExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitButton.Name = "ExitButton";
            this.btnExitButton.Size = new System.Drawing.Size(86, 22);
            this.btnExitButton.TabIndex = 2;
            this.btnExitButton.Text = "Exit";
            this.btnExitButton.UseVisualStyleBackColor = true;
            this.btnExitButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 326);
            this.Controls.Add(this.btnExitButton);
            this.Controls.Add(this.EmployeeListForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 365);
            this.MinimumSize = new System.Drawing.Size(535, 365);
            this.Text = "List of employees";
            this.EmployeeListForm.ResumeLayout(false);
            this.EmployeeListForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmployeeListForm;
        private System.Windows.Forms.Label lblemployeeNamesLabel;
        private System.Windows.Forms.Button btnEditButton;
        private System.Windows.Forms.Button btnRemoveButton;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Button btnExitButton;
        private System.Windows.Forms.ListView lstEmployeesListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Birthdate;
        private System.Windows.Forms.ColumnHeader ID;
    }
}

