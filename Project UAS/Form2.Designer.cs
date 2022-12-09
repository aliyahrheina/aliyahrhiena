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
            this.SuspendLayout();
            // 
            // labelApakah
            // 
            this.labelApakah.AutoSize = true;
            this.labelApakah.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApakah.Location = new System.Drawing.Point(127, 87);
            this.labelApakah.Name = "labelApakah";
            this.labelApakah.Size = new System.Drawing.Size(541, 51);
            this.labelApakah.TabIndex = 0;
            this.labelApakah.Text = "Apakah anda ingin memesan ?";
            // 
            // buttonYA
            // 
            this.buttonYA.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYA.Location = new System.Drawing.Point(45, 205);
            this.buttonYA.Name = "buttonYA";
            this.buttonYA.Size = new System.Drawing.Size(155, 56);
            this.buttonYA.TabIndex = 1;
            this.buttonYA.Text = "YA";
            this.buttonYA.UseVisualStyleBackColor = true;
            // 
            // buttonTidak
            // 
            this.buttonTidak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTidak.Location = new System.Drawing.Point(571, 205);
            this.buttonTidak.Name = "buttonTidak";
            this.buttonTidak.Size = new System.Drawing.Size(127, 56);
            this.buttonTidak.TabIndex = 2;
            this.buttonTidak.Text = "TIDAK";
            this.buttonTidak.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}