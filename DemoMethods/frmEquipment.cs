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
    public partial class frmEquipment : Form
    {
        private Equipment equipment;
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            equipment = GetEquipment();
            Close();
        }

        private Equipment GetEquipment()
        {
            equipment = new Equipment();
            equipment.Type = cboType.Text;
            equipment.Manufacturer = cboManufacturer.Text;
            equipment.Year = Convert.ToInt32(txtYear.Text);
            equipment.Model = txtModel.Text;
            equipment.LastInspection = Convert.ToDateTime(calLastInspection.SelectionStart);
            return equipment;
        }

        internal Equipment GetEquipmentData()
        {
            ShowDialog();
            return equipment;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
