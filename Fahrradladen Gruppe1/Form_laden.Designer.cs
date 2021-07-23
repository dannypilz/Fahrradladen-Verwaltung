namespace Fahrradladen_Gruppe1
{
    partial class Form_Laden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Laden));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.tb_suchen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Kundenview = new System.Windows.Forms.DataGridView();
            this.pb_Konfigerstellen = new System.Windows.Forms.PictureBox();
            this.pb_delete = new System.Windows.Forms.PictureBox();
            this.pb_BEaufnehmen = new System.Windows.Forms.PictureBox();
            this.pb_Kerstellen = new System.Windows.Forms.PictureBox();
            this.pb_suchen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kundenview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Konfigerstellen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BEaufnehmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kerstellen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suchen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(598, -3);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 5;
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
            this.lbl_min.Location = new System.Drawing.Point(579, -3);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 4;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // tb_suchen
            // 
            this.tb_suchen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_suchen.Location = new System.Drawing.Point(12, 53);
            this.tb_suchen.Name = "tb_suchen";
            this.tb_suchen.Size = new System.Drawing.Size(596, 32);
            this.tb_suchen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kundenname";
            // 
            // dgv_Kundenview
            // 
            this.dgv_Kundenview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kundenview.Location = new System.Drawing.Point(13, 94);
            this.dgv_Kundenview.Name = "dgv_Kundenview";
            this.dgv_Kundenview.Size = new System.Drawing.Size(527, 100);
            this.dgv_Kundenview.TabIndex = 12;
            // 
            // pb_Konfigerstellen
            // 
            this.pb_Konfigerstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Konfigerstellen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Konfigurator;
            this.pb_Konfigerstellen.Location = new System.Drawing.Point(132, 200);
            this.pb_Konfigerstellen.Name = "pb_Konfigerstellen";
            this.pb_Konfigerstellen.Size = new System.Drawing.Size(150, 150);
            this.pb_Konfigerstellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Konfigerstellen.TabIndex = 15;
            this.pb_Konfigerstellen.TabStop = false;
            this.pb_Konfigerstellen.Click += new System.EventHandler(this.pb_Konfigerstellen_Click);
            this.pb_Konfigerstellen.MouseHover += new System.EventHandler(this.pb_Konfigerstellen_MouseHover);
            // 
            // pb_delete
            // 
            this.pb_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_delete.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Entfernen;
            this.pb_delete.Location = new System.Drawing.Point(528, 258);
            this.pb_delete.Name = "pb_delete";
            this.pb_delete.Size = new System.Drawing.Size(80, 80);
            this.pb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_delete.TabIndex = 14;
            this.pb_delete.TabStop = false;
            this.pb_delete.Click += new System.EventHandler(this.pb_delete_Click);
            this.pb_delete.MouseHover += new System.EventHandler(this.pb_delete_MouseHover_1);
            // 
            // pb_BEaufnehmen
            // 
            this.pb_BEaufnehmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_BEaufnehmen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Bestellung_aufnehmen;
            this.pb_BEaufnehmen.Location = new System.Drawing.Point(337, 200);
            this.pb_BEaufnehmen.Name = "pb_BEaufnehmen";
            this.pb_BEaufnehmen.Size = new System.Drawing.Size(150, 150);
            this.pb_BEaufnehmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_BEaufnehmen.TabIndex = 13;
            this.pb_BEaufnehmen.TabStop = false;
            this.pb_BEaufnehmen.Click += new System.EventHandler(this.pb_BEaufnehmen_Click);
            this.pb_BEaufnehmen.MouseHover += new System.EventHandler(this.pb_BEaufnehmen_MouseHover);
            // 
            // pb_Kerstellen
            // 
            this.pb_Kerstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Kerstellen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Kunden_erstellen;
            this.pb_Kerstellen.Location = new System.Drawing.Point(13, 258);
            this.pb_Kerstellen.Name = "pb_Kerstellen";
            this.pb_Kerstellen.Size = new System.Drawing.Size(80, 80);
            this.pb_Kerstellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Kerstellen.TabIndex = 11;
            this.pb_Kerstellen.TabStop = false;
            this.pb_Kerstellen.Click += new System.EventHandler(this.pb_Kerstellen_Click);
            this.pb_Kerstellen.MouseHover += new System.EventHandler(this.pb_Kerstellen_MouseHover);
            // 
            // pb_suchen
            // 
            this.pb_suchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_suchen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Suchen;
            this.pb_suchen.Location = new System.Drawing.Point(548, 88);
            this.pb_suchen.Name = "pb_suchen";
            this.pb_suchen.Size = new System.Drawing.Size(60, 50);
            this.pb_suchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_suchen.TabIndex = 10;
            this.pb_suchen.TabStop = false;
            this.pb_suchen.Click += new System.EventHandler(this.pb_suchen_Click);
            this.pb_suchen.MouseHover += new System.EventHandler(this.pb_suchen_MouseHover);
            // 
            // Form_Laden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.pb_Konfigerstellen);
            this.Controls.Add(this.pb_delete);
            this.Controls.Add(this.pb_BEaufnehmen);
            this.Controls.Add(this.dgv_Kundenview);
            this.Controls.Add(this.pb_Kerstellen);
            this.Controls.Add(this.pb_suchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_suchen);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Laden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laden";
            this.Load += new System.EventHandler(this.Form_laden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kundenview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Konfigerstellen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BEaufnehmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Kerstellen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suchen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.TextBox tb_suchen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_suchen;
        private System.Windows.Forms.PictureBox pb_Kerstellen;
        private System.Windows.Forms.DataGridView dgv_Kundenview;
        private System.Windows.Forms.PictureBox pb_BEaufnehmen;
        private System.Windows.Forms.PictureBox pb_delete;
        private System.Windows.Forms.PictureBox pb_Konfigerstellen;
    }
}