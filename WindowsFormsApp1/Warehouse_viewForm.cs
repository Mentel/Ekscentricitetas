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
    public partial class Warehouse_viewForm : MaterialForm
    {
        public int itemId;

        MaterialSkinManager materialSkinManager;
        public Warehouse_viewForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Prekės peržiūra";
        }

        private void Warehouse_viewForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Warehouse_viewForm_Closing);
            materialLabel2.Text = itemId.ToString();
        }

        private void Warehouse_viewForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }

        private void MaterialLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
