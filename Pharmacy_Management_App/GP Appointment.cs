using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_App
{
    public partial class GP_Appointment : Form
    {
        public GP_Appointment()
        {
            InitializeComponent();
        }

        private void gP_AppointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void gP_AppointmentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void GP_Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.GP_Appointment' table. You can move, or remove it, as needed.
            this.gP_AppointmentTableAdapter.Fill(this.pharmacyDataSet.GP_Appointment);

        }

        private void bntAddDr_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.AddNew();
        }

        private void bntDeleteDr_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.RemoveCurrent();
        }

        private void bntNextDr_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.MoveNext();
        }

        private void bntPreviousDr_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.MovePrevious();
        }

        private void bntSaveDr_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_AppointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void bntCloseDr_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to close GP Appointment", "Pharmacy Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void bntExitDr_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to exit", "Pharmacy Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
