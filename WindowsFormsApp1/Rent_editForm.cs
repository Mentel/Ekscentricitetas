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
    public partial class Rent_editForm : MaterialForm
    {
        public int itemId;
        public SalesRentForm form;
        private readonly MaterialSkinManager materialSkinManager;

        public static Form LoginForm;

        public static int userID;
        public Rent_editForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Nuomos sutarties redagavimas";
        }

        private void Rent_editForm_Load(object sender, EventArgs e)
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
            RentEditClientBox.DataSource = tableC;
            RentEditClientBox.DisplayMember = "vardas";
            RentEditClientBox.ValueMember = "id_Klientas";
            adapterW.Fill(tableW);
            RentEditWorkerBox.DataSource = tableW;
            RentEditWorkerBox.DisplayMember = "vardas";
            RentEditWorkerBox.ValueMember = "id";
            Fill_information();
        }

        private void Fill_information()
        {
            string cs = Form1.connection;
            var con = new MySqlConnection(cs);
            con.Open();
            string sql = "SELECT kaina, pastabos, grazinimo_data FROM nuomos_sutartis WHERE id_Nuomos_sutartis = "+itemId+";";

            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            RentEditPrice.Text = rdr.GetString(0);
            if (!rdr.IsDBNull(1))
            {
                RentEditPastabos.Text = rdr.GetString(1);
            }
            if (!rdr.IsDBNull(2))
            {
                RentEditBackDate.Text = rdr.GetString(2);
            }

            rdr.Close();
            con.Close();
        }

        private void RentEditConfirmButton_Click(object sender, EventArgs e)
        {
            int client = RentEditClientBox.SelectedIndex + 1;
            int worker = RentEditWorkerBox.SelectedIndex + 1;
            double price = -1;
            Double.TryParse(RentEditPrice.Text, out price);
            string pastaba = RentEditPastabos.Text; 
            string data = RentEditBackDate.Text;

            string cs = Form1.connection;
            var con = new MySqlConnection(cs);
            con.Open();

            string sql ="UPDATE nuomos_sutartis SET kaina = "+price+", fk_Klientasid = "+client+", fk_ISVartotojas = "+worker;

            if (pastaba != "")
                sql += ", pastabos = '" + pastaba +"'";

            if (data != "")
                sql += ", grazinimo_data = " + data;

            sql += " WHERE id_Nuomos_sutartis = "+itemId+";";

            var cmd = new MySqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            form.Refresh_RentListView();
            this.Close();
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
