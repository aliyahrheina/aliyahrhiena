namespace Project_UAS
{
    partial class Form3
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
            this.groupBoxStand = new System.Windows.Forms.GroupBox();
            this.buttonPilih = new System.Windows.Forms.Button();
            this.comboBoxStand = new System.Windows.Forms.ComboBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.btnPilinMenu = new System.Windows.Forms.Button();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.groupBoxStand.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStand
            // 
            this.groupBoxStand.Controls.Add(this.buttonPilih);
            this.groupBoxStand.Controls.Add(this.comboBoxStand);
            this.groupBoxStand.Location = new System.Drawing.Point(57, 79);
            this.groupBoxStand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStand.Name = "groupBoxStand";
            this.groupBoxStand.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStand.Size = new System.Drawing.Size(387, 159);
            this.groupBoxStand.TabIndex = 0;
            this.groupBoxStand.TabStop = false;
            this.groupBoxStand.Text = "Stand";
            // 
            // buttonPilih
            // 
            this.buttonPilih.Location = new System.Drawing.Point(228, 104);
            this.buttonPilih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPilih.Name = "buttonPilih";
            this.buttonPilih.Size = new System.Drawing.Size(121, 48);
            this.buttonPilih.TabIndex = 1;
            this.buttonPilih.Text = "Pilih";
            this.buttonPilih.UseVisualStyleBackColor = true;
            this.buttonPilih.Click += new System.EventHandler(this.buttonPilih_Click);
            // 
            // comboBoxStand
            // 
            this.comboBoxStand.FormattingEnabled = true;
            this.comboBoxStand.Location = new System.Drawing.Point(25, 52);
            this.comboBoxStand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStand.Name = "comboBoxStand";
            this.comboBoxStand.Size = new System.Drawing.Size(323, 33);
            this.comboBoxStand.TabIndex = 0;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.labelHarga);
            this.groupBoxMenu.Controls.Add(this.btnPilinMenu);
            this.groupBoxMenu.Controls.Add(this.comboBoxMenu);
            this.groupBoxMenu.Location = new System.Drawing.Point(452, 79);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMenu.Size = new System.Drawing.Size(627, 170);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(463, 62);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(63, 25);
            this.labelHarga.TabIndex = 2;
            this.labelHarga.Text = "Rp. 0";
            // 
            // btnPilinMenu
            // 
            this.btnPilinMenu.Location = new System.Drawing.Point(468, 111);
            this.btnPilinMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPilinMenu.Name = "btnPilinMenu";
            this.btnPilinMenu.Size = new System.Drawing.Size(116, 48);
            this.btnPilinMenu.TabIndex = 1;
            this.btnPilinMenu.Text = "Pilih";
            this.btnPilinMenu.UseVisualStyleBackColor = true;
            this.btnPilinMenu.Click += new System.EventHandler(this.btnPilinMenu_Click);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(39, 56);
            this.comboBoxMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(372, 33);
            this.comboBoxMenu.TabIndex = 0;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 25;
            this.listBoxInfo.Location = new System.Drawing.Point(57, 278);
            this.listBoxInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(1020, 329);
            this.listBoxInfo.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 644);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxStand);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBoxStand.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStand;
        private System.Windows.Forms.Button buttonPilih;
        private System.Windows.Forms.ComboBox comboBoxStand;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button btnPilinMenu;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.ListBox listBoxInfo;
    }
}