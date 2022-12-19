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
            this.btnPesan = new System.Windows.Forms.Button();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.groupBoxStand.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStand
            // 
            this.groupBoxStand.Controls.Add(this.buttonPilih);
            this.groupBoxStand.Controls.Add(this.comboBoxStand);
            this.groupBoxStand.Location = new System.Drawing.Point(43, 63);
            this.groupBoxStand.Name = "groupBoxStand";
            this.groupBoxStand.Size = new System.Drawing.Size(290, 127);
            this.groupBoxStand.TabIndex = 0;
            this.groupBoxStand.TabStop = false;
            this.groupBoxStand.Text = "Stand";
            // 
            // buttonPilih
            // 
            this.buttonPilih.Location = new System.Drawing.Point(171, 83);
            this.buttonPilih.Name = "buttonPilih";
            this.buttonPilih.Size = new System.Drawing.Size(91, 38);
            this.buttonPilih.TabIndex = 1;
            this.buttonPilih.Text = "Pilih";
            this.buttonPilih.UseVisualStyleBackColor = true;
            this.buttonPilih.Click += new System.EventHandler(this.buttonPilih_Click);
            // 
            // comboBoxStand
            // 
            this.comboBoxStand.FormattingEnabled = true;
            this.comboBoxStand.Location = new System.Drawing.Point(19, 42);
            this.comboBoxStand.Name = "comboBoxStand";
            this.comboBoxStand.Size = new System.Drawing.Size(243, 28);
            this.comboBoxStand.TabIndex = 0;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.labelHarga);
            this.groupBoxMenu.Controls.Add(this.btnPesan);
            this.groupBoxMenu.Controls.Add(this.comboBoxMenu);
            this.groupBoxMenu.Location = new System.Drawing.Point(339, 63);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(470, 127);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(347, 50);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(47, 20);
            this.labelHarga.TabIndex = 2;
            this.labelHarga.Text = "Rp. 0";
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(351, 73);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(87, 38);
            this.btnPesan.TabIndex = 1;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(29, 45);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(280, 28);
            this.comboBoxMenu.TabIndex = 0;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 20;
            this.listBoxInfo.Location = new System.Drawing.Point(43, 246);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(766, 264);
            this.listBoxInfo.TabIndex = 2;
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(690, 196);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(119, 32);
            this.buttonTotal.TabIndex = 3;
            this.buttonTotal.Text = "Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 570);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxStand);
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
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Button buttonTotal;
    }
}