namespace WindowsFormsApp3
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
            this.buka = new System.Windows.Forms.Button();
            this.simpan = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.cari = new System.Windows.Forms.Button();
            this.text_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buka
            // 
            this.buka.Location = new System.Drawing.Point(28, 303);
            this.buka.Name = "buka";
            this.buka.Size = new System.Drawing.Size(75, 23);
            this.buka.TabIndex = 0;
            this.buka.Text = "Buka";
            this.buka.UseVisualStyleBackColor = true;
            this.buka.Click += new System.EventHandler(this.buka_Click);
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(109, 303);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(75, 23);
            this.simpan.TabIndex = 1;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(190, 303);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 23);
            this.hapus.TabIndex = 2;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // cari
            // 
            this.cari.Location = new System.Drawing.Point(432, 303);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(75, 23);
            this.cari.TabIndex = 3;
            this.cari.Text = "Cari";
            this.cari.UseVisualStyleBackColor = true;
            this.cari.Click += new System.EventHandler(this.cari_Click);
            // 
            // text_cari
            // 
            this.text_cari.Location = new System.Drawing.Point(317, 303);
            this.text_cari.Name = "text_cari";
            this.text_cari.Size = new System.Drawing.Size(100, 20);
            this.text_cari.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cari :";
            // 
            // text_edit
            // 
            this.text_edit.Location = new System.Drawing.Point(28, 28);
            this.text_edit.Multiline = true;
            this.text_edit.Name = "text_edit";
            this.text_edit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_edit.Size = new System.Drawing.Size(479, 261);
            this.text_edit.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_cari);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.buka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buka;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button cari;
        private System.Windows.Forms.TextBox text_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_edit;
    }
}

