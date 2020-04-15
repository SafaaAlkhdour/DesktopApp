using System;
using System.Windows.Forms;
using DatabaseManagement;

namespace EmployeesManagemenet
{
    public partial class frmEmployeesInformation : Form
    {
        public clsEmployee newEmployee { set; get; }
        bool addNewEmployee;
        public bool validValue = true;


        public frmEmployeesInformation(bool addNewEmployee)
        {
            InitializeComponent();
            this.addNewEmployee = addNewEmployee;
        }



        private void OKButton_Click(object sender, EventArgs e)
        {
            SetValidValues();
            if (!validValue)
            {

                this.DialogResult = DialogResult.None;
                validValue = true; 
            }
            else
            {
                newEmployee.Update();
                this.DialogResult = DialogResult.OK;
            }

        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // Set information about employee if all of these are validate
        public void SetValidValues()
        {

            if (txtNameBox.Text == "")
            {
                validValue = false;
                ErrorProvider.SetError(txtNameBox, "You must enter name");
            }
            else if (txtNameBox.Text.Length > 100)
            {
                validValue = false;
            }
            else
                newEmployee.Name = txtNameBox.Text;


            try
            {
                if (txtHeightBox.Text == "")
                {
                    validValue = false;
                    ErrorProvider.SetError(txtHeightBox, "Fill the height");
                }
                newEmployee.Height = Convert.ToDouble(txtHeightBox.Text);
                if (newEmployee.Height < 1 || newEmployee.Height > 300)
                {
                    validValue = false;
                }
            }
            catch
            {
                validValue = false;
            }


            try
            {
                if (txtWeightBox.Text == "")
                {
                    validValue = false;
                    ErrorProvider.SetError(txtWeightBox, "Fill the weight");

                }
                newEmployee.Weight = Convert.ToDouble(txtWeightBox.Text);
                if (newEmployee.Weight < 1 || newEmployee.Weight > 400)
                {
                    validValue = false;

                }
            }
            catch
            {
                validValue = false;

            }

            try
            {
                if (txtNationalIDBox.Text == "")
                {
                    validValue = false;
                    ErrorProvider.SetError(txtNationalIDBox, "you must enter nationalID");
                }
                int id = Convert.ToInt32(txtNationalIDBox.Text);
                int check = newEmployee.ExistNationalID(id); ;
                if (newEmployee.NationalID != id)
                {
                    if (!addNewEmployee && check == 1)
                    {
                        validValue = false;

                    }
                }
                newEmployee.NationalID = id;
                if (newEmployee.NationalID < 1 || newEmployee.NationalID > 1000000000)
                {
                    validValue = false;

                }

                if (addNewEmployee && check == 1)
                {
                    validValue = false;

                }
            }
            catch
            {
                validValue = false;

            }

            DateTime BoD = BirthDatePicker.Value.Date;
            DateTime date = DateTime.Now.Date;
            if (date.Year - BoD.Year < 18)
            {
                validValue = false;
                ErrorProvider.SetError(BirthDatePicker, "Age must be greater than or equal 18");
            }
            else
                newEmployee.Birthdate = BoD.Date;
        }

        private void NameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNameBox.Text == "")
                ErrorProvider.SetError(txtNameBox, "You must enter name");
            else if (txtNameBox.Text.Length > 100)
                ErrorProvider.SetError(txtNameBox, "Name length must be less than 100 characters");
            else
            {
                ErrorProvider.SetError(txtNameBox, "");
                CorrectProvider.SetError(txtNameBox, "Valid name");
            }
        }

        private void NationalIDBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int id;
            if (txtNationalIDBox.Text == "")
                ErrorProvider.SetError(txtNationalIDBox, "you must enter nationalID");
            else if (!int.TryParse(txtNationalIDBox.Text, out id))
                ErrorProvider.SetError(txtNationalIDBox, "NationalID must be a numeric");
            else if (Convert.ToInt32(txtNationalIDBox.Text) < 1 || Convert.ToInt32(txtNationalIDBox.Text) > 1000000)
                ErrorProvider.SetError(txtNationalIDBox, "Valid values within 1-1000000000");
            else if ((newEmployee.ExistNationalID(id) == 1 && id != newEmployee.NationalID && !addNewEmployee) ||
                (addNewEmployee && newEmployee.ExistNationalID(id) == 1))
                ErrorProvider.SetError(txtNationalIDBox, "NationalID is related to other employee");
            else
            {
                ErrorProvider.SetError(txtNationalIDBox, "");
                CorrectProvider.SetError(txtNationalIDBox, "Valid nationalID");
            }
        }

        private void HeightBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double height;
            if (txtHeightBox.Text == "")
                ErrorProvider.SetError(txtHeightBox, "Fill the height");
            else if (!Double.TryParse(txtHeightBox.Text, out height))
                ErrorProvider.SetError(txtHeightBox, "Must be a numeric");
            else if (Convert.ToInt32(txtHeightBox.Text) < 1 || Convert.ToInt32(txtHeightBox.Text) > 300)
                ErrorProvider.SetError(txtHeightBox, "Valid values 1-300");
            else
            {
                ErrorProvider.SetError(txtHeightBox, "");
                CorrectProvider.SetError(txtHeightBox, "Valid height");
            }
        }

        private void WeightBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double weight;
            if (txtWeightBox.Text == "")
                ErrorProvider.SetError(txtWeightBox, "Fill the weight");
            else if (!Double.TryParse(txtWeightBox.Text, out weight))
                ErrorProvider.SetError(txtWeightBox, "Must be a numeric");
            else if (Convert.ToInt32(txtWeightBox.Text) < 1 || Convert.ToInt32(txtWeightBox.Text) > 400)
                ErrorProvider.SetError(txtWeightBox, "Valid values 1-400");
            else
            {
                ErrorProvider.SetError(txtWeightBox, "");
                CorrectProvider.SetError(txtWeightBox, "Valid weight");
            }
        }

        private void BirthDatePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime BoD = BirthDatePicker.Value.Date;
            DateTime date = DateTime.Now.Date;
            if (date.Year - BoD.Year < 18)
            {
                ErrorProvider.SetError(BirthDatePicker, "Age must be greater than or equal 18");
            }
            else
            {
                ErrorProvider.SetError(BirthDatePicker, "");
                CorrectProvider.SetError(BirthDatePicker, "Valid age");
            }
        }
    }
}
