﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class UserControl3 : UserControl
    {

       

        private static UserControl3 _instance;
        public static UserControl3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl3();
                }
                if (_instance.IsDisposed)
                {
                    _instance = new UserControl3();
                }

                return _instance;
            }
        }

        public UserControl3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            keyboardControl1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void keyboardControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
