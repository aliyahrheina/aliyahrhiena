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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxStand.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStand
            // 
            this.groupBoxStand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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
            this.buttonPilih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPilih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilih.Location = new System.Drawing.Point(171, 83);
            this.buttonPilih.Name = "buttonPilih";
            this.buttonPilih.Size = new System.Drawing.Size(91, 38);
            this.buttonPilih.TabIndex = 1;
            this.buttonPilih.Text = "Pilih";
            this.buttonPilih.UseVisualStyleBackColor = false;
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
            this.groupBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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
            this.btnPesan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.Location = new System.Drawing.Point(351, 73);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(87, 38);
            this.btnPesan.TabIndex = 1;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = false;
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
            this.listBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 20;
            this.listBoxInfo.Location = new System.Drawing.Point(43, 246);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(766, 264);
            this.listBoxInfo.TabIndex = 2;
            // 
            // buttonTotal
            // 
            this.buttonTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotal.Location = new System.Drawing.Point(690, 196);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(119, 32);
            this.buttonTotal.TabIndex = 3;
            this.buttonTotal.Text = "Total";
            this.buttonTotal.UseVisualStyleBackColor = false;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(690, 530);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(513, 530);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(109, 35);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_UAS.Properties.Resources.makan2;
            this.ClientSize = new System.Drawing.Size(907, 593);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
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
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
    }
}