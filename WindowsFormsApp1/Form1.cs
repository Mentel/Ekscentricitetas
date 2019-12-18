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
    public partial class Form1 : MaterialForm
    {
        public static string connection = @"server=localhost;userid=root;password=;database=itproject";
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Prisijungimas";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_Closing);

            //------------------------------------
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();
            string sql = "SELECT * FROM sandelis";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            string result = "";
            while (rdr.Read())
            {
                result += rdr.GetString(0) + " " + rdr.GetString(1) + " " + rdr.GetDouble(2) + " " + rdr.GetString(3) + " " + rdr.GetString(4) + " " + rdr.GetInt32(5) + "\n";
            }

                label1.Text = result;
            rdr.Close();
            con.Close();
            //---------------------------------------
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                Hide();
                Form x;
                int id = 1;
                switch (comboBox1.Text)
                {
                    case "Administratorius":
                        x = new AdministratorForm();
                        AdministratorForm.LoginForm = this;
                        AdministratorForm.userID = id;
                        x.Show();
                        break;
                    case "Sandėlininkas":
                        x = new WarehouseForm();
                        WarehouseForm.LoginForm = this;
                        WarehouseForm.userID = id;
                        x.Show();
                        break;
                    case "Taisytojas":
                        x = new RepairForm();
                        RepairForm.LoginForm = this;
                        RepairForm.userID = id;
                        x.Show();
                        break;
                    case "Pardavėjas":
                        x = new SalesRentForm();
                        SalesRentForm.LoginForm = this;
                        SalesRentForm.userID = id;
                        x.Show();
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
