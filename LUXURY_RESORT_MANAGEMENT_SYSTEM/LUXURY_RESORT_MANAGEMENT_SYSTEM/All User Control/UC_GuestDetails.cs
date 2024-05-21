using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUXURY_RESORT_MANAGEMENT_SYSTEM.All_User_Control
{
    public partial class UC_GuestDetails : UserControl
    {
        function fn = new function();
        String query;

        public UC_GuestDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex == 0)
            {
                query = "select guests.gid, guests.name,guests.phone, guests.nationality,guests.gender,guests.dob,guests.idproof,guests.address,guests.checkin,guests.checkout,rooms.room_no,rooms.r_size,rooms.trade_license,rooms.r_price from guests inner join rooms on guests.roomid = rooms.roomid";
                getRecord(query);
            }
            else if(txtSearchBy.SelectedIndex == 1)
            {
                query = "select guests.gid, guests.name,guests.phone, guests.nationality,guests.gender,guests.dob,guests.idproof,guests.address,guests.checkin,guests.checkout,rooms.room_no,rooms.r_size,rooms.trade_license,rooms.r_price from guests inner join rooms on guests.roomid = rooms.roomid where checkout is null";
                getRecord(query);
            }
            else if( txtSearchBy.SelectedIndex == 2)
            {
                query = "select guests.gid, guests.name,guests.phone, guests.nationality,guests.gender,guests.dob,guests.idproof,guests.address,guests.checkin,guests.checkout,rooms.room_no,rooms.r_size,rooms.trade_license,rooms.r_price from guests inner join rooms on guests.roomid = rooms.roomid where checkout is not null";
                getRecord(query);
            }
                    
        }

        private void getRecord(String query)
        {
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }


    }
}
