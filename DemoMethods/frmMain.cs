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
    public partial class frmMain : Form
    {
        Employee employee = null;
        Property property = null;
        Equipment equipment = null;
        int selectedProjectItem = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProjectItem = cboProject.SelectedIndex;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProjectItem == 1)
                {
                    frmProperty fp = new frmProperty();
                    property = fp.GetPropertyData();
                }
                else if (selectedProjectItem == 2)
                {
                    frmEmployee femp = new frmEmployee();
                    employee = femp.GetEmployeeData();
                }
                else if (selectedProjectItem == 3)
                {
                    frmEquipment feq = new frmEquipment();
                    equipment = feq.GetEquipmentData();

                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
            

        }
    }
}
