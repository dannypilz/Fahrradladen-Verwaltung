namespace Fahrradladen_Gruppe1
{
    partial class Form_Rechnungerstellen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rechnungerstellen));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.dgv_Kundenview = new System.Windows.Forms.DataGridView();
            this.pb_suchen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_suchen = new System.Windows.Forms.TextBox();
            this.pb_REerstellen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kundenview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_REerstellen)).BeginInit();
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
            this.lbl_close.TabIndex = 9;
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
            this.lbl_min.TabIndex = 8;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // dgv_Kundenview
            // 
            this.dgv_Kundenview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kundenview.Location = new System.Drawing.Point(10, 86);
            this.dgv_Kundenview.Name = "dgv_Kundenview";
            this.dgv_Kundenview.Size = new System.Drawing.Size(527, 100);
            this.dgv_Kundenview.TabIndex = 16;

            // 
            // pb_suchen
            // 
            this.pb_suchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_suchen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Suchen;
            this.pb_suchen.Location = new System.Drawing.Point(543, 83);
            this.pb_suchen.Name = "pb_suchen";
            this.pb_suchen.Size = new System.Drawing.Size(60, 50);
            this.pb_suchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_suchen.TabIndex = 15;
            this.pb_suchen.TabStop = false;
            this.pb_suchen.Click += new System.EventHandler(this.pb_suchen_Click);
            this.pb_suchen.MouseHover += new System.EventHandler(this.pb_suchen_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kundenname";
            // 
            // tb_suchen
            // 
            this.tb_suchen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_suchen.Location = new System.Drawing.Point(9, 45);
            this.tb_suchen.Name = "tb_suchen";
            this.tb_suchen.Size = new System.Drawing.Size(596, 32);
            this.tb_suchen.TabIndex = 13;
            // 
            // pb_REerstellen
            // 
            this.pb_REerstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_REerstellen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Rechnung_erstellen;
            this.pb_REerstellen.Location = new System.Drawing.Point(13, 238);
            this.pb_REerstellen.Name = "pb_REerstellen";
            this.pb_REerstellen.Size = new System.Drawing.Size(100, 100);
            this.pb_REerstellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_REerstellen.TabIndex = 17;
            this.pb_REerstellen.TabStop = false;
            this.pb_REerstellen.Click += new System.EventHandler(this.pb_REerstellen_Click);
            this.pb_REerstellen.MouseHover += new System.EventHandler(this.pb_REerstellen_MouseHover);
            // 
            // Form_Rechnungerstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.pb_REerstellen);
            this.Controls.Add(this.dgv_Kundenview);
            this.Controls.Add(this.pb_suchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_suchen);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Rechnungerstellen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Rechnungerstellen";
            this.Load += new System.EventHandler(this.Form_Rechnungerstellen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kundenview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_suchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_REerstellen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.DataGridView dgv_Kundenview;
        private System.Windows.Forms.PictureBox pb_suchen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_suchen;
        private System.Windows.Forms.PictureBox pb_REerstellen;
    }
}