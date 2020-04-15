namespace EmployeesManagemenet
{
    partial class frmEmployeesInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeesInformation));
            this.EmployeeAccount = new System.Windows.Forms.Panel();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtWeightBox = new System.Windows.Forms.TextBox();
            this.txtHeightBox = new System.Windows.Forms.TextBox();
            this.txtNationalIDBox = new System.Windows.Forms.TextBox();
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.lblFillForm = new System.Windows.Forms.Label();
            this.lblBirthDateLabel = new System.Windows.Forms.Label();
            this.lblWeightLabel = new System.Windows.Forms.Label();
            this.lblHeightLabel = new System.Windows.Forms.Label();
            this.lblNatIDLabel = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CorrectProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmployeeAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeAccount
            // 
            this.EmployeeAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeAccount.Controls.Add(this.BirthDatePicker);
            this.EmployeeAccount.Controls.Add(this.txtWeightBox);
            this.EmployeeAccount.Controls.Add(this.txtHeightBox);
            this.EmployeeAccount.Controls.Add(this.txtNationalIDBox);
            this.EmployeeAccount.Controls.Add(this.txtNameBox);
            this.EmployeeAccount.Controls.Add(this.lblFillForm);
            this.EmployeeAccount.Controls.Add(this.lblBirthDateLabel);
            this.EmployeeAccount.Controls.Add(this.lblWeightLabel);
            this.EmployeeAccount.Controls.Add(this.lblHeightLabel);
            this.EmployeeAccount.Controls.Add(this.lblNatIDLabel);
            this.EmployeeAccount.Controls.Add(this.lblNameLabel);
            this.EmployeeAccount.Location = new System.Drawing.Point(8, 8);
            this.EmployeeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeAccount.Name = "EmployeeAccount";
            this.EmployeeAccount.Size = new System.Drawing.Size(319, 181);
            this.EmployeeAccount.TabIndex = 0;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(80, 141);
            this.BirthDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(211, 20);
            this.BirthDatePicker.TabIndex = 29;
            this.BirthDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.BirthDatePicker_Validating);
            // 
            // WeightBox
            // 
            this.txtWeightBox.Location = new System.Drawing.Point(80, 113);
            this.txtWeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeightBox.MaxLength = 5;
            this.txtWeightBox.Name = "WeightBox";
            this.txtWeightBox.Size = new System.Drawing.Size(211, 20);
            this.txtWeightBox.TabIndex = 33;
            this.txtWeightBox.Validating += new System.ComponentModel.CancelEventHandler(this.WeightBox_Validating);
            // 
            // HeightBox
            // 
            this.txtHeightBox.Location = new System.Drawing.Point(80, 85);
            this.txtHeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeightBox.MaxLength = 5;
            this.txtHeightBox.Name = "HeightBox";
            this.txtHeightBox.Size = new System.Drawing.Size(211, 20);
            this.txtHeightBox.TabIndex = 32;
            this.txtHeightBox.Validating += new System.ComponentModel.CancelEventHandler(this.HeightBox_Validating);
            // 
            // NationalIDBox
            // 
            this.txtNationalIDBox.Location = new System.Drawing.Point(80, 57);
            this.txtNationalIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtNationalIDBox.MaxLength = 10;
            this.txtNationalIDBox.Name = "NationalIDBox";
            this.txtNationalIDBox.Size = new System.Drawing.Size(211, 20);
            this.txtNationalIDBox.TabIndex = 31;
            this.txtNationalIDBox.Validating += new System.ComponentModel.CancelEventHandler(this.NationalIDBox_Validating);
            // 
            // NameBox
            // 
            this.txtNameBox.Location = new System.Drawing.Point(80, 30);
            this.txtNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameBox.MaxLength = 1000;
            this.txtNameBox.Name = "NameBox";
            this.txtNameBox.Size = new System.Drawing.Size(211, 20);
            this.txtNameBox.TabIndex = 30;
            this.txtNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            // 
            // FillForm
            // 
            this.lblFillForm.AutoSize = true;
            this.lblFillForm.Location = new System.Drawing.Point(8, 11);
            this.lblFillForm.Name = "FillForm";
            this.lblFillForm.Size = new System.Drawing.Size(130, 13);
            this.lblFillForm.TabIndex = 10;
            this.lblFillForm.Text = "You must fill all information";
            // 
            // BirthDateLabel
            // 
            this.lblBirthDateLabel.AutoSize = true;
            this.lblBirthDateLabel.Location = new System.Drawing.Point(8, 144);
            this.lblBirthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDateLabel.Name = "BirthDateLabel";
            this.lblBirthDateLabel.Size = new System.Drawing.Size(52, 13);
            this.lblBirthDateLabel.TabIndex = 5;
            this.lblBirthDateLabel.Text = "Birthdate:";
            // 
            // WeightLabel
            // 
            this.lblWeightLabel.AutoSize = true;
            this.lblWeightLabel.Location = new System.Drawing.Point(7, 113);
            this.lblWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeightLabel.Name = "WeightLabel";
            this.lblWeightLabel.Size = new System.Drawing.Size(71, 13);
            this.lblWeightLabel.TabIndex = 4;
            this.lblWeightLabel.Text = "Weight ( kg ):";
            // 
            // HeightLabel
            // 
            this.lblHeightLabel.AutoSize = true;
            this.lblHeightLabel.Location = new System.Drawing.Point(8, 85);
            this.lblHeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeightLabel.Name = "HeightLabel";
            this.lblHeightLabel.Size = new System.Drawing.Size(70, 13);
            this.lblHeightLabel.TabIndex = 3;
            this.lblHeightLabel.Text = "Height ( cm ):";
            // 
            // NatIDLabel
            // 
            this.lblNatIDLabel.AutoSize = true;
            this.lblNatIDLabel.Location = new System.Drawing.Point(8, 57);
            this.lblNatIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNatIDLabel.Name = "NatIDLabel";
            this.lblNatIDLabel.Size = new System.Drawing.Size(63, 13);
            this.lblNatIDLabel.TabIndex = 2;
            this.lblNatIDLabel.Text = "National ID:";
            // 
            // NameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Location = new System.Drawing.Point(8, 30);
            this.lblNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameLabel.Name = "NameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblNameLabel.TabIndex = 1;
            this.lblNameLabel.Text = "Name:";
            // 
            // OK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(149, 193);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "OK";
            this.btnOK.Size = new System.Drawing.Size(87, 24);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.btnCancelButton.Location = new System.Drawing.Point(239, 193);
            this.btnCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelButton.Name = "CancelButton";
            this.btnCancelButton.Size = new System.Drawing.Size(87, 24);
            this.btnCancelButton.TabIndex = 2;
            this.btnCancelButton.Text = "Cancel";
            this.btnCancelButton.UseVisualStyleBackColor = true;
            this.btnCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // CorrectProvider
            // 
            this.CorrectProvider.ContainerControl = this;
            this.CorrectProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("CorrectProvider.Icon")));
            // 
            // EmployeesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 231);
            this.Controls.Add(this.btnCancelButton);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.EmployeeAccount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 270);
            this.MinimumSize = new System.Drawing.Size(352, 270);
            this.Name = "EmployeesInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registeration";
            this.EmployeeAccount.ResumeLayout(false);
            this.EmployeeAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmployeeAccount;
        private System.Windows.Forms.Label lblBirthDateLabel;
        private System.Windows.Forms.Label lblWeightLabel;
        private System.Windows.Forms.Label lblHeightLabel;
        private System.Windows.Forms.Label lblNatIDLabel;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelButton;
        private System.Windows.Forms.Label lblFillForm;
        public System.Windows.Forms.DateTimePicker BirthDatePicker;
        public System.Windows.Forms.TextBox txtWeightBox;
        public System.Windows.Forms.TextBox txtHeightBox;
        public System.Windows.Forms.TextBox txtNationalIDBox;
        public System.Windows.Forms.TextBox txtNameBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ErrorProvider CorrectProvider;
    }
}