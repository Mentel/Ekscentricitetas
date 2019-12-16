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
    public partial class Administrator_deleteForm : Form
    {
        public Administrator_deleteForm()
        {
            InitializeComponent();
        }

        private void Administrator_deleteForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Administrator_deleteForm_Closing);
        }

        private void Administrator_deleteForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }


    }
}
