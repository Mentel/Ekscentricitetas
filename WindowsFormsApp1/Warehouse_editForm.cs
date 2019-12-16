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
    public partial class Warehouse_editForm : MaterialForm
    {
        public int itemId;
        
        MaterialSkinManager materialSkinManager;
        public Warehouse_editForm()
        {
            InitializeComponent();
        }

        private void Warehouse_editForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Warehouse_editForm_Closing);
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Daikto redagavimas";
            materialSingleLineTextField3.Text = itemId.ToString();
            materialSingleLineTextField3.Enabled = false;
        }

        private void Warehouse_editForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }
    }
}
