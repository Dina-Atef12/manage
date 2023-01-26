using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage
{
    internal class Functions

    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;
        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AGYAL\OneDrive\Documents\EmpDb.mdf;Integrated Security=True;Connect Timeout=30"
            Con = new SqlConnection (ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;

        }

        public object Constr { get; private set; }

        public DataTable GetData (string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter (Query, Constr);
            sda.Fill (dt);
            return dt;
        } 
        public int SetData(string Query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState .Closed)
            {
                Con.Open ();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery ();
            return cnt;
        }
    }
}
