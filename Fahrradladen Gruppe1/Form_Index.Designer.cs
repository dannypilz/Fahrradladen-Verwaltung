namespace Fahrradladen_Gruppe1
{
    partial class Form_Index
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Index));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.pb_Laden = new System.Windows.Forms.PictureBox();
            this.pb_Verwaltung = new System.Windows.Forms.PictureBox();
            this.pb_Werkstatt = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Laden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Verwaltung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Werkstatt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(599, -4);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 3;
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
            this.lbl_min.Location = new System.Drawing.Point(580, -4);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 2;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // pb_Laden
            // 
            this.pb_Laden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Laden.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Ladenbild;
            this.pb_Laden.Location = new System.Drawing.Point(433, 113);
            this.pb_Laden.Name = "pb_Laden";
            this.pb_Laden.Size = new System.Drawing.Size(142, 135);
            this.pb_Laden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Laden.TabIndex = 6;
            this.pb_Laden.TabStop = false;
            this.pb_Laden.Click += new System.EventHandler(this.pb_Laden_Click);
            this.pb_Laden.MouseHover += new System.EventHandler(this.pb_Laden_MouseHover);
            // 
            // pb_Verwaltung
            // 
            this.pb_Verwaltung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Verwaltung.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Verwaltung;
            this.pb_Verwaltung.Location = new System.Drawing.Point(242, 113);
            this.pb_Verwaltung.Name = "pb_Verwaltung";
            this.pb_Verwaltung.Size = new System.Drawing.Size(142, 135);
            this.pb_Verwaltung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Verwaltung.TabIndex = 5;
            this.pb_Verwaltung.TabStop = false;
            this.pb_Verwaltung.Click += new System.EventHandler(this.pb_Verwaltung_Click);
            this.pb_Verwaltung.MouseHover += new System.EventHandler(this.pb_Verwaltung_MouseHover);
            // 
            // pb_Werkstatt
            // 
            this.pb_Werkstatt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Werkstatt.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Werkstattbild;
            this.pb_Werkstatt.Location = new System.Drawing.Point(49, 113);
            this.pb_Werkstatt.Name = "pb_Werkstatt";
            this.pb_Werkstatt.Size = new System.Drawing.Size(142, 135);
            this.pb_Werkstatt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Werkstatt.TabIndex = 4;
            this.pb_Werkstatt.TabStop = false;
            this.pb_Werkstatt.Click += new System.EventHandler(this.pb_Werkstatt_Click);
            this.pb_Werkstatt.MouseHover += new System.EventHandler(this.pb_Werkstatt_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wählen Sie einen Bereich aus!\r\n";
            // 
            // Form_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_Laden);
            this.Controls.Add(this.pb_Verwaltung);
            this.Controls.Add(this.pb_Werkstatt);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Laden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Verwaltung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Werkstatt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.PictureBox pb_Werkstatt;
        private System.Windows.Forms.PictureBox pb_Verwaltung;
        private System.Windows.Forms.PictureBox pb_Laden;
        private System.Windows.Forms.Label label3;
    }
}

