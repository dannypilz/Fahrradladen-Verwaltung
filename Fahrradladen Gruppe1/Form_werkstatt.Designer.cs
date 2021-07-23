namespace Fahrradladen_Gruppe1
{
    partial class Form_Werkstatt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Werkstatt));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.pb_Regelerstellen = new System.Windows.Forms.PictureBox();
            this.pb_Produkte = new System.Windows.Forms.PictureBox();
            this.pb_Lagerbestand = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Regelerstellen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Produkte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lagerbestand)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(600, -4);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 8;
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
            this.lbl_min.Location = new System.Drawing.Point(581, -4);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 7;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Close);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // pb_Regelerstellen
            // 
            this.pb_Regelerstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Regelerstellen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Regel_erstellen;
            this.pb_Regelerstellen.Location = new System.Drawing.Point(424, 103);
            this.pb_Regelerstellen.Name = "pb_Regelerstellen";
            this.pb_Regelerstellen.Size = new System.Drawing.Size(130, 130);
            this.pb_Regelerstellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Regelerstellen.TabIndex = 0;
            this.pb_Regelerstellen.TabStop = false;
            this.pb_Regelerstellen.Click += new System.EventHandler(this.pb_Regelerstellen_Click);
            this.pb_Regelerstellen.MouseHover += new System.EventHandler(this.pb_Regelerstellen_MouseHover);
            // 
            // pb_Produkte
            // 
            this.pb_Produkte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Produkte.ErrorImage = global::Fahrradladen_Gruppe1.Properties.Resources.product;
            this.pb_Produkte.Image = ((System.Drawing.Image)(resources.GetObject("pb_Produkte.Image")));
            this.pb_Produkte.Location = new System.Drawing.Point(242, 103);
            this.pb_Produkte.Name = "pb_Produkte";
            this.pb_Produkte.Size = new System.Drawing.Size(130, 130);
            this.pb_Produkte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Produkte.TabIndex = 9;
            this.pb_Produkte.TabStop = false;
            this.pb_Produkte.Click += new System.EventHandler(this.pb_Produkte_Click);
            this.pb_Produkte.MouseHover += new System.EventHandler(this.pb_Produkte_MouseHover);
            // 
            // pb_Lagerbestand
            // 
            this.pb_Lagerbestand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Lagerbestand.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Konfigurator;
            this.pb_Lagerbestand.Location = new System.Drawing.Point(59, 103);
            this.pb_Lagerbestand.Name = "pb_Lagerbestand";
            this.pb_Lagerbestand.Size = new System.Drawing.Size(130, 130);
            this.pb_Lagerbestand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Lagerbestand.TabIndex = 6;
            this.pb_Lagerbestand.TabStop = false;
            this.pb_Lagerbestand.Click += new System.EventHandler(this.pb_Lagerbestand_Click);
            this.pb_Lagerbestand.MouseHover += new System.EventHandler(this.pb_Lagerbestand_MouseHover);
            // 
            // Form_Werkstatt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.pb_Regelerstellen);
            this.Controls.Add(this.pb_Produkte);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.pb_Lagerbestand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Werkstatt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_werkstatt";
            this.Load += new System.EventHandler(this.Form_Werkstatt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Regelerstellen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Produkte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lagerbestand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Lagerbestand;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.PictureBox pb_Produkte;
        private System.Windows.Forms.PictureBox pb_Regelerstellen;
    }
}