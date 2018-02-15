using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
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

        private void Form1_Load(object sender, EventArgs e)
        {
            showUserControlA();
        }

        private void showUserControlA()
        {
            //  panelContainer.Controls.Clear();

            if (!homepanel.Controls.Contains(UserControl1.Instance))
            {
                homepanel.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
            {
                UserControl1.Instance.BringToFront();
            }
        }

        private void showUserControlB()
        {
            // panelContainer.Controls.Clear();

            if (!homepanel.Controls.Contains(UserControl2.Instance))
            {
                homepanel.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();
            }
            else
            {
                UserControl2.Instance.BringToFront();
            }
        }

        private void showUserControlC()
        {
            // panelContainer.Controls.Clear();

            if (!homepanel.Controls.Contains(UserControl3.Instance))
            {
                homepanel.Controls.Add(UserControl3.Instance);
                UserControl3.Instance.Dock = DockStyle.Fill;
                UserControl3.Instance.BringToFront();
            }
            else
            {
                UserControl3.Instance.BringToFront();
            }
        }

        private void showUserControlD()
        {
            // panelContainer.Controls.Clear();

            if (!homepanel.Controls.Contains(UserControl4.Instance))
            {
                homepanel.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();
            }
            else
            {
                UserControl4.Instance.BringToFront();
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            showUserControlA();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            showUserControlB();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            showUserControlC();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            showUserControlD();
        }
    }
}
