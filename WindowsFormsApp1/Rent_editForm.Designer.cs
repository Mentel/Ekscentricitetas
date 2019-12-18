namespace WindowsFormsApp1
{
    partial class Rent_editForm
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
            this.RentEditConfirmButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentEditClientBox = new System.Windows.Forms.ComboBox();
            this.RentEditWorkerBox = new System.Windows.Forms.ComboBox();
            this.RentEditPastabos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RentEditPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RentEditBackDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // RentEditConfirmButton
            // 
            this.RentEditConfirmButton.AutoSize = true;
            this.RentEditConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentEditConfirmButton.Depth = 0;
            this.RentEditConfirmButton.Icon = null;
            this.RentEditConfirmButton.Location = new System.Drawing.Point(51, 268);
            this.RentEditConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentEditConfirmButton.Name = "RentEditConfirmButton";
            this.RentEditConfirmButton.Primary = true;
            this.RentEditConfirmButton.Size = new System.Drawing.Size(103, 36);
            this.RentEditConfirmButton.TabIndex = 0;
            this.RentEditConfirmButton.Text = "Patvirtinti";
            this.RentEditConfirmButton.UseVisualStyleBackColor = true;
            this.RentEditConfirmButton.Click += new System.EventHandler(this.RentEditConfirmButton_Click);
            // 
            // RentEditClientBox
            // 
            this.RentEditClientBox.FormattingEnabled = true;
            this.RentEditClientBox.Location = new System.Drawing.Point(122, 84);
            this.RentEditClientBox.Name = "RentEditClientBox";
            this.RentEditClientBox.Size = new System.Drawing.Size(121, 21);
            this.RentEditClientBox.TabIndex = 1;
            // 
            // RentEditWorkerBox
            // 
            this.RentEditWorkerBox.FormattingEnabled = true;
            this.RentEditWorkerBox.Location = new System.Drawing.Point(122, 120);
            this.RentEditWorkerBox.Name = "RentEditWorkerBox";
            this.RentEditWorkerBox.Size = new System.Drawing.Size(121, 21);
            this.RentEditWorkerBox.TabIndex = 2;
            // 
            // RentEditPastabos
            // 
            this.RentEditPastabos.Depth = 0;
            this.RentEditPastabos.Hint = "";
            this.RentEditPastabos.Location = new System.Drawing.Point(122, 194);
            this.RentEditPastabos.MaxLength = 32767;
            this.RentEditPastabos.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentEditPastabos.Name = "RentEditPastabos";
            this.RentEditPastabos.PasswordChar = '\0';
            this.RentEditPastabos.SelectedText = "";
            this.RentEditPastabos.SelectionLength = 0;
            this.RentEditPastabos.SelectionStart = 0;
            this.RentEditPastabos.Size = new System.Drawing.Size(75, 23);
            this.RentEditPastabos.TabIndex = 3;
            this.RentEditPastabos.TabStop = false;
            this.RentEditPastabos.UseSystemPasswordChar = false;
            // 
            // RentEditPrice
            // 
            this.RentEditPrice.Depth = 0;
            this.RentEditPrice.Hint = "";
            this.RentEditPrice.Location = new System.Drawing.Point(122, 156);
            this.RentEditPrice.MaxLength = 32767;
            this.RentEditPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentEditPrice.Name = "RentEditPrice";
            this.RentEditPrice.PasswordChar = '\0';
            this.RentEditPrice.SelectedText = "";
            this.RentEditPrice.SelectionLength = 0;
            this.RentEditPrice.SelectionStart = 0;
            this.RentEditPrice.Size = new System.Drawing.Size(75, 23);
            this.RentEditPrice.TabIndex = 4;
            this.RentEditPrice.TabStop = false;
            this.RentEditPrice.Text = "materialSingleLineTextField2";
            this.RentEditPrice.UseSystemPasswordChar = false;
            // 
            // RentEditBackDate
            // 
            this.RentEditBackDate.Depth = 0;
            this.RentEditBackDate.Hint = "";
            this.RentEditBackDate.Location = new System.Drawing.Point(122, 223);
            this.RentEditBackDate.MaxLength = 32767;
            this.RentEditBackDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentEditBackDate.Name = "RentEditBackDate";
            this.RentEditBackDate.PasswordChar = '\0';
            this.RentEditBackDate.SelectedText = "";
            this.RentEditBackDate.SelectionLength = 0;
            this.RentEditBackDate.SelectionStart = 0;
            this.RentEditBackDate.Size = new System.Drawing.Size(75, 23);
            this.RentEditBackDate.TabIndex = 5;
            this.RentEditBackDate.TabStop = false;
            this.RentEditBackDate.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Klientas";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Atstovas";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 156);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Kaina";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 194);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Pastabos";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(8, 227);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(110, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Gražinimo data";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // Rent_editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 347);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.RentEditBackDate);
            this.Controls.Add(this.RentEditPrice);
            this.Controls.Add(this.RentEditPastabos);
            this.Controls.Add(this.RentEditWorkerBox);
            this.Controls.Add(this.RentEditClientBox);
            this.Controls.Add(this.RentEditConfirmButton);
            this.Name = "Rent_editForm";
            this.Text = "Rent_editForm";
            this.Load += new System.EventHandler(this.Rent_editForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton RentEditConfirmButton;
        private System.Windows.Forms.ComboBox RentEditClientBox;
        private System.Windows.Forms.ComboBox RentEditWorkerBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField RentEditPastabos;
        private MaterialSkin.Controls.MaterialSingleLineTextField RentEditPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField RentEditBackDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}