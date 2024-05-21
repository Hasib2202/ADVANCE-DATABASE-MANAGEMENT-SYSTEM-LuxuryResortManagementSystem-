using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUXURY_RESORT_MANAGEMENT_SYSTEM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuestregistration_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnGuestregistration.Left+32;
            uC_GuestRegistration1.Visible = true;
            uC_GuestRegistration1.BringToFront();

        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnAddroom.Left;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            uC_GuestCheckOut1.Visible = true;
            uC_GuestCheckOut1.BringToFront();


            movingPanel.Left = btnCheckout.Left+2;
        }

    

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
            movingPanel.Left = btnEmployee.Left;
        }

        private void btnGuestdetails_Click(object sender, EventArgs e)
        {
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
            movingPanel.Left = btnGuestdetails.Left+12;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible=false;
            uC_AddRoom1.Visible = false;
            uC_GuestRegistration1.Visible = false;

            btnAddroom.PerformClick();
        }
    }
}
