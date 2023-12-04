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
    public partial class frmProperty : Form
    {
        private Property property;
        int selectedAction = 0;
        public frmProperty()
        {
            InitializeComponent();
        }

        public Property GetPropertyData()
        {
            ShowDialog();
           
            return property;
        }

        private Property GetProperty()
        {
            property = new Property();
            property.Address1 = txtAddress1.Text;
            property.Address2 = txtAddress2.Text;
            property.City = txtCity.Text;
            property.State = cboState.Text;
            property.Zip = txtZip.Text;

            return property;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            property = GetProperty();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cboAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAction = cboAction.SelectedIndex;
            txtAddress1.Focus();

        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
            cboAction.Focus();
        }
    }
}
