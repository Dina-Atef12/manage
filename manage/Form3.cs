﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage 
{
    public partial class Deplist : Form
    {
        Functions con;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static DataTable DataSource { get; private set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public object Con { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Deplist()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            con = new Functions();
            ShowDepartments ();
        }

        private void ShowDepartments() 
        {
            throw new NotImplementedException(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ListerDepartments ()
        {
            string Query = " Select * from DepartmentTbl";
            Deplist.DataSource = con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e) 
        {
            try
            {
                if(DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData (Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void DepList_
    }
}
