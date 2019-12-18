using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class SalesRentForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public static Form LoginForm;
        public static int userID;
        public SalesRentForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Pardavimų ir nuomos valdymas";
        }

        private void SalesRentForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(SalesRentForm_Closing);
            materialListView1.HideSelection = true;
<<<<<<< Updated upstream
            materialLabel1.Text = "";
=======
            RentListView.HideSelection = true;
>>>>>>> Stashed changes
            Refresh_materialListView1();
            Refresh_RentListView();
        }

        public void Refresh_materialListView1()
        {
            materialListView1.Items.Clear();
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();
            string sql = "SELECT pardavimo_sutartis.id_Pardavimo_sutartis, klientas.vardas, klientas.pavarde, pardavimo_sutartis.kaina, " +
                "(SELECT SUM(daikto_kiekis_pardavimas.kiekis) FROM daikto_kiekis_pardavimas WHERE fk_Pardavimo_sutartisid = " +
                "pardavimo_sutartis.id_Pardavimo_sutartis) AS prekiu_kiekis, pardavimo_sutartis.sudarymo_data, is_vartotojas.vardas, " +
                "is_vartotojas.pavarde, pardavimo_sutartis.busena FROM pardavimo_sutartis INNER JOIN klientas ON pardavimo_sutartis.fk_Klientasid = " +
                "klientas.id_Klientas INNER JOIN is_vartotojas ON pardavimo_sutartis.fk_ISvartotojas = is_vartotojas.id WHERE " +
                "pardavimo_sutartis.busena != 'istrinta'";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string[] result = new string[7];

                result[0] = rdr.GetString(0);
                result[1] = rdr.GetString(1) + " " + rdr.GetString(2);
                result[2] = rdr.GetString(3);
                if (!rdr.IsDBNull(4))
                {
                    result[3] = rdr.GetString(4);
                }
                else
                {
                    result[3] = "0";
                }
                result[4] = rdr.GetString(5).Split()[0];
                result[5] = rdr.GetString(6) + " " + rdr.GetString(7);
                result[6] = rdr.GetString(8);

                var item = new ListViewItem(result);
                materialListView1.Items.Add(item);
            }
            rdr.Close();
            con.Close();
        }


        public void Refresh_RentListView()
        {
            RentListView.Items.Clear();
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();
            string sql = "SELECT nuomos_sutartis.id_Nuomos_sutartis, nuomos_sutartis.busena, klientas.vardas, klientas.pavarde, is_vartotojas.vardas, is_vartotojas.pavarde, nuomos_sutartis.kaina," +
                " nuomos_sutartis.sudarymo_data, nuomos_sutartis.grazinimo_data, nuomos_sutartis.pastabos FROM nuomos_sutartis INNER JOIN klientas ON " +
                "nuomos_sutartis.fk_Klientasid = klientas.id_Klientas INNER JOIN is_vartotojas ON nuomos_sutartis.fk_ISvartotojas = is_vartotojas.id";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string[] result = new string[8];

                result[0] = rdr.GetString(0);
                result[1] = rdr.GetString(1);
                result[2] = rdr.GetString(2) + " " + rdr.GetString(3);
                result[3] = rdr.GetString(4) + " " + rdr.GetString(5);
                result[4] = rdr.GetString(6);
                result[5] = rdr.GetString(7);
                if (!rdr.IsDBNull(8))
                {
                    result[6] = rdr.GetString(8);
                }
                if (!rdr.IsDBNull(9))
                {
                    result[7] = rdr.GetString(9);
                }

                var item = new ListViewItem(result);
                RentListView.Items.Add(item);
            }
            rdr.Close();
            con.Close();
        }

        private void SalesRentForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Dispose();
            LoginForm.Close();
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void materialListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

<<<<<<< Updated upstream
        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (materialListView1.SelectedItems.Count == 1)
            {
                string id = materialListView1.SelectedItems[0].Text;
                string cs = Form1.connection;
                var con = new MySqlConnection(cs);
                con.Open();
                var sql = "UPDATE pardavimo_sutartis SET busena = 'istrinta' WHERE id_Pardavimo_sutartis = " + id;
=======
        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void RentLogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Dispose();
        }

        private void AccountManagementButton_Click(object sender, EventArgs e)
        {
            Form accountManagement = new AccountManagementForm();
            accountManagement.Show();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string dateFrom = RentDateFrom.Text;
            string dateTo = RentDateTo.Text;
            string priceFrom = RentPriceFrom.Text;
            string priceTo = RentPriceTo.Text;

            DateTime dateF;
            DateTime dateT;
            double priceF;
            double priceT;
            double.TryParse(RentPriceFrom.Text, out priceF);
            double.TryParse(RentPriceTo.Text, out priceT);
            DateTime.TryParse(RentDateFrom.Text, out dateF);
            DateTime.TryParse(RentDateTo.Text, out dateT);
            int numberOf = 0;


            if (dateFrom == "Data nuo" && dateTo == "Data iki" && priceFrom == "Kaina nuo" && priceTo == "Kaina iki")
            {
                Refresh_RentListView();
                return;
            }

            RentListView.Items.Clear();
            string cs = Form1.connection;

            var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT nuomos_sutartis.id_Nuomos_sutartis, nuomos_sutartis.busena, klientas.vardas, klientas.pavarde, is_vartotojas.vardas, is_vartotojas.pavarde, nuomos_sutartis.kaina," +
                " nuomos_sutartis.sudarymo_data, nuomos_sutartis.grazinimo_data, nuomos_sutartis.pastabos FROM nuomos_sutartis INNER JOIN klientas ON " +
                "nuomos_sutartis.fk_Klientasid = klientas.id_Klientas INNER JOIN is_vartotojas ON nuomos_sutartis.fk_ISvartotojas = is_vartotojas.id" +
                " WHERE ";

            if (priceFrom != "Kaina nuo" || priceFrom != "")
            {
                sql += "nuomos_sutartis.kaina >= " + priceF;
                numberOf++;
            }

            if (priceTo != "Kaina iki" || priceTo != "")
            {
                if (numberOf != 0)
                    sql += " AND nuomos_sutartis.kaina <= " + priceT;
                else
                    sql += "nuomos_sutartis.kaina <= " + priceT;
                numberOf++;
            }

            if (dateFrom != "Data nuo" || dateFrom != "")
            {
                if (numberOf != 0)
                    sql += " AND nuomos_sutartis.sudarymo_data >= " + dateF;
                else
                    sql += "nuomos_sutartis.sudarymo_data >= " + dateF;
                numberOf++;
            }

            if (dateTo != "Data iki" || dateTo != "")
            {
                if (numberOf != 0)
                    sql += " AND nuomos_sutartis.sudarymo_data <= " + dateT;
                else
                    sql += "nuomos_sutartis.sudarymo_data <= " + dateT;
            }


            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string[] result = new string[8];

                result[0] = rdr.GetString(0);
                result[1] = rdr.GetString(1);
                result[2] = rdr.GetString(2) + " " + rdr.GetString(3);
                result[3] = rdr.GetString(4) + " " + rdr.GetString(5);
                result[4] = rdr.GetString(6);
                result[5] = rdr.GetString(7);
                if (!rdr.IsDBNull(8))
                {
                    result[6] = rdr.GetString(8);
                }
                result[7] = rdr.GetString(9);

                var item = new ListViewItem(result);
                RentListView.Items.Add(item);
            }
            rdr.Close();
            con.Close();

        }

        private void RentRemoveButton_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (RentListView.SelectedItems.Count == 1)
            {
                string id = RentListView.SelectedItems[0].Text;
                string cs = Form1.connection;
                var con = new MySqlConnection(cs);
                con.Open();
                var sql = "DELETE FROM nuomos_sutartis WHERE id_Nuomos_sutartis = " + id;
>>>>>>> Stashed changes
                var cmd = new MySqlCommand(sql, con);

                try
                {
                    int numberOfDeleted = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
<<<<<<< Updated upstream
                    materialLabel1.Text = "Nepavyko pašalinti įrašo";
=======
                    RentActionLabel2.Text = "Šio įrašo negalima pašalinti";
>>>>>>> Stashed changes
                    error = 1;
                }
                if (error == 0)
                {
<<<<<<< Updated upstream
                    materialLabel1.Text = "Įrašas pašalintas sėkmingai";
                }

                con.Close();
                Refresh_materialListView1();
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (materialListView1.SelectedItems.Count == 1)
            {
                string id = materialListView1.SelectedItems[0].Text;
                string cs = Form1.connection;
                var con = new MySqlConnection(cs);
                con.Open();
                var sql = "UPDATE pardavimo_sutartis SET busena = 'ivykdyta' WHERE id_Pardavimo_sutartis = " + id;
=======
                    RentActionLabel2.Text = "";
                }

                con.Close();
                Refresh_RentListView();
            }
        }

        private void RentListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RentConfirmButton_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (RentListView.SelectedItems.Count == 1)
            {
                string id = RentListView.SelectedItems[0].Text;
                string cs = Form1.connection;
                var con = new MySqlConnection(cs);
                con.Open();
                var sql = "UPDATE nuomos_sutartis SET busena = 'ivykdyta' WHERE id_Nuomos_sutartis = " + id;
>>>>>>> Stashed changes
                var cmd = new MySqlCommand(sql, con);

                try
                {
                    int numberOfDeleted = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
<<<<<<< Updated upstream
                    materialLabel1.Text = "Nepavyko patvirtinti įrašo";
=======
                    RentActionLabel2.Text = "Šio įrašo negalima pašalinti";
>>>>>>> Stashed changes
                    error = 1;
                }
                if (error == 0)
                {
<<<<<<< Updated upstream
                    materialLabel1.Text = "Įrašas patvirtintas";
                }

                con.Close();
                Refresh_materialListView1();
            }
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Dispose();
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            Form accountManagement = new AccountManagementForm();
            accountManagement.Show();
        }

        private void salesAddForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            materialLabel1.Text = "Sutartis sudaryta, bet nepatvirtinta";
            Refresh_materialListView1();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Form salesAddForm = new SalesAddForm();
            salesAddForm.FormClosing += new FormClosingEventHandler(salesAddForm_Closing);
            salesAddForm.Show();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {

=======
                    RentActionLabel2.Text = "";
                }

                con.Close();
                Refresh_RentListView();

            }

        }

        private void RentReportButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RentCreateButton_Click(object sender, EventArgs e)
        {
            var RentAddForm = new Rent_addForm();
            RentAddForm.form = this;
            RentAddForm.Show();
        }

        private void RentEditButton_Click(object sender, EventArgs e)
        {
            var RenteditForm = new Rent_editForm();
            RenteditForm.itemId = Int32.Parse(RentListView.SelectedItems[0].Text);
            RenteditForm.form = this;
            RenteditForm.Show();
>>>>>>> Stashed changes
        }
    }
}
