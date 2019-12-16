using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Administrator_registerForm : Form
    {
        public Administrator_registerForm()
        {
            InitializeComponent();
        }

        private void Administrator_registerForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Administrator_registerForm_Closing);
        }

        private void Administrator_registerForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }
    }
}
