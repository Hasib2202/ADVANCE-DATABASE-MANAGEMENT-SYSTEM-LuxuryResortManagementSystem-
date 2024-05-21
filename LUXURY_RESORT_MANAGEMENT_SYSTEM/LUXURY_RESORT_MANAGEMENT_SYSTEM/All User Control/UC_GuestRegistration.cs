using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control
{
    public partial class UC_GuestRegistration : UserControl
    {
        function fn = new function();
        String query;

        public UC_GuestRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            OracleDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for(int i = 0; i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoomSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
            
            query = "select room_no from rooms where trade_license = '" + txtTradeLicence.Text + "'  and r_size = '" + txtRoomSize.Text + "' and booked =  'NO'";
            setComboBox(query, txtRoomNumber);
        }
 
        private void txtTradeLicence_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomSize.SelectedIndex = -1;
            txtRoomNumber.Items.Clear ();
            txtPrice.Clear();

        }
        int rid;
        private void txtRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select r_price,roomid from rooms where room_no = '" + txtRoomNumber.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse (ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" &&  txtMobileNo.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" && txtIdProof.Text != "" && txtAddress.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                String name  = txtName.Text;
                String phone = txtMobileNo.Text;
                String national = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtIdProof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckIn.Text;


                // query = "insert into guests(name,phone,nationality,gender,dob,idproof,address,checkin,roomid)  values ('"+name+ "' , '"+phone+ "' , '"+national+ "', '"+gender+ "', '"+dob+ "', '"+idproof+ "', '"+address+ "', '"+checkin+"',"+rid+ ") update rooms set booked = 'YES' where room_no = '" + txtRoomNumber.Text + "'";
                ////fn.setData(query, "Room No " + txtRoomNumber.Text + " Allocation Successful.");

                // //query = "update rooms set booked = 'YES' where room_no = '" + txtRoomNumber.Text + "'";
                // fn.setData(query, "Room No " + txtRoomNumber.Text + " Allocation Successful.");


                // Insert the guest record
                query = "INSERT INTO guests(name, phone, nationality, gender, dob, idproof, address, checkin, roomid) VALUES ('" + name + "', '" + phone + "', '" + national + "', '" + gender + "', '" + dob + "', '" + idproof + "', '" + address + "', '" + checkin + "', " + rid + ")";
                fn.setData(query, "Room No " + txtRoomNumber.Text + " Allocation Successful.");

                // Update the booked status for the room
                query = "UPDATE rooms SET booked = 'YES' WHERE room_no = '" + txtRoomNumber.Text + "'";
                fn.setData(query, "Room No " + txtRoomNumber.Text + " Allocation Successful.");

                // Display success message
                //MessageBox.Show("Room No " + txtRoomNumber.Text + " Allocation Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                clearAll();

            }
            else
            {
                MessageBox.Show("All fields are mandatory.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void clearAll()
        {
            txtName.Clear();
            txtMobileNo.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIdProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtTradeLicence.SelectedIndex = -1;
            txtRoomSize.SelectedIndex = -1;
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();

        }

        private void UC_GuestRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
















        //private void label5_Click(object sender, EventArgs e)
        //{

        //}

        //private void label8_Click(object sender, EventArgs e)
        //{

        //}

        //private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
