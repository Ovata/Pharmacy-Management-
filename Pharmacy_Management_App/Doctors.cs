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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.pharmacyDataSet.Doctor);

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

        private void bntCloseDr_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to close Doctor", "Pharmacy Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void bntAddDr_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.AddNew();
        }

        private void bntDeleteDr_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.RemoveCurrent();
        }

        private void bntNextDr_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MoveNext();
        }

        private void bntPreviousDr_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MovePrevious();
        }

        private void bntSaveDr_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }
    }
}
