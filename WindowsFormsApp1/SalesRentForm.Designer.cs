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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.id_Nuomos_sutartis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fk_Klientasid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fk_ISVartotojas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kaina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sudarymo_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grazinimo_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pastabos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentReportButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentConfirmButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentAddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentEditButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentDeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RentAccountManagementButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LogOutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(856, 42);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
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
            this.materialTabControl1.Size = new System.Drawing.Size(856, 410);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(848, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pardavimai";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Controls.Add(this.RentReportButton);
            this.tabPage2.Controls.Add(this.RentConfirmButton);
            this.tabPage2.Controls.Add(this.RentAddButton);
            this.tabPage2.Controls.Add(this.RentEditButton);
            this.tabPage2.Controls.Add(this.RentDeleteButton);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField4);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField3);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage2.Controls.Add(this.materialRaisedButton3);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage2.Controls.Add(this.RentAccountManagementButton);
            this.tabPage2.Controls.Add(this.LogOutButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(848, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuoma";
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_Nuomos_sutartis,
            this.fk_Klientasid,
            this.fk_ISVartotojas,
            this.kaina,
            this.sudarymo_data,
            this.grazinimo_data,
            this.pastabos});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(713, 342);
            this.materialListView1.TabIndex = 12;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged_1);
            // 
            // id_Nuomos_sutartis
            // 
            this.id_Nuomos_sutartis.Text = "ID";
            // 
            // fk_Klientasid
            // 
            this.fk_Klientasid.Text = "Klientas";
            this.fk_Klientasid.Width = 139;
            // 
            // fk_ISVartotojas
            // 
            this.fk_ISVartotojas.Text = "Atstovas";
            this.fk_ISVartotojas.Width = 145;
            // 
            // kaina
            // 
            this.kaina.Text = "Kaina";
            this.kaina.Width = 65;
            // 
            // sudarymo_data
            // 
            this.sudarymo_data.Text = "Sudarymo data";
            this.sudarymo_data.Width = 175;
            // 
            // grazinimo_data
            // 
            this.grazinimo_data.Text = "Gražinimo data";
            this.grazinimo_data.Width = 146;
            // 
            // pastabos
            // 
            this.pastabos.Text = "Pastabos";
            this.pastabos.Width = 138;
            // 
            // RentReportButton
            // 
            this.RentReportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RentReportButton.AutoSize = true;
            this.RentReportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentReportButton.Depth = 0;
            this.RentReportButton.Icon = null;
            this.RentReportButton.Location = new System.Drawing.Point(389, 348);
            this.RentReportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentReportButton.Name = "RentReportButton";
            this.RentReportButton.Primary = true;
            this.RentReportButton.Size = new System.Drawing.Size(167, 36);
            this.RentReportButton.TabIndex = 11;
            this.RentReportButton.Text = "Ataskaitos kūrimas";
            this.RentReportButton.UseVisualStyleBackColor = true;
            this.RentReportButton.Click += new System.EventHandler(this.RentReportButton_Click);
            // 
            // RentConfirmButton
            // 
            this.RentConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RentConfirmButton.AutoSize = true;
            this.RentConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentConfirmButton.Depth = 0;
            this.RentConfirmButton.Icon = null;
            this.RentConfirmButton.Location = new System.Drawing.Point(280, 348);
            this.RentConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentConfirmButton.Name = "RentConfirmButton";
            this.RentConfirmButton.Primary = true;
            this.RentConfirmButton.Size = new System.Drawing.Size(103, 36);
            this.RentConfirmButton.TabIndex = 10;
            this.RentConfirmButton.Text = "Patvirtinti";
            this.RentConfirmButton.UseVisualStyleBackColor = true;
            this.RentConfirmButton.Click += new System.EventHandler(this.RentConfirmButton_Click);
            // 
            // RentAddButton
            // 
            this.RentAddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RentAddButton.AutoSize = true;
            this.RentAddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentAddButton.Depth = 0;
            this.RentAddButton.Icon = null;
            this.RentAddButton.Location = new System.Drawing.Point(0, 348);
            this.RentAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentAddButton.Name = "RentAddButton";
            this.RentAddButton.Primary = true;
            this.RentAddButton.Size = new System.Drawing.Size(77, 36);
            this.RentAddButton.TabIndex = 9;
            this.RentAddButton.Text = "Sukurti";
            this.RentAddButton.UseVisualStyleBackColor = true;
            this.RentAddButton.Click += new System.EventHandler(this.RentAddButton_Click);
            // 
            // RentEditButton
            // 
            this.RentEditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RentEditButton.AutoSize = true;
            this.RentEditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentEditButton.Depth = 0;
            this.RentEditButton.Icon = null;
            this.RentEditButton.Location = new System.Drawing.Point(83, 349);
            this.RentEditButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentEditButton.Name = "RentEditButton";
            this.RentEditButton.Primary = true;
            this.RentEditButton.Size = new System.Drawing.Size(95, 36);
            this.RentEditButton.TabIndex = 8;
            this.RentEditButton.Text = "Redaguoti";
            this.RentEditButton.UseVisualStyleBackColor = true;
            this.RentEditButton.Click += new System.EventHandler(this.RentEditButton_Click);
            // 
            // RentDeleteButton
            // 
            this.RentDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RentDeleteButton.AutoSize = true;
            this.RentDeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentDeleteButton.Depth = 0;
            this.RentDeleteButton.Icon = null;
            this.RentDeleteButton.Location = new System.Drawing.Point(184, 349);
            this.RentDeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentDeleteButton.Name = "RentDeleteButton";
            this.RentDeleteButton.Primary = true;
            this.RentDeleteButton.Size = new System.Drawing.Size(90, 36);
            this.RentDeleteButton.TabIndex = 7;
            this.RentDeleteButton.Text = "Pašalinti";
            this.RentDeleteButton.UseVisualStyleBackColor = true;
            this.RentDeleteButton.Click += new System.EventHandler(this.RentDeleteButton_Click);
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(719, 92);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(121, 23);
            this.materialSingleLineTextField4.TabIndex = 6;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.Text = "Kaina iki";
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(719, 63);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(121, 23);
            this.materialSingleLineTextField3.TabIndex = 5;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.Text = "Kaina nuo";
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(719, 34);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(121, 23);
            this.materialSingleLineTextField2.TabIndex = 4;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "Data iki";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(742, 121);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(77, 36);
            this.materialRaisedButton3.TabIndex = 3;
            this.materialRaisedButton3.Text = "Paieška";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(719, 5);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(121, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "Data nuo";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // RentAccountManagementButton
            // 
            this.RentAccountManagementButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RentAccountManagementButton.AutoSize = true;
            this.RentAccountManagementButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentAccountManagementButton.Depth = 0;
            this.RentAccountManagementButton.Icon = null;
            this.RentAccountManagementButton.Location = new System.Drawing.Point(570, 349);
            this.RentAccountManagementButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentAccountManagementButton.Name = "RentAccountManagementButton";
            this.RentAccountManagementButton.Primary = true;
            this.RentAccountManagementButton.Size = new System.Drawing.Size(166, 36);
            this.RentAccountManagementButton.TabIndex = 1;
            this.RentAccountManagementButton.Text = "Paskyros valdymas";
            this.RentAccountManagementButton.UseVisualStyleBackColor = true;
            this.RentAccountManagementButton.Click += new System.EventHandler(this.RentAccountManagementButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogOutButton.AutoSize = true;
            this.LogOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogOutButton.Depth = 0;
            this.LogOutButton.Icon = null;
            this.LogOutButton.Location = new System.Drawing.Point(742, 349);
            this.LogOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Primary = true;
            this.LogOutButton.Size = new System.Drawing.Size(98, 36);
            this.LogOutButton.TabIndex = 0;
            this.LogOutButton.Text = "Atsijungti";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SalesRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 519);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesRentForm";
            this.Text = "SalesRentForm";
            this.Load += new System.EventHandler(this.SalesRentForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRaisedButton RentAccountManagementButton;
        private MaterialSkin.Controls.MaterialRaisedButton LogOutButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton RentEditButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentDeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentReportButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentConfirmButton;
        private MaterialSkin.Controls.MaterialRaisedButton RentAddButton;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader id_Nuomos_sutartis;
        private System.Windows.Forms.ColumnHeader fk_Klientasid;
        private System.Windows.Forms.ColumnHeader fk_ISVartotojas;
        private System.Windows.Forms.ColumnHeader kaina;
        private System.Windows.Forms.ColumnHeader sudarymo_data;
        private System.Windows.Forms.ColumnHeader grazinimo_data;
        private System.Windows.Forms.ColumnHeader pastabos;
    }
}