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
    public partial class Rent_addForm : MaterialForm
    {
        public SalesRentForm form;

        private readonly MaterialSkinManager materialSkinManager;

        public static Form LoginForm;

        public static int userID;
        public Rent_addForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Nauja nuomos sutartis";
        }

        private void Rent_addForm_Load(object sender, EventArgs e)
        {
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);

            var commandC = new MySqlCommand("SELECT * FROM klientas", con);
            var commandW = new MySqlCommand("SELECT * FROM is_vartotojas", con);
            var adapterC = new MySqlDataAdapter(commandC);
            var adapterW = new MySqlDataAdapter(commandW);
            var tableC = new DataTable();
            var tableW = new DataTable();
            adapterC.Fill(tableC);
            RentClientComboBox.DataSource = tableC;
            RentClientComboBox.DisplayMember = "vardas";
            RentClientComboBox.ValueMember = "id_Klientas";
            adapterW.Fill(tableW);
            RentWorkerComboBox.DataSource = tableW;
            RentWorkerComboBox.DisplayMember = "vardas";
            RentWorkerComboBox.ValueMember = "id";
        }

        private void RentAddConfirmButton_Click(object sender, EventArgs e)
        {
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();
            string date = DateTime.Now.ToString("s");
            date = date.Substring(0, 10);
            double price;
            double.TryParse(NewRentPriceLine.Text, out price);
            int client = RentClientComboBox.SelectedIndex +1;
            //int worker = RentWorkerComboBox.SelectedIndex +1;            
            int worker = RentWorkerComboBox.SelectedIndex +1;
            string sql = "INSERT INTO nuomos_sutartis(sudarymo_data, kaina, busena, fk_Klientasid, fk_ISVartotojas)" +
                           "VALUES('"+date+"',"+price+", 'neivykdyta', "+client+", "+worker+"); ";
            var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            form.Refresh_RentListView();
            this.Close();
        }

        private void RentAddWorkerLabel_Click(object sender, EventArgs e)
        {

        }

        private void RentClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
