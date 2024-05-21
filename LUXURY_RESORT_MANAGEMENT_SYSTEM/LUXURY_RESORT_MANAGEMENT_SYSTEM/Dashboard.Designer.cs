namespace LUXURY_RESORT_MANAGEMENT_SYSTEM
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.movingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuestregistration = new Guna.UI.WinForms.GunaButton();
            this.btnCheckout = new Guna.UI.WinForms.GunaButton();
            this.btnEmployee = new Guna.UI.WinForms.GunaButton();
            this.btnGuestdetails = new Guna.UI.WinForms.GunaButton();
            this.btnAddroom = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_CustomerDetails1 = new LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control.UC_GuestDetails();
            this.uC_GuestCheckOut1 = new LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control.UC_GuestCheckOut();
            this.uC_GuestRegistration1 = new LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control.UC_GuestRegistration();
            this.uC_AddRoom1 = new LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control.UC_AddRoom();
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_Employee1 = new LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control.UC_Employee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.movingPanel);
            this.panel1.Controls.Add(this.btnGuestregistration);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnGuestdetails);
            this.panel1.Controls.Add(this.btnAddroom);
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 100);
            this.panel1.TabIndex = 1;
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.movingPanel.Location = new System.Drawing.Point(31, 77);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(164, 5);
            this.movingPanel.TabIndex = 5;
            // 
            // btnGuestregistration
            // 
            this.btnGuestregistration.AnimationHoverSpeed = 0.07F;
            this.btnGuestregistration.AnimationSpeed = 0.03F;
            this.btnGuestregistration.BackColor = System.Drawing.Color.Transparent;
            this.btnGuestregistration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnGuestregistration.BorderColor = System.Drawing.Color.Black;
            this.btnGuestregistration.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuestregistration.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuestregistration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestregistration.ForeColor = System.Drawing.Color.White;
            this.btnGuestregistration.Image = ((System.Drawing.Image)(resources.GetObject("btnGuestregistration.Image")));
            this.btnGuestregistration.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuestregistration.Location = new System.Drawing.Point(226, 16);
            this.btnGuestregistration.Name = "btnGuestregistration";
            this.btnGuestregistration.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnGuestregistration.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuestregistration.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGuestregistration.OnHoverImage = null;
            this.btnGuestregistration.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuestregistration.Radius = 26;
            this.btnGuestregistration.Size = new System.Drawing.Size(234, 66);
            this.btnGuestregistration.TabIndex = 4;
            this.btnGuestregistration.Text = "Guest Registration";
            this.btnGuestregistration.Click += new System.EventHandler(this.btnGuestregistration_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AnimationHoverSpeed = 0.07F;
            this.btnCheckout.AnimationSpeed = 0.03F;
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCheckout.BorderColor = System.Drawing.Color.Black;
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckout.FocusedColor = System.Drawing.Color.Empty;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckout.Location = new System.Drawing.Point(493, 16);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnCheckout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCheckout.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnCheckout.OnHoverImage = null;
            this.btnCheckout.OnPressedColor = System.Drawing.Color.Black;
            this.btnCheckout.Radius = 26;
            this.btnCheckout.Size = new System.Drawing.Size(165, 66);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.AnimationHoverSpeed = 0.07F;
            this.btnEmployee.AnimationSpeed = 0.03F;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployee.BorderColor = System.Drawing.Color.Black;
            this.btnEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployee.Location = new System.Drawing.Point(906, 16);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnEmployee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEmployee.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnEmployee.OnHoverImage = null;
            this.btnEmployee.OnPressedColor = System.Drawing.Color.Black;
            this.btnEmployee.Radius = 26;
            this.btnEmployee.Size = new System.Drawing.Size(159, 66);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Staff";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnGuestdetails
            // 
            this.btnGuestdetails.AnimationHoverSpeed = 0.07F;
            this.btnGuestdetails.AnimationSpeed = 0.03F;
            this.btnGuestdetails.BackColor = System.Drawing.Color.Transparent;
            this.btnGuestdetails.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnGuestdetails.BorderColor = System.Drawing.Color.Black;
            this.btnGuestdetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuestdetails.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuestdetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestdetails.ForeColor = System.Drawing.Color.White;
            this.btnGuestdetails.Image = ((System.Drawing.Image)(resources.GetObject("btnGuestdetails.Image")));
            this.btnGuestdetails.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuestdetails.Location = new System.Drawing.Point(691, 16);
            this.btnGuestdetails.Name = "btnGuestdetails";
            this.btnGuestdetails.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnGuestdetails.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuestdetails.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGuestdetails.OnHoverImage = null;
            this.btnGuestdetails.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuestdetails.Radius = 26;
            this.btnGuestdetails.Size = new System.Drawing.Size(182, 66);
            this.btnGuestdetails.TabIndex = 1;
            this.btnGuestdetails.Text = "Guest Details";
            this.btnGuestdetails.Click += new System.EventHandler(this.btnGuestdetails_Click);
            // 
            // btnAddroom
            // 
            this.btnAddroom.AnimationHoverSpeed = 0.07F;
            this.btnAddroom.AnimationSpeed = 0.03F;
            this.btnAddroom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddroom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAddroom.BorderColor = System.Drawing.Color.Black;
            this.btnAddroom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddroom.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddroom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddroom.ForeColor = System.Drawing.Color.White;
            this.btnAddroom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddroom.Image")));
            this.btnAddroom.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddroom.Location = new System.Drawing.Point(31, 16);
            this.btnAddroom.Name = "btnAddroom";
            this.btnAddroom.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddroom.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddroom.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddroom.OnHoverImage = null;
            this.btnAddroom.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddroom.Radius = 26;
            this.btnAddroom.Size = new System.Drawing.Size(164, 66);
            this.btnAddroom.TabIndex = 0;
            this.btnAddroom.Text = "Add Room";
            this.btnAddroom.Click += new System.EventHandler(this.btnAddroom_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetails1);
            this.panel2.Controls.Add(this.uC_GuestCheckOut1);
            this.panel2.Controls.Add(this.uC_GuestRegistration1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 528);
            this.panel2.TabIndex = 2;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(20, 16);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1100, 500);
            this.uC_CustomerDetails1.TabIndex = 3;
            // 
            // uC_GuestCheckOut1
            // 
            this.uC_GuestCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_GuestCheckOut1.Location = new System.Drawing.Point(20, 16);
            this.uC_GuestCheckOut1.Name = "uC_GuestCheckOut1";
            this.uC_GuestCheckOut1.Size = new System.Drawing.Size(1100, 500);
            this.uC_GuestCheckOut1.TabIndex = 2;
            // 
            // uC_GuestRegistration1
            // 
            this.uC_GuestRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_GuestRegistration1.Location = new System.Drawing.Point(20, 16);
            this.uC_GuestRegistration1.Name = "uC_GuestRegistration1";
            this.uC_GuestRegistration1.Size = new System.Drawing.Size(1100, 500);
            this.uC_GuestRegistration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(20, 16);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1100, 500);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Empty;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(28, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BaseColor = System.Drawing.Color.Empty;
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(12, 51);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(28, 33);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 30;
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 30;
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 30;
            this.gunaElipse4.TargetControl = this;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 30;
            this.gunaElipse5.TargetControl = this;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(20, 16);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1100, 500);
            this.uC_Employee1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1168, 658);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnGuestregistration;
        private Guna.UI.WinForms.GunaButton btnCheckout;
        private Guna.UI.WinForms.GunaButton btnEmployee;
        private Guna.UI.WinForms.GunaButton btnGuestdetails;
        private Guna.UI.WinForms.GunaButton btnAddroom;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI.WinForms.GunaCircleButton btnMinimize;
        private System.Windows.Forms.FlowLayoutPanel movingPanel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private All_User_Control.UC_GuestRegistration uC_GuestRegistration1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private All_User_Control.UC_GuestCheckOut uC_GuestCheckOut1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private All_User_Control.UC_GuestDetails uC_CustomerDetails1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}