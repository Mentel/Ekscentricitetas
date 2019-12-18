namespace WindowsFormsApp1
{
    partial class Rent_addForm
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
            this.RentClientComboBox = new System.Windows.Forms.ComboBox();
            this.RentWorkerComboBox = new System.Windows.Forms.ComboBox();
            this.NewRentPriceLine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RentAddConfirmButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RentAddClientLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RentAddWorkerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // RentClientComboBox
            // 
            this.RentClientComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentClientComboBox.FormattingEnabled = true;
            this.RentClientComboBox.Location = new System.Drawing.Point(12, 197);
            this.RentClientComboBox.Name = "RentClientComboBox";
            this.RentClientComboBox.Size = new System.Drawing.Size(121, 21);
            this.RentClientComboBox.TabIndex = 0;
            this.RentClientComboBox.SelectedIndexChanged += new System.EventHandler(this.RentClientComboBox_SelectedIndexChanged);
            // 
            // RentWorkerComboBox
            // 
            this.RentWorkerComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentWorkerComboBox.FormattingEnabled = true;
            this.RentWorkerComboBox.Location = new System.Drawing.Point(12, 243);
            this.RentWorkerComboBox.Name = "RentWorkerComboBox";
            this.RentWorkerComboBox.Size = new System.Drawing.Size(121, 21);
            this.RentWorkerComboBox.TabIndex = 1;
            // 
            // NewRentPriceLine
            // 
            this.NewRentPriceLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewRentPriceLine.Depth = 0;
            this.NewRentPriceLine.Hint = "";
            this.NewRentPriceLine.Location = new System.Drawing.Point(12, 270);
            this.NewRentPriceLine.MaxLength = 32767;
            this.NewRentPriceLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewRentPriceLine.Name = "NewRentPriceLine";
            this.NewRentPriceLine.PasswordChar = '\0';
            this.NewRentPriceLine.SelectedText = "";
            this.NewRentPriceLine.SelectionLength = 0;
            this.NewRentPriceLine.SelectionStart = 0;
            this.NewRentPriceLine.Size = new System.Drawing.Size(75, 23);
            this.NewRentPriceLine.TabIndex = 2;
            this.NewRentPriceLine.TabStop = false;
            this.NewRentPriceLine.Text = "Kaina";
            this.NewRentPriceLine.UseSystemPasswordChar = false;
            // 
            // RentAddConfirmButton
            // 
            this.RentAddConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentAddConfirmButton.AutoSize = true;
            this.RentAddConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RentAddConfirmButton.Depth = 0;
            this.RentAddConfirmButton.Icon = null;
            this.RentAddConfirmButton.Location = new System.Drawing.Point(12, 299);
            this.RentAddConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentAddConfirmButton.Name = "RentAddConfirmButton";
            this.RentAddConfirmButton.Primary = true;
            this.RentAddConfirmButton.Size = new System.Drawing.Size(103, 36);
            this.RentAddConfirmButton.TabIndex = 3;
            this.RentAddConfirmButton.Text = "Patvirtinti";
            this.RentAddConfirmButton.UseVisualStyleBackColor = true;
            this.RentAddConfirmButton.Click += new System.EventHandler(this.RentAddConfirmButton_Click);
            // 
            // RentAddClientLabel
            // 
            this.RentAddClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentAddClientLabel.AutoSize = true;
            this.RentAddClientLabel.Depth = 0;
            this.RentAddClientLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RentAddClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RentAddClientLabel.Location = new System.Drawing.Point(8, 175);
            this.RentAddClientLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentAddClientLabel.Name = "RentAddClientLabel";
            this.RentAddClientLabel.Size = new System.Drawing.Size(63, 19);
            this.RentAddClientLabel.TabIndex = 5;
            this.RentAddClientLabel.Text = "Klientas";
            // 
            // RentAddWorkerLabel
            // 
            this.RentAddWorkerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RentAddWorkerLabel.AutoSize = true;
            this.RentAddWorkerLabel.Depth = 0;
            this.RentAddWorkerLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RentAddWorkerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RentAddWorkerLabel.Location = new System.Drawing.Point(12, 221);
            this.RentAddWorkerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RentAddWorkerLabel.Name = "RentAddWorkerLabel";
            this.RentAddWorkerLabel.Size = new System.Drawing.Size(69, 19);
            this.RentAddWorkerLabel.TabIndex = 6;
            this.RentAddWorkerLabel.Text = "Atstovas";
            this.RentAddWorkerLabel.Click += new System.EventHandler(this.RentAddWorkerLabel_Click);
            // 
            // Rent_addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 345);
            this.Controls.Add(this.RentAddWorkerLabel);
            this.Controls.Add(this.RentAddClientLabel);
            this.Controls.Add(this.RentAddConfirmButton);
            this.Controls.Add(this.NewRentPriceLine);
            this.Controls.Add(this.RentWorkerComboBox);
            this.Controls.Add(this.RentClientComboBox);
            this.Name = "Rent_addForm";
            this.Text = "Rent_addForm";
            this.Load += new System.EventHandler(this.Rent_addForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RentClientComboBox;
        private System.Windows.Forms.ComboBox RentWorkerComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField NewRentPriceLine;
        private MaterialSkin.Controls.MaterialRaisedButton RentAddConfirmButton;
        private MaterialSkin.Controls.MaterialLabel RentAddClientLabel;
        private MaterialSkin.Controls.MaterialLabel RentAddWorkerLabel;
    }
}