﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDCOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(System.Object sender, System.EventArgs e)
        {
            serviceReference1.ServiceClient client = new serviceReference1.ServiceClient();
            string returnString;

            returnString = (string)client.GetData(textBox1.Text);
            label1.Text = returnString;
        }

    }
}
