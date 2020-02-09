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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.GP_Appointment' table. You can move, or remove it, as needed.
            this.gP_AppointmentTableAdapter.Fill(this.pharmacyDataSet.GP_Appointment);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.pharmacyDataSet.Patient);

        }

        private void bntAddPat_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
        }

        private void bntDeletePat_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.RemoveCurrent();
        }

        private void bntNextPat_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.MoveNext();
        }

        private void bntPreviousPat_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.MovePrevious();
        }

        private void bntSavePat_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void bntClosePat_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to close GP Appointment", "Pharmacy Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void bntExitPat_Click(object sender, EventArgs e)
        {

        }
    }
}
