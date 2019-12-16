using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class WarehouseForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public static Form LoginForm;

        public static int userID;
        public WarehouseForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Sandėlis";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Dispose();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(WarehouseForm_Closing);
        }

        private void WarehouseForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
            LoginForm.Close();
        }






        private void TabPage2_Click(object sender, EventArgs e)
        {

        }


        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton3_Click(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton6_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Dispose();
        }

        private void MaterialRaisedButton7_Click(object sender, EventArgs e)
        {
            Form accountManagement = new AccountManagementForm();
            accountManagement.Show();
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 1)
            {
                var orderaddForm = new Warehouse_orderaddForm();
                orderaddForm.itemId = Int32.Parse(materialListView1.SelectedItems[0].Text);
                orderaddForm.Show();
            }
        }

        private void MaterialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton4_Click(object sender, EventArgs e)
        {
                if (materialListView1.SelectedItems.Count == 1)
                {
                    var editForm = new Warehouse_editForm();
                    editForm.itemId = Int32.Parse(materialListView1.SelectedItems[0].Text);
                    editForm.Show();
                }
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 1)
            {
               
                var orderviewForm = new Warehouse_viewForm();
                orderviewForm.itemId = Int32.Parse(materialListView1.SelectedItems[0].Text);
                orderviewForm.Show();
            }
        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
