namespace Project_UAS
{
    partial class Form2
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
            this.labelApakah = new System.Windows.Forms.Label();
            this.buttonYA = new System.Windows.Forms.Button();
            this.buttonTidak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelApakah
            // 
            this.labelApakah.AutoSize = true;
            this.labelApakah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelApakah.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApakah.Location = new System.Drawing.Point(231, 205);
            this.labelApakah.Name = "labelApakah";
            this.labelApakah.Size = new System.Drawing.Size(426, 34);
            this.labelApakah.TabIndex = 0;
            this.labelApakah.Text = "Apakah anda ingin memesan ?";
            // 
            // buttonYA
            // 
            this.buttonYA.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonYA.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonYA.Location = new System.Drawing.Point(82, 323);
            this.buttonYA.Name = "buttonYA";
            this.buttonYA.Size = new System.Drawing.Size(155, 56);
            this.buttonYA.TabIndex = 1;
            this.buttonYA.Text = "YA";
            this.buttonYA.UseVisualStyleBackColor = false;
            this.buttonYA.Click += new System.EventHandler(this.buttonYA_Click);
            // 
            // buttonTidak
            // 
            this.buttonTidak.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonTidak.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTidak.Location = new System.Drawing.Point(725, 323);
            this.buttonTidak.Name = "buttonTidak";
            this.buttonTidak.Size = new System.Drawing.Size(127, 56);
            this.buttonTidak.TabIndex = 2;
            this.buttonTidak.Text = "TIDAK";
            this.buttonTidak.UseVisualStyleBackColor = false;
            this.buttonTidak.Click += new System.EventHandler(this.buttonTidak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(75, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELAMAT DATANG DI KANTIN KELUWIH";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_UAS.Properties.Resources.MKN;
            this.ClientSize = new System.Drawing.Size(906, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTidak);
            this.Controls.Add(this.buttonYA);
            this.Controls.Add(this.labelApakah);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApakah;
        private System.Windows.Forms.Button buttonYA;
        private System.Windows.Forms.Button buttonTidak;
        private System.Windows.Forms.Label label1;
    }
}