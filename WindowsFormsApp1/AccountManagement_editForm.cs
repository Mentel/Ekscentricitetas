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
    public partial class AccountManagement_editForm : Form
    {
        public AccountManagement_editForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void AccountManagement_editForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(AccountManagement_editForm_Closing);
        }

        private void AccountManagement_editForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }
    }
}
