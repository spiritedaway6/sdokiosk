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
    public partial class UserControl4 : UserControl
    {
        private static UserControl4 _instance;
        public static UserControl4 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl4();
                }
                if (_instance.IsDisposed)
                {
                    _instance = new UserControl4();
                }

                return _instance;
            }
        }

        public UserControl4()
        {
            InitializeComponent();
        }
    }
}
