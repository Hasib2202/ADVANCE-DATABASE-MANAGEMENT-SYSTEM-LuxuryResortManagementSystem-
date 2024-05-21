using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUXURY_RESORT_MANAGEMENT_SYSTEM
{
    internal class function
    {
        protected OracleConnection GetConnection()
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "Data Source=localhost;User ID=adb;Password=54321";
            //con.Open();
            return con;
        }
        public DataSet getData(String query)
        {
            OracleConnection con = GetConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public void setData(String query, String message) 
        {
            OracleConnection con = GetConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("  '" +message+ "'  ","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        
        }

        public OracleDataReader getForCombo(String query)
        {
            OracleConnection con = GetConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new OracleCommand(query, con);
            OracleDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

    }
}
