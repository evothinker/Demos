using DemoMethods.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMethods
{
    public partial class frmEmployee : Form
    {
        int selectedActionIndex = -1;
        
        private Employee employee;  
        public frmEmployee()
        {
            InitializeComponent();
            grpAddNewEmployee.Hide();
            grpSrcExistingEmployee.Hide();
        }

        internal Employee GetEmployeeData()
        {
            ShowDialog();
            return employee;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employee = GetEmployee();
            Close();
        }

        private Employee GetEmployee()
        {
            employee = new Employee();
            employee.FirstName = txtEmpFirstName.Text;
            employee.LastName = txtEmpLastName.Text;
            employee.Mi = txtEmpMi.Text;
            employee.EmpAddress1 = txtEmpAddress1.Text;
            employee.EmpAddress2 = txtEmpAddress2.Text;
            employee.EmpCity = txtEmpCity.Text;
            employee.EmpState = txtEmpState.Text;
            employee.EmpZip = txtEmpZip.Text;
            employee.EmpPhone = txtEmpPhone.Text;
            employee.EmpEmergencyContactPhone = txtEmpEmCoPhone.Text;
            employee.JobTitle = cboEmpJobTitle.Text;
            return employee;
        }

        private void cboAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedActionIndex = cboAction.SelectedIndex;
            if (selectedActionIndex == 0)
            {
                grpSrcExistingEmployee.Hide();
                grpAddNewEmployee.Hide();

            }
            else if (selectedActionIndex == 1)
            {
                grpSrcExistingEmployee.Hide();
                grpAddNewEmployee.Show();
            }
            else if (selectedActionIndex == 2)
            {
                grpAddNewEmployee.Hide();
                grpSrcExistingEmployee.Show();
            }
            
            
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            cboAction.Focus();
        }
    }
}
