using Oracle.ManagedDataAccess.Client;
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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
        private OracleConnection GetConnection()
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "data source=ORCL;user id=newuser;password=12345";
            return con;
        }

        //private void btnAddRoom_Click(object sender, EventArgs e)
        //{
        //    if (txtRoomNumber.Text != "" && txtSize.Text != "" && txtPrice.Text != "" && txtTradeLicence.Text != "")
        //    {
        //        String roomno = txtRoomNumber.Text;
        //        String size = txtSize.Text;
        //        Int64 price = Int64.Parse(txtPrice.Text);
        //        String tradeLicence = txtTradeLicence.Text;

        //        query = "insert into rooms (room_no,r_size,r_price,trade_license) values ('" + roomno + "','" + size + "'," + price + ",'" + tradeLicence + "')";

        //        fn.setData(query, "Room Added");

        //        UC_AddRoom_Load(this, null);
        //        clearAll();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Fill all fields.", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}


        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNumber.Text != "" && txtSize.Text != "" && txtPrice.Text != "" && txtTradeLicence.Text != "")
                {
                    String roomno = txtRoomNumber.Text;
                    String size = txtSize.Text;
                    Int64 price = Int64.Parse(txtPrice.Text);
                    String tradeLicence = txtTradeLicence.Text;

                    query = "INSERT INTO rooms (room_no, r_size, r_price, trade_license) VALUES ('" + roomno + "', '" + size + "', " + price + ", '" + tradeLicence + "')";

                    fn.setData(query, "Room Added");

                    UC_AddRoom_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Fill all fields.", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred.Please enter valid price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtSize.SelectedIndex = -1;
            txtPrice.Clear();
            txtTradeLicence.SelectedIndex = -1;

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();    
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
