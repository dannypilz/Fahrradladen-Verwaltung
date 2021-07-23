namespace Fahrradladen_Gruppe1
{
    partial class Produkt_anlegen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produkt_anlegen));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_produktid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_produktkategorie = new System.Windows.Forms.TextBox();
            this.tb_lagerbestand = new System.Windows.Forms.TextBox();
            this.tb_preis = new System.Windows.Forms.TextBox();
            this.tb_bezeichnung = new System.Windows.Forms.TextBox();
            this.pb_PRspeichern = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PRspeichern)).BeginInit();
            this.SuspendLayout();          
            // 
            // tb_produktid
            // 
            this.tb_produktid.Enabled = false;
            this.tb_produktid.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produktid.Location = new System.Drawing.Point(209, 77);
            this.tb_produktid.Name = "tb_produktid";
            this.tb_produktid.Size = new System.Drawing.Size(218, 26);
            this.tb_produktid.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produkt ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Neues Produkt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Produktkategorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Preis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bezeichnung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lagerbestand";
            // 
            // tb_produktkategorie
            // 
            this.tb_produktkategorie.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produktkategorie.Location = new System.Drawing.Point(209, 163);
            this.tb_produktkategorie.Name = "tb_produktkategorie";
            this.tb_produktkategorie.Size = new System.Drawing.Size(218, 26);
            this.tb_produktkategorie.TabIndex = 19;
            this.tb_produktkategorie.Enter += new System.EventHandler(this.tb_produktkategorie_Enter);
            // 
            // tb_lagerbestand
            // 
            this.tb_lagerbestand.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lagerbestand.Location = new System.Drawing.Point(209, 254);
            this.tb_lagerbestand.Name = "tb_lagerbestand";
            this.tb_lagerbestand.Size = new System.Drawing.Size(218, 26);
            this.tb_lagerbestand.TabIndex = 20;
            // 
            // tb_preis
            // 
            this.tb_preis.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preis.Location = new System.Drawing.Point(209, 208);
            this.tb_preis.Name = "tb_preis";
            this.tb_preis.Size = new System.Drawing.Size(218, 26);
            this.tb_preis.TabIndex = 21;
            // 
            // tb_bezeichnung
            // 
            this.tb_bezeichnung.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bezeichnung.Location = new System.Drawing.Point(209, 120);
            this.tb_bezeichnung.Name = "tb_bezeichnung";
            this.tb_bezeichnung.Size = new System.Drawing.Size(218, 26);
            this.tb_bezeichnung.TabIndex = 22;
            // 
            // pb_PRspeichern
            // 
            this.pb_PRspeichern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_PRspeichern.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Speichern;
            this.pb_PRspeichern.Location = new System.Drawing.Point(558, 288);
            this.pb_PRspeichern.Name = "pb_PRspeichern";
            this.pb_PRspeichern.Size = new System.Drawing.Size(50, 50);
            this.pb_PRspeichern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PRspeichern.TabIndex = 31;
            this.pb_PRspeichern.TabStop = false;
            this.pb_PRspeichern.Click += new System.EventHandler(this.pb_PRspeichern_Click);
            this.pb_PRspeichern.MouseHover += new System.EventHandler(this.pb_PRspeichern_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(433, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "(000.00)";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(599, -3);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 35;
            this.lbl_close.Text = "x";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            this.lbl_close.MouseHover += new System.EventHandler(this.lbl_close_MouseHover);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_min.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.Color.White;
            this.lbl_min.Location = new System.Drawing.Point(580, -3);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 34;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // Produkt_anlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pb_PRspeichern);
            this.Controls.Add(this.tb_bezeichnung);
            this.Controls.Add(this.tb_preis);
            this.Controls.Add(this.tb_lagerbestand);
            this.Controls.Add(this.tb_produktkategorie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_produktid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produkt_anlegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkt_anlegen";
            this.Load += new System.EventHandler(this.Produkt_anlegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PRspeichern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_produktid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_produktkategorie;
        private System.Windows.Forms.TextBox tb_lagerbestand;
        private System.Windows.Forms.TextBox tb_preis;
        private System.Windows.Forms.TextBox tb_bezeichnung;
        private System.Windows.Forms.PictureBox pb_PRspeichern;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
    }
}