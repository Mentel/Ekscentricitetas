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
    public partial class AdministratorForm : Form
    {
        public static Form LoginForm;

        public Form accountManagement = new AccountManagementForm();

        public static int userID = 0;
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(AdministratorForm_Closing);
            label2.Text = AdministratorForm.userID.ToString();
        }

        private void AdministratorForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            accountManagement.Dispose();
            this.Dispose();
            LoginForm.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            accountManagement.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form newAccount = new Registration();
            newAccount.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form newRole = new Administrator_changeRoleForm();
            newRole.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form deleteAccount = new Administrator_deleteForm();
            deleteAccount.Show();
        }
    }
}
