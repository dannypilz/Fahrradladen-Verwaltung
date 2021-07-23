namespace Fahrradladen_Gruppe1
{
    partial class Form_Mitarbeiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mitarbeiter));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.dgv_MAview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_suchen = new System.Windows.Forms.TextBox();
            this.pb_delete = new System.Windows.Forms.PictureBox();
            this.pb_MAerstellen = new System.Windows.Forms.PictureBox();
            this.pb_suchen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MAview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MAerstellen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suchen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(600, -5);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 39;
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
            this.lbl_min.Location = new System.Drawing.Point(581, -5);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 38;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // dgv_MAview
            // 
            this.dgv_MAview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MAview.Location = new System.Drawing.Point(13, 80);
            this.dgv_MAview.Name = "dgv_MAview";
            this.dgv_MAview.Size = new System.Drawing.Size(527, 258);
            this.dgv_MAview.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mitarbeitername";
            // 
            // tb_suchen
            // 
            this.tb_suchen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_suchen.Location = new System.Drawing.Point(12, 39);
            this.tb_suchen.Name = "tb_suchen";
            this.tb_suchen.Size = new System.Drawing.Size(596, 32);
            this.tb_suchen.TabIndex = 43;
            // 
            // pb_delete
            // 
            this.pb_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_delete.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Entfernen;
            this.pb_delete.Location = new System.Drawing.Point(548, 278);
            this.pb_delete.Name = "pb_delete";
            this.pb_delete.Size = new System.Drawing.Size(60, 60);
            this.pb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_delete.TabIndex = 48;
            this.pb_delete.TabStop = false;
            this.pb_delete.Click += new System.EventHandler(this.pb_delete_Click_1);
            this.pb_delete.MouseHover += new System.EventHandler(this.pb_delete_MouseHover);
            // 
            // pb_MAerstellen
            // 
            this.pb_MAerstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MAerstellen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Kunden_erstellen;
            this.pb_MAerstellen.Location = new System.Drawing.Point(548, 170);
            this.pb_MAerstellen.Name = "pb_MAerstellen";
            this.pb_MAerstellen.Size = new System.Drawing.Size(60, 60);
            this.pb_MAerstellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MAerstellen.TabIndex = 47;
            this.pb_MAerstellen.TabStop = false;
            this.pb_MAerstellen.Click += new System.EventHandler(this.pb_MAerstellen_Click);
            this.pb_MAerstellen.MouseHover += new System.EventHandler(this.pb_MAerstellen_MouseHover);
            // 
            // pb_suchen
            // 
            this.pb_suchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_suchen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Suchen;
            this.pb_suchen.Location = new System.Drawing.Point(548, 74);
            this.pb_suchen.Name = "pb_suchen";
            this.pb_suchen.Size = new System.Drawing.Size(60, 50);
            this.pb_suchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_suchen.TabIndex = 45;
            this.pb_suchen.TabStop = false;
            this.pb_suchen.Click += new System.EventHandler(this.pb_suchen_Click);
            this.pb_suchen.MouseHover += new System.EventHandler(this.pb_suchen_MouseHover);
            // 
            // Form_Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.pb_delete);
            this.Controls.Add(this.pb_MAerstellen);
            this.Controls.Add(this.dgv_MAview);
            this.Controls.Add(this.pb_suchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_suchen);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Mitarbeiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mitarbeiter";
            this.Load += new System.EventHandler(this.Form_Mitarbeiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MAview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MAerstellen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suchen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.DataGridView dgv_MAview;
        private System.Windows.Forms.PictureBox pb_suchen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_suchen;
        private System.Windows.Forms.PictureBox pb_MAerstellen;
        private System.Windows.Forms.PictureBox pb_delete;
    }
}