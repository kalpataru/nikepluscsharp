using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Overpass.NikePlusAPI.Model;

namespace Overpass.NikePlusAPI.ClientDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            NikePlus nikePlus = new NikePlus();
            INikePlusData api = nikePlus.GetAPI(txtUsername.Text, txtPassword.Text);


            api.Login();
            

            userDetailsBindingSource.DataSource = api.getUserDetails();

            List<IRun> runs = api.getRuns();
           

           
            //iRunBindingSource.DataSource;
           dataGridView2.DataSource = runs;
            DataGridViewColumn mileColumn = new DataGridViewColumn(dataGridView2.Columns[0].CellTemplate);
            
            
            dataGridView2.Columns.Add(mileColumn);
            dataGridView2.Refresh();
           
            
        }

        private void iRunBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
