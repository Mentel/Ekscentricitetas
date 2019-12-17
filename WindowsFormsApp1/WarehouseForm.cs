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
using MySql.Data.MySqlClient;

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
            materialListView1.HideSelection = true;
            materialListView3.HideSelection = true;
            materialListView2.HideSelection = true;
            materialLabel4.Text = "";
            Refresh_materialListView1();
            Refresh_materialListView3();
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
            materialLabel3.Text = "";
            materialLabel4.Text = "";
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

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            string pavadinimas = materialSingleLineTextField1.Text;
            string aprasymas = materialSingleLineTextField2.Text;
            int kodas;
            if (Int32.TryParse(materialSingleLineTextField3.Text, out kodas) == false)
            {
                materialLabel3.Text = "Kodas turi būti skaičius";
                return;
            }
            double kaina;
            if (Double.TryParse(materialSingleLineTextField4.Text, out kaina) == false)
            {
                materialLabel3.Text = "Kaina turi būti skaičius";
                return;
            }
            kaina = Math.Round(kaina, 2);
            int kiekis;
            if (Int32.TryParse(materialSingleLineTextField5.Text, out kiekis) == false)
            {
                materialLabel3.Text = "Kiekis turi būti skaičius";
                return;
            }
            string bukle = materialSingleLineTextField6.Text;
            int pagaminimometai;
            if (Int32.TryParse(materialSingleLineTextField7.Text, out pagaminimometai) == false)
            {
                materialLabel3.Text = "Pagaminimo metai turi būti skaičius";
                return;
            }
            if (pagaminimometai > 2025 || pagaminimometai < 1970)
            {
                materialLabel3.Text = "Neteisingi metai";
                return;
            }
            int pagaminimomenuo;
            if (Int32.TryParse(materialSingleLineTextField8.Text, out pagaminimomenuo) == false)
            {
                materialLabel3.Text = "Pagaminimo mėnuo turi būti skaičius";
                return;
            }
            if (pagaminimomenuo > 12 || pagaminimomenuo < 0)
            {
                materialLabel3.Text = "Neteisingas mėnuo";
                return;
            }
            string parduodamas = materialCheckBox1.Checked.ToString();
            int sandelioid;
            if (materialListView3.SelectedItems.Count == 1)
            {
                sandelioid = Int32.Parse(materialListView3.SelectedItems[0].Text);
            }
            else
            {
                materialLabel3.Text = "Reikia pasirinkti sandėlį";
                return;
            }
            materialLabel3.Text = "";
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT COUNT(1) from daiktas WHERE kodas = " + kodas;
            var cmd = new MySqlCommand(sql, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) != 0)
            {
                materialLabel3.Text = "Jau yra daiktas su tokiu kodu";
                return;
            }
            rdr.Close();

            sql = "INSERT INTO daiktas(pavadinimas, aprasymas, kodas, kaina, parduodamas, kiekis, bukle, pagaminimo_data, fk_Sandelisid) " +
                "VALUES('" + pavadinimas + "', '" + aprasymas + "', " + kodas + ", " + kaina.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", " + parduodamas + ", " + kiekis + ", '" + bukle + "', '" + pagaminimometai.ToString() + "-" + pagaminimomenuo.ToString() + "-" + "0'" + ", " + sandelioid + ")";
            cmd = new MySqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            
            con.Close();
            Refresh_materialListView1();
            materialTabControl1.SelectedIndex = 0;
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_materialListView1()
        {
            materialListView1.Items.Clear();
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();
            string sql = "SELECT kodas, pavadinimas, kaina, kiekis, bukle, parduodamas, fk_Sandelisid FROM daiktas";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                string[] result = new string[7];
                result[0] = rdr.GetString(0);
                result[1] = rdr.GetString(1);
                result[2] = rdr.GetString(2);
                result[3] = rdr.GetString(3);
                result[4] = rdr.GetString(4);
                if (rdr.GetString(5) == "True")
                {
                    result[5] = "Taip";
                }
                else
                {
                    result[5] = "Ne";
                }
                result[6] = rdr.GetString(6);
                var item = new ListViewItem(result);
                materialListView1.Items.Add(item);
            }
            rdr.Close();
            con.Close();
        }
        private void Refresh_materialListView3()
        {
            materialListView3.Items.Clear();
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();
            string sql = "SELECT id_Sandelis, adresas, pasto_kodas, plotas FROM sandelis";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string[] result = new string[4];
                result[0] = rdr.GetString(0);
                result[1] = rdr.GetString(1);
                result[2] = rdr.GetString(2);
                result[3] = rdr.GetString(3);
                var item = new ListViewItem(result);
                materialListView3.Items.Add(item);
            }
            rdr.Close();
            con.Close();
        }
        private void MaterialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 1)
            {
                string id = materialListView1.SelectedItems[0].Text;
                string cs = Form1.connection;
                var con = new MySqlConnection(cs);
                con.Open();
                var sql = "DELETE FROM daiktas WHERE kodas = " + id;
                var cmd = new MySqlCommand(sql, con);

                try
                {
                    int numberOfDeleted = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    materialLabel4.Text = "Šio įrašo negalima pašalinti";
                }
                

                con.Close();
                Refresh_materialListView1();


            }
        }
    }
}
