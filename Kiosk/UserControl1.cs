using System;
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
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _instance;
        public static UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl1();
                }
                if (_instance.IsDisposed)
                {
                    _instance = new UserControl1();
                }

                return _instance;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
