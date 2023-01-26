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
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Functions()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
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
