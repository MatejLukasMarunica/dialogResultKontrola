namespace dialogResultKontrola
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ButtonOtvori = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonOtvori
            // 
            this.ButtonOtvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOtvori.Location = new System.Drawing.Point(188, 26);
            this.ButtonOtvori.Name = "ButtonOtvori";
            this.ButtonOtvori.Size = new System.Drawing.Size(124, 54);
            this.ButtonOtvori.TabIndex = 0;
            this.ButtonOtvori.Text = "button1";
            this.ButtonOtvori.UseVisualStyleBackColor = true;
            this.ButtonOtvori.Click += new System.EventHandler(this.ButtonOtvori_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(78, 129);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(346, 102);
            this.textBoxRezultat.TabIndex = 1;
            this.textBoxRezultat.TextChanged += new System.EventHandler(this.textBoxRezultat_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 334);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.ButtonOtvori);
            this.Name = "Form1";
            this.Text = "Upotreba DialogResult Kontrola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ButtonOtvori;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}

