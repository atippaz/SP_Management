﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Management
{
    public partial class SPM : Form
    {

        public SPM()
        {
            InitializeComponent();
           
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

      

        private void SPM_Load(object sender, EventArgs e)
        {
            if (Route.isStartUp)
            {
                Route.isStartUp = false;
                Route.index.Hide();
            }
        }
        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            Toast.Success("Logout Success");
            Route.CreateLoginPage(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPMs pMs = new SPMs();
            pMs.Show();
            this.Hide();
        }
    }
}
