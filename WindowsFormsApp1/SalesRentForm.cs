﻿using System;
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
            Refresh_materialListView1();
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
                "is_vartotojas.pavarde FROM pardavimo_sutartis INNER JOIN klientas ON pardavimo_sutartis.fk_Klientasid = klientas.id_Klientas " +
                "INNER JOIN is_vartotojas ON pardavimo_sutartis.fk_ISvartotojas = is_vartotojas.id";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string[] result = new string[6];

                result[0] = rdr.GetString(0);
                result[1] = rdr.GetString(1) + " " + rdr.GetString(2);
                result[2] = rdr.GetString(3);
                result[3] = rdr.GetString(4);
                result[4] = rdr.GetString(5).Split()[0];
                result[5] = rdr.GetString(6) + " " + rdr.GetString(7);

                var item = new ListViewItem(result);
                materialListView1.Items.Add(item);
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
    }
}
