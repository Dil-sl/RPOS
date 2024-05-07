using Dine360.View.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dine360.View.Login
{
    public partial class formLogin : Form
    {
        private static formLogin _instance;
        public formLogin()
        {
            InitializeComponent();
        }
        public static formLogin useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formLogin();
                return _instance;
            }
        }
    }
}
