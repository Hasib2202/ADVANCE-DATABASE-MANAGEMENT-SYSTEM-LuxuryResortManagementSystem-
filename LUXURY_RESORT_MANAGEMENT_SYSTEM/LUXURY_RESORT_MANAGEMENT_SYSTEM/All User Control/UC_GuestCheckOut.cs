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
    public partial class UC_GuestCheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_GuestCheckOut()
        {
            InitializeComponent();
        }

        private void UC_GuestCheckOut_Load(object sender, EventArgs e)
        {
            query = "select guests.gid,guests.name,guests.phone,guests.nationality,guests.gender,guests.dob,guests.idproof,guests.address,guests.checkin,rooms.room_no,rooms.r_size,rooms.trade_license,rooms.r_price from guests inner join rooms on guests.roomid = rooms.roomid where chkcout= 'NO'";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
           

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select guests.gid,guests.name,guests.phone,guests.nationality,guests.gender,guests.dob,guests.idproof,guests.address,guests.checkin,rooms.room_no,rooms.r_size,rooms.trade_license,rooms.r_price from guests inner join rooms on guests.roomid = rooms.roomid where name like '" + txtName.Text + "%' and chkcout = 'NO'";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }


        int id;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && gunaDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                TxtCName.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNo.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
        }

        //private void btnCheckOut_Click(object sender, EventArgs e)
        //{
        //    if(TxtCName.Text != "")
        //    {
        //        if(MessageBox.Show("Are You Sure", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
        //        {
        //            String cdate = txtCheckOut.Text;
        //            query = "update guests set chkcout = 'YES',checkout = '" + cdate + "' where gid = " + id + "";
        //            fn.setData(query, "Check Out Successful");
        //            query = "update rooms set booked = 'NO' where room_no = '" + txtRoomNo.Text + "'";
        //            fn.setData(query, "Check Out Successful");
        //            UC_GuestCheckOut_Load(this, null);
        //            clearAll();


        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No Guests Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (TxtCName.Text != "")
            {
                if (MessageBox.Show("Are You Sure", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOut.Text;
                        // Update the guests table
                        
                    query = "UPDATE guests SET chkcout = 'YES', checkout = '" + cdate + "' WHERE gid = " + id + "";
                        
                    fn.setData(query, "Check Out Successful");
                    

                    // Update the rooms table
                    query = "UPDATE rooms SET booked = 'NO' WHERE room_no = '" + txtRoomNo.Text + "'";
                    fn.setData(query, "Check Out Successful");

                    // Refresh the data grid view
                    UC_GuestCheckOut_Load(this, null);
                    

                    // Clear the text fields
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Guests Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            TxtCName.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
            txtCheckOut.ResetText();

        }

        private void UC_GuestCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_GuestCheckOut_Enter(object sender, EventArgs e)
        {
            UC_GuestCheckOut_Load(this, null);
        }

        private void gunaDataGridView1_Enter(object sender, EventArgs e)
        {
            UC_GuestCheckOut_Load(this, null);
        }

        //private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    UC_GuestCheckOut_Load(this, null);
        //}
    }
}
