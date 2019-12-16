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
    public partial class AccountManagementForm : Form
    {
        public AccountManagementForm()
        {
            InitializeComponent();
        }

        private void AccountManagementForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(AccountManagementForm_Closing);
        }

        private void AccountManagementForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form accountinfo = new AccountManagement_infoForm();
            accountinfo.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form accountedit = new AccountManagement_editForm();
            accountedit.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form accountpassword = new AccountManagement_passwordupdateForm();
            accountpassword.Show();
        }
    }
}
