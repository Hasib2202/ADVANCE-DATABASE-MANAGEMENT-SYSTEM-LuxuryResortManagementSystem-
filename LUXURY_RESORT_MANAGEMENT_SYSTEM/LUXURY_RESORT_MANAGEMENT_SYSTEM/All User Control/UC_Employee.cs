using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
          

        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(staff_id) from staff";
            DataSet ds = fn.getData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                object result = ds.Tables[0].Rows[0][0];
                if (result != DBNull.Value)
                {
                    if (Int64.TryParse(result.ToString(), out Int64 num))
                    {
                        labelToSET.Text = (num + 1).ToString();
                    }
                    else
                    {
                        // Handle parsing error
                        labelToSET.Text = "Error: Invalid staff_id format";
                    }
                }
                else
                {
                    // Handle null value
                    labelToSET.Text = "Error: No staff_id found";
                }
            }
            else
            {
                // Handle empty DataSet
                labelToSET.Text = "Error: No data available";
            }
        }

        //public void getMaxID()
        //{
        //    query = "select max(staff_id) from staff";
        //    DataSet ds = fn.getData(query);

        //    if (ds.Tables[0].Rows[0][0].ToString() != "")
        //    {
        //        Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
        //        labelToSET.Text = (num + 1).ToString();
        //    }
        //}

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String  name = txtName.Text;
                String phone = txtPhone.Text;
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String password = txtPassword.Text;

                query = "insert into staff (s_name,s_phone,s_gender,s_emailid,s_username,s_pass) values('"+name+"','"+phone+"','"+gender+"','"+email+"','"+username+"','"+password+"')";
                fn.setData(query, "Staff Registered");
                clearAll();
                getMaxID();
               
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Warning...!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(tabControl1.SelectedIndex == 1)
             {
                query = "select * from staff ";
                DataSet ds = fn.getData(query);
                gunaDataGridView1.DataSource = ds.Tables[0];

             }
             else if(tabControl1.SelectedIndex == 2)
            {
                query = "select * from staff ";
                DataSet ds = fn.getData(query);
                gunaDataGridView2.DataSource = ds.Tables[0];
            }

        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (txtID.Text != "")
        //    {
        //        if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            query = "delete from staff where staff_id = " + txtID.Text + " ";
        //            fn.setData(query, "Record Deleted.");
        //            tabControl1_SelectedIndexChanged(this, null);
        //        }
        //    }
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtID.Text != "")
        //        {
        //            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //            {
        //                query = "DELETE FROM staff WHERE staff_id = " + txtID.Text + " ";
        //                fn.setData(query, "Record Deleted.");
        //                tabControl1_SelectedIndexChanged(this, null);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the exception
        //        MessageBox.Show("An error occurred.Please enter valid id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    int staffId;
                    if (int.TryParse(txtID.Text, out staffId))
                    {
                        // Check if the staff_id exists in the database
                        string query = "SELECT COUNT(*) FROM staff WHERE staff_id = " + staffId;
                        DataSet ds = fn.getData(query);

                        // Retrieve the count value from the DataSet
                        int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                        if (count > 0)
                        {
                            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                query = "DELETE FROM staff WHERE staff_id = " + staffId;
                                fn.setData(query, "Record Deleted.");
                                tabControl1_SelectedIndexChanged(this, null);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Staff With ID : '"+txtID.Text+"'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Staff ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
