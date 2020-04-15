using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DatabaseManagement; 

namespace EmployeesManagemenet
{
    public partial class frmEmployeesList : Form
    {
        public frmEmployeesList()
        {
            InitializeComponent();
            DisableButton();
            FillList();
        }


        private void FillList()
        {
            List<clsEmployee> allEmployees = new List<clsEmployee>();
            allEmployees = clsEmployee.GetEmployees();
            for (int i = 0; i < clsEmployee.GetEmployees().Count; i++)
            {
                string[] addRow = new string[3];
                addRow[0] = allEmployees[0].ID.ToString();
                addRow[1] = allEmployees[0].Name;
                addRow[2] = allEmployees[0].Birthdate.ToShortDateString();
                ListViewItem addItems = new ListViewItem(addRow);
                lstEmployeesListView.Items.Add(addItems);
                allEmployees.RemoveAt(0);
            }
        }

        // Disable buttons if no row is selected 
        private void DisableButton()
        { 
          btnRemoveButton.Enabled = false;
          btnEditButton.Enabled = false;
        }


        // After add new employee display the information at list
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (frmEmployeesInformation InfoForm = new frmEmployeesInformation(true) { newEmployee = new clsEmployee() })
            {
                if (InfoForm.ShowDialog() == DialogResult.OK && InfoForm.validValue)
                {
                    string[] addRow = new string[3];
                    addRow[0] = InfoForm.newEmployee.ID.ToString();
                    addRow[1] = InfoForm.newEmployee.Name;
                    addRow[2] = InfoForm.newEmployee.Birthdate.ToShortDateString();
                    ListViewItem addItems = new ListViewItem(addRow);
                    lstEmployeesListView.Items.Add(addItems);
                }               
                  
            }
        }


        // Remove selected employee from database and list after confirm message 
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult msg = new DialogResult();
            msg = MessageBox.Show("Are you Sure to delete this employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                ListViewItem item = lstEmployeesListView.Items[lstEmployeesListView.SelectedIndices[0]];
                clsEmployee removeEmployee = new clsEmployee();
                removeEmployee.ID = Convert.ToInt32(item.SubItems[0].Text);
                removeEmployee.Delete();
                lstEmployeesListView.Items.RemoveAt(lstEmployeesListView.FocusedItem.Index);
                DisableButton();
            }
            else
            {
                if (lstEmployeesListView.SelectedItems.Count == 0)
                    DisableButton();
            }
            
        }


        // Get information about employee to edit 
        private void EditButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = lstEmployeesListView.Items[lstEmployeesListView.SelectedIndices[0]];
            clsEmployee editEmployee = new clsEmployee();
            editEmployee.ID = (Convert.ToInt32(item.SubItems[0].Text));
            editEmployee.Read();

            using (frmEmployeesInformation InfoForm = new frmEmployeesInformation(false) { newEmployee = editEmployee })
            {
                InfoForm.txtNameBox.Text = editEmployee.Name;
                InfoForm.txtNationalIDBox.Text = editEmployee.NationalID.ToString();
                InfoForm.txtHeightBox.Text = editEmployee.Height.ToString();
                InfoForm.txtWeightBox.Text = editEmployee.Weight.ToString();
                InfoForm.BirthDatePicker.Value=editEmployee.Birthdate.Date;
               
                if (InfoForm.ShowDialog() == DialogResult.OK)
                {   if (InfoForm.validValue)
                    {
                        editEmployee.Name = InfoForm.txtNameBox.Text;
                        editEmployee.NationalID = Convert.ToInt32(InfoForm.txtNationalIDBox.Text);
                        editEmployee.Height = Convert.ToDouble(InfoForm.txtHeightBox.Text);
                        editEmployee.Weight = Convert.ToDouble(InfoForm.txtWeightBox.Text);
                        editEmployee.Birthdate = InfoForm.BirthDatePicker.Value.Date;
                        editEmployee.Update();

                        lstEmployeesListView.SelectedItems[0].SubItems[1].Text = editEmployee.Name;
                        lstEmployeesListView.SelectedItems[0].SubItems[2].Text = editEmployee.Birthdate.ToShortDateString();
                    }
                }

            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Disable\Enable buttons depends on row selected
        private void EmployeesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployeesListView.SelectedItems.Count > 0)
            {
                btnRemoveButton.Enabled = true;
                btnEditButton.Enabled = true;
            }
            if (lstEmployeesListView.SelectedItems.Count == 0)
                DisableButton();
        }

        
    }
}
