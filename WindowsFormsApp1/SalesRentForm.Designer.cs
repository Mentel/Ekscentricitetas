namespace WindowsFormsApp1
{
    partial class SalesRentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
<<<<<<< Updated upstream
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
=======
>>>>>>> Stashed changes
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
<<<<<<< Updated upstream
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
=======
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RentActionLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.RentActionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RentPriceTo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RentPriceFrom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RentDateTo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RentDateFrom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SearchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentLogOutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AccountManagementButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentReportButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentConfirmButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentRemoveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentEditButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentCreateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentListView = new MaterialSkin.Controls.MaterialListView();
            this.id_Nuomos_sutartis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fk_Klientasid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fk_ISVartotojas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kaina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sudarymo_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grazinimo_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pastabos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
>>>>>>> Stashed changes
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 52);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(900, 42);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 100);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(900, 486);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialSingleLineTextField5);
            this.tabPage1.Controls.Add(this.materialRaisedButton8);
            this.tabPage1.Controls.Add(this.materialRaisedButton7);
            this.tabPage1.Controls.Add(this.materialRaisedButton6);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialRaisedButton5);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField4);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField3);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage1.Controls.Add(this.materialRaisedButton4);
            this.tabPage1.Controls.Add(this.materialRaisedButton3);
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.materialListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(892, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pardavimai";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
<<<<<<< Updated upstream
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(990, 154);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(172, 28);
            this.materialSingleLineTextField5.TabIndex = 14;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.Text = "Būsena";
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton8
            // 
=======
            // materialRaisedButton8
            // 
>>>>>>> Stashed changes
            this.materialRaisedButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButton8.AutoSize = true;
            this.materialRaisedButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton8.Location = new System.Drawing.Point(766, 524);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(188, 36);
=======
            this.materialRaisedButton8.Location = new System.Drawing.Point(574, 419);
            this.materialRaisedButton8.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(154, 36);
>>>>>>> Stashed changes
            this.materialRaisedButton8.TabIndex = 13;
            this.materialRaisedButton8.Text = "Sukurti ataskaitą";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton7.AutoSize = true;
            this.materialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton7.Location = new System.Drawing.Point(979, 482);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(204, 36);
            this.materialRaisedButton7.TabIndex = 12;
            this.materialRaisedButton7.Text = "Paskyros valdymas";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
=======
            this.materialRaisedButton7.Location = new System.Drawing.Point(692, 385);
            this.materialRaisedButton7.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(166, 36);
            this.materialRaisedButton7.TabIndex = 12;
            this.materialRaisedButton7.Text = "Paskyros valdymas";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton6.AutoSize = true;
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton6.Location = new System.Drawing.Point(1026, 524);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(119, 36);
            this.materialRaisedButton6.TabIndex = 11;
            this.materialRaisedButton6.Text = "Atsijungti";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
=======
            this.materialRaisedButton6.Location = new System.Drawing.Point(746, 419);
            this.materialRaisedButton6.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(98, 36);
            this.materialRaisedButton6.TabIndex = 11;
            this.materialRaisedButton6.Text = "Atsijungti";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
<<<<<<< Updated upstream
            this.materialLabel1.Location = new System.Drawing.Point(12, 488);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 24);
=======
            this.materialLabel1.Location = new System.Drawing.Point(9, 396);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 19);
>>>>>>> Stashed changes
            this.materialLabel1.TabIndex = 10;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton5.Location = new System.Drawing.Point(1036, 198);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(85, 36);
            this.materialRaisedButton5.TabIndex = 9;
            this.materialRaisedButton5.Text = "Ieškoti";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
=======
            this.materialRaisedButton5.Location = new System.Drawing.Point(759, 129);
            this.materialRaisedButton5.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(71, 36);
            this.materialRaisedButton5.TabIndex = 9;
            this.materialRaisedButton5.Text = "Ieškoti";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
<<<<<<< Updated upstream
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(990, 120);
=======
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(742, 98);
            this.materialSingleLineTextField4.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
<<<<<<< Updated upstream
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(172, 28);
=======
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(129, 23);
>>>>>>> Stashed changes
            this.materialSingleLineTextField4.TabIndex = 8;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.Text = "Data iki";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
<<<<<<< Updated upstream
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(990, 86);
=======
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(742, 70);
            this.materialSingleLineTextField3.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
<<<<<<< Updated upstream
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(172, 28);
=======
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(129, 23);
>>>>>>> Stashed changes
            this.materialSingleLineTextField3.TabIndex = 7;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.Text = "Data nuo";
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
<<<<<<< Updated upstream
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(990, 52);
=======
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(742, 42);
            this.materialSingleLineTextField2.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
<<<<<<< Updated upstream
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(172, 28);
=======
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(129, 23);
>>>>>>> Stashed changes
            this.materialSingleLineTextField2.TabIndex = 6;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "Kaina iki";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
<<<<<<< Updated upstream
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(990, 18);
=======
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(742, 15);
            this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> Stashed changes
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
<<<<<<< Updated upstream
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(173, 28);
=======
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(130, 23);
>>>>>>> Stashed changes
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "Kaina nuo";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton4.Location = new System.Drawing.Point(579, 524);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(181, 36);
            this.materialRaisedButton4.TabIndex = 4;
            this.materialRaisedButton4.Text = "Pašalinti sutartį";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
=======
            this.materialRaisedButton4.Location = new System.Drawing.Point(434, 419);
            this.materialRaisedButton4.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(148, 36);
            this.materialRaisedButton4.TabIndex = 4;
            this.materialRaisedButton4.Text = "Pašalinti sutartį";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton3.Location = new System.Drawing.Point(374, 524);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(198, 36);
            this.materialRaisedButton3.TabIndex = 3;
            this.materialRaisedButton3.Text = "Patvirtinti sutartį";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
=======
            this.materialRaisedButton3.Location = new System.Drawing.Point(280, 419);
            this.materialRaisedButton3.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(162, 36);
            this.materialRaisedButton3.TabIndex = 3;
            this.materialRaisedButton3.Text = "Patvirtinti sutartį";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton2.Location = new System.Drawing.Point(179, 524);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(189, 36);
=======
            this.materialRaisedButton2.Location = new System.Drawing.Point(134, 419);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(154, 36);
>>>>>>> Stashed changes
            this.materialRaisedButton2.TabIndex = 2;
            this.materialRaisedButton2.Text = "Redaguoti sutartį";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
<<<<<<< Updated upstream
            this.materialRaisedButton1.Location = new System.Drawing.Point(8, 524);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(165, 36);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Sukurti sutartį";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
=======
            this.materialRaisedButton1.Location = new System.Drawing.Point(6, 419);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(135, 36);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Sukurti sutartį";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.GridLines = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(2);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(714, 380);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Klientas";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kaina";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prekių kiekis";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pardavėjas";
            this.columnHeader6.Width = 200;
            // 
<<<<<<< Updated upstream
            // columnHeader7
            // 
            this.columnHeader7.Text = "Būsena";
            this.columnHeader7.Width = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1192, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuoma";
            this.tabPage2.UseVisualStyleBackColor = true;
=======
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.RentActionLabel2);
            this.tabPage2.Controls.Add(this.RentActionLabel);
            this.tabPage2.Controls.Add(this.RentPriceTo);
            this.tabPage2.Controls.Add(this.RentPriceFrom);
            this.tabPage2.Controls.Add(this.RentDateTo);
            this.tabPage2.Controls.Add(this.RentDateFrom);
            this.tabPage2.Controls.Add(this.SearchButton);
            this.tabPage2.Controls.Add(this.RentLogOutButton);
            this.tabPage2.Controls.Add(this.AccountManagementButton);
            this.tabPage2.Controls.Add(this.RentReportButton);
            this.tabPage2.Controls.Add(this.RentConfirmButton);
            this.tabPage2.Controls.Add(this.RentRemoveButton);
            this.tabPage2.Controls.Add(this.RentEditButton);
            this.tabPage2.Controls.Add(this.RentCreateButton);
            this.tabPage2.Controls.Add(this.RentListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(892, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuoma";
            // 
            // RentActionLabel2
            // 
            this.RentActionLabel2.AutoSize = true;
            this.RentActionLabel2.Depth = 0;
            this.RentActionLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.RentActionLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RentActionLabel2.Location = new System.Drawing.Point(210, 402);
            this.RentActionLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentActionLabel2.Name = "RentActionLabel2";
            this.RentActionLabel2.Size = new System.Drawing.Size(0, 19);
            this.RentActionLabel2.TabIndex = 14;
            // 
            // RentActionLabel
            // 
            this.RentActionLabel.AutoSize = true;
            this.RentActionLabel.Depth = 0;
            this.RentActionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RentActionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RentActionLabel.Location = new System.Drawing.Point(9, 405);
            this.RentActionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentActionLabel.Name = "RentActionLabel";
            this.RentActionLabel.Size = new System.Drawing.Size(0, 19);
            this.RentActionLabel.TabIndex = 13;
            // 
            // RentPriceTo
            // 
            this.RentPriceTo.Depth = 0;
            this.RentPriceTo.Hint = "";
            this.RentPriceTo.Location = new System.Drawing.Point(710, 110);
            this.RentPriceTo.MaxLength = 32767;
            this.RentPriceTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentPriceTo.Name = "RentPriceTo";
            this.RentPriceTo.PasswordChar = '\0';
            this.RentPriceTo.SelectedText = "";
            this.RentPriceTo.SelectionLength = 0;
            this.RentPriceTo.SelectionStart = 0;
            this.RentPriceTo.Size = new System.Drawing.Size(177, 23);
            this.RentPriceTo.TabIndex = 12;
            this.RentPriceTo.TabStop = false;
            this.RentPriceTo.Text = "Kaina iki";
            this.RentPriceTo.UseSystemPasswordChar = false;
            // 
            // RentPriceFrom
            // 
            this.RentPriceFrom.Depth = 0;
            this.RentPriceFrom.Hint = "";
            this.RentPriceFrom.Location = new System.Drawing.Point(707, 81);
            this.RentPriceFrom.MaxLength = 32767;
            this.RentPriceFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentPriceFrom.Name = "RentPriceFrom";
            this.RentPriceFrom.PasswordChar = '\0';
            this.RentPriceFrom.SelectedText = "";
            this.RentPriceFrom.SelectionLength = 0;
            this.RentPriceFrom.SelectionStart = 0;
            this.RentPriceFrom.Size = new System.Drawing.Size(177, 23);
            this.RentPriceFrom.TabIndex = 11;
            this.RentPriceFrom.TabStop = false;
            this.RentPriceFrom.Text = "Kaina nuo";
            this.RentPriceFrom.UseSystemPasswordChar = false;
            // 
            // RentDateTo
            // 
            this.RentDateTo.Depth = 0;
            this.RentDateTo.Hint = "";
            this.RentDateTo.Location = new System.Drawing.Point(707, 43);
            this.RentDateTo.MaxLength = 32767;
            this.RentDateTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentDateTo.Name = "RentDateTo";
            this.RentDateTo.PasswordChar = '\0';
            this.RentDateTo.SelectedText = "";
            this.RentDateTo.SelectionLength = 0;
            this.RentDateTo.SelectionStart = 0;
            this.RentDateTo.Size = new System.Drawing.Size(177, 23);
            this.RentDateTo.TabIndex = 10;
            this.RentDateTo.TabStop = false;
            this.RentDateTo.Text = "Data iki";
            this.RentDateTo.UseSystemPasswordChar = false;
            this.RentDateTo.Click += new System.EventHandler(this.materialSingleLineTextField6_Click);
            // 
            // RentDateFrom
            // 
            this.RentDateFrom.Depth = 0;
            this.RentDateFrom.Hint = "";
            this.RentDateFrom.Location = new System.Drawing.Point(707, 14);
            this.RentDateFrom.MaxLength = 32767;
            this.RentDateFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentDateFrom.Name = "RentDateFrom";
            this.RentDateFrom.PasswordChar = '\0';
            this.RentDateFrom.SelectedText = "";
            this.RentDateFrom.SelectionLength = 0;
            this.RentDateFrom.SelectionStart = 0;
            this.RentDateFrom.Size = new System.Drawing.Size(177, 23);
            this.RentDateFrom.TabIndex = 9;
            this.RentDateFrom.TabStop = false;
            this.RentDateFrom.Text = "Data nuo";
            this.RentDateFrom.UseSystemPasswordChar = false;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Depth = 0;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(760, 139);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Primary = true;
            this.SearchButton.Size = new System.Drawing.Size(77, 36);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Paieška";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RentLogOutButton
            // 
            this.RentLogOutButton.AutoSize = true;
            this.RentLogOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentLogOutButton.Depth = 0;
            this.RentLogOutButton.Icon = null;
            this.RentLogOutButton.Location = new System.Drawing.Point(794, 424);
            this.RentLogOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentLogOutButton.Name = "RentLogOutButton";
            this.RentLogOutButton.Primary = true;
            this.RentLogOutButton.Size = new System.Drawing.Size(98, 36);
            this.RentLogOutButton.TabIndex = 7;
            this.RentLogOutButton.Text = "Atsijungti";
            this.RentLogOutButton.UseVisualStyleBackColor = true;
            this.RentLogOutButton.Click += new System.EventHandler(this.RentLogOutButton_Click);
            // 
            // AccountManagementButton
            // 
            this.AccountManagementButton.AutoSize = true;
            this.AccountManagementButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountManagementButton.Depth = 0;
            this.AccountManagementButton.Icon = null;
            this.AccountManagementButton.Location = new System.Drawing.Point(609, 424);
            this.AccountManagementButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountManagementButton.Name = "AccountManagementButton";
            this.AccountManagementButton.Primary = true;
            this.AccountManagementButton.Size = new System.Drawing.Size(166, 36);
            this.AccountManagementButton.TabIndex = 6;
            this.AccountManagementButton.Text = "Paskyros valdymas";
            this.AccountManagementButton.UseVisualStyleBackColor = true;
            this.AccountManagementButton.Click += new System.EventHandler(this.AccountManagementButton_Click);
            // 
            // RentReportButton
            // 
            this.RentReportButton.AutoSize = true;
            this.RentReportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentReportButton.Depth = 0;
            this.RentReportButton.Icon = null;
            this.RentReportButton.Location = new System.Drawing.Point(389, 424);
            this.RentReportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentReportButton.Name = "RentReportButton";
            this.RentReportButton.Primary = true;
            this.RentReportButton.Size = new System.Drawing.Size(167, 36);
            this.RentReportButton.TabIndex = 5;
            this.RentReportButton.Text = "Ataskaitos kūrimas";
            this.RentReportButton.UseVisualStyleBackColor = true;
            this.RentReportButton.Click += new System.EventHandler(this.RentReportButton_Click);
            // 
            // RentConfirmButton
            // 
            this.RentConfirmButton.AutoSize = true;
            this.RentConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentConfirmButton.Depth = 0;
            this.RentConfirmButton.Icon = null;
            this.RentConfirmButton.Location = new System.Drawing.Point(280, 424);
            this.RentConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentConfirmButton.Name = "RentConfirmButton";
            this.RentConfirmButton.Primary = true;
            this.RentConfirmButton.Size = new System.Drawing.Size(103, 36);
            this.RentConfirmButton.TabIndex = 4;
            this.RentConfirmButton.Text = "Patvirtinti";
            this.RentConfirmButton.UseVisualStyleBackColor = true;
            this.RentConfirmButton.Click += new System.EventHandler(this.RentConfirmButton_Click);
            // 
            // RentRemoveButton
            // 
            this.RentRemoveButton.AutoSize = true;
            this.RentRemoveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentRemoveButton.Depth = 0;
            this.RentRemoveButton.Icon = null;
            this.RentRemoveButton.Location = new System.Drawing.Point(184, 424);
            this.RentRemoveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentRemoveButton.Name = "RentRemoveButton";
            this.RentRemoveButton.Primary = true;
            this.RentRemoveButton.Size = new System.Drawing.Size(90, 36);
            this.RentRemoveButton.TabIndex = 3;
            this.RentRemoveButton.Text = "Pašalinti";
            this.RentRemoveButton.UseVisualStyleBackColor = true;
            this.RentRemoveButton.Click += new System.EventHandler(this.RentRemoveButton_Click);
            // 
            // RentEditButton
            // 
            this.RentEditButton.AutoSize = true;
            this.RentEditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentEditButton.Depth = 0;
            this.RentEditButton.Icon = null;
            this.RentEditButton.Location = new System.Drawing.Point(83, 424);
            this.RentEditButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentEditButton.Name = "RentEditButton";
            this.RentEditButton.Primary = true;
            this.RentEditButton.Size = new System.Drawing.Size(95, 36);
            this.RentEditButton.TabIndex = 2;
            this.RentEditButton.Text = "Redaguoti";
            this.RentEditButton.UseVisualStyleBackColor = true;
            this.RentEditButton.Click += new System.EventHandler(this.RentEditButton_Click);
            // 
            // RentCreateButton
            // 
            this.RentCreateButton.AutoSize = true;
            this.RentCreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentCreateButton.Depth = 0;
            this.RentCreateButton.Icon = null;
            this.RentCreateButton.Location = new System.Drawing.Point(0, 424);
            this.RentCreateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentCreateButton.Name = "RentCreateButton";
            this.RentCreateButton.Primary = true;
            this.RentCreateButton.Size = new System.Drawing.Size(77, 36);
            this.RentCreateButton.TabIndex = 1;
            this.RentCreateButton.Text = "Sukurti";
            this.RentCreateButton.UseVisualStyleBackColor = true;
            this.RentCreateButton.Click += new System.EventHandler(this.RentCreateButton_Click);
            // 
            // RentListView
            // 
            this.RentListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_Nuomos_sutartis,
            this.RentStatus,
            this.fk_Klientasid,
            this.fk_ISVartotojas,
            this.kaina,
            this.sudarymo_data,
            this.grazinimo_data,
            this.pastabos});
            this.RentListView.Depth = 0;
            this.RentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.RentListView.FullRowSelect = true;
            this.RentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RentListView.HideSelection = false;
            this.RentListView.Location = new System.Drawing.Point(0, 0);
            this.RentListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RentListView.MouseState = MaterialSkin.MouseState.OUT;
            this.RentListView.Name = "RentListView";
            this.RentListView.OwnerDraw = true;
            this.RentListView.Size = new System.Drawing.Size(701, 396);
            this.RentListView.TabIndex = 0;
            this.RentListView.UseCompatibleStateImageBehavior = false;
            this.RentListView.View = System.Windows.Forms.View.Details;
            this.RentListView.SelectedIndexChanged += new System.EventHandler(this.RentListView_SelectedIndexChanged);
            // 
            // id_Nuomos_sutartis
            // 
            this.id_Nuomos_sutartis.Text = "ID";
            // 
            // RentStatus
            // 
            this.RentStatus.Text = "Būsena";
            // 
            // fk_Klientasid
            // 
            this.fk_Klientasid.Text = "Klientas";
            this.fk_Klientasid.Width = 135;
            // 
            // fk_ISVartotojas
            // 
            this.fk_ISVartotojas.Text = "Atstovas";
            this.fk_ISVartotojas.Width = 143;
            // 
            // kaina
            // 
            this.kaina.Text = "Kaina";
            this.kaina.Width = 102;
            // 
            // sudarymo_data
            // 
            this.sudarymo_data.Text = "Sudarymo data";
            this.sudarymo_data.Width = 236;
            // 
            // grazinimo_data
            // 
            this.grazinimo_data.Text = "Gražinimo data";
            this.grazinimo_data.Width = 265;
            // 
            // pastabos
            // 
            this.pastabos.Text = "Pastabos";
            this.pastabos.Width = 197;
>>>>>>> Stashed changes
            // 
            // SalesRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesRentForm";
            this.Text = "SalesRentForm";
            this.Load += new System.EventHandler(this.SalesRentForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
<<<<<<< Updated upstream
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
=======
        private MaterialSkin.Controls.MaterialSingleLineTextField RentPriceTo;
        private MaterialSkin.Controls.MaterialSingleLineTextField RentPriceFrom;
        private MaterialSkin.Controls.MaterialSingleLineTextField RentDateTo;
        private MaterialSkin.Controls.MaterialSingleLineTextField RentDateFrom;
        private MaterialSkin.Controls.MaterialRaisedButton SearchButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentLogOutButton;
        private MaterialSkin.Controls.MaterialRaisedButton AccountManagementButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentReportButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentConfirmButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentRemoveButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentEditButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentCreateButton;
        private MaterialSkin.Controls.MaterialListView RentListView;
        private System.Windows.Forms.ColumnHeader id_Nuomos_sutartis;
        private System.Windows.Forms.ColumnHeader fk_Klientasid;
        private System.Windows.Forms.ColumnHeader fk_ISVartotojas;
        private System.Windows.Forms.ColumnHeader kaina;
        private System.Windows.Forms.ColumnHeader sudarymo_data;
        private System.Windows.Forms.ColumnHeader grazinimo_data;
        private System.Windows.Forms.ColumnHeader pastabos;
        private MaterialSkin.Controls.MaterialLabel RentActionLabel;
        private MaterialSkin.Controls.MaterialLabel RentActionLabel2;
        private System.Windows.Forms.ColumnHeader RentStatus;
>>>>>>> Stashed changes
    }
}