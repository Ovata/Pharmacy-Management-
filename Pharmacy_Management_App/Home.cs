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
    public partial class Home : Form
    {
        Doctors dc;
        GP_Appointment gp;
        Patient pat;
        Payment pay;
        Pharmacy pharm;
        Office off;

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dc = new Doctors();
            dc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gp = new GP_Appointment();
            gp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pat = new Patient();
            pat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pay = new Payment();
            pay.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pharm = new Pharmacy();
            pharm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            off = new Office();
            off.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to exit", "Pharmacy Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "test" && txtPassword.Text == "test")
            {
                bntDoctor.Enabled = true;
                bntGP.Enabled = true;
                bntPatient.Enabled = true;
                bntPayment.Enabled = true;
                bntPharmacy.Enabled = true;
                bntOffice.Enabled = true;
                bntSurgery.Enabled = true;
                bntHostital.Enabled = true;
                bntSpecialist.Enabled = true;
                bntConsultant.Enabled = true;
                bntPharmacist.Enabled = true;
                bntPF.Enabled = true;
                bntHelp.Enabled = true;

                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                bntLogin.Enabled = false;

                txtUsername.Clear();
                txtPassword.Clear();

            }
            else
            {
                MessageBox.Show("The username or password is incorrect", "Pharmacy Management");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            bntDoctor.Enabled = false;
            bntGP.Enabled = false;
            bntPatient.Enabled = false;
            bntPayment.Enabled = false;
            bntPharmacy.Enabled = false;
            bntOffice.Enabled = false;
            bntSurgery.Enabled = false;
            bntHostital.Enabled = false;
            bntSpecialist.Enabled = false;
            bntConsultant.Enabled = false;
            bntPharmacist.Enabled = false;
            bntPF.Enabled = false;
            bntHelp.Enabled = false;

            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            bntLogin.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

            bntDoctor.Enabled = false;
            bntGP.Enabled = false;
            bntPatient.Enabled = false;
            bntPayment.Enabled = false;
            bntPharmacy.Enabled = false;
            bntOffice.Enabled = false;
            bntSurgery.Enabled = false;
            bntHostital.Enabled = false;
            bntSpecialist.Enabled = false;
            bntConsultant.Enabled = false;
            bntPharmacist.Enabled = false;
            bntPF.Enabled = false;
            bntHelp.Enabled = false;

            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            bntLogin.Enabled = true;
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

            bntDoctor.Enabled = false;
            bntGP.Enabled = false;
            bntPatient.Enabled = false;
            bntPayment.Enabled = false;
            bntPharmacy.Enabled = false;
            bntOffice.Enabled = false;
            bntSurgery.Enabled = false;
            bntHostital.Enabled = false;
            bntSpecialist.Enabled = false;
            bntConsultant.Enabled = false;
            bntPharmacist.Enabled = false;
            bntPF.Enabled = false;
            bntHelp.Enabled = false;
        }
    }
}
