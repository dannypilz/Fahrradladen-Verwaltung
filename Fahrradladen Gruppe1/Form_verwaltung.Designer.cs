namespace Fahrradladen_Gruppe1
{
    partial class Form_Verwaltung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Verwaltung));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.pb_REerstellen = new System.Windows.Forms.PictureBox();
            this.pb_MAerstellen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_REerstellen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MAerstellen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(598, -4);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 7;
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
            this.lbl_min.Location = new System.Drawing.Point(579, -4);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 6;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // pb_REerstellen
            // 
            this.pb_REerstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_REerstellen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Rechnung_erstellen;
            this.pb_REerstellen.Location = new System.Drawing.Point(107, 111);
            this.pb_REerstellen.Name = "pb_REerstellen";
            this.pb_REerstellen.Size = new System.Drawing.Size(130, 130);
            this.pb_REerstellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_REerstellen.TabIndex = 8;
            this.pb_REerstellen.TabStop = false;
            this.pb_REerstellen.Click += new System.EventHandler(this.pb_REerstellen_Click);
            this.pb_REerstellen.MouseHover += new System.EventHandler(this.pb_REerstellen_MouseHover);
            // 
            // pb_MAerstellen
            // 
            this.pb_MAerstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MAerstellen.Image = global::Fahrradladen_Gruppe1.Properties.Resources.Kunden_erstellen;
            this.pb_MAerstellen.Location = new System.Drawing.Point(386, 111);
            this.pb_MAerstellen.Name = "pb_MAerstellen";
            this.pb_MAerstellen.Size = new System.Drawing.Size(130, 130);
            this.pb_MAerstellen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MAerstellen.TabIndex = 9;
            this.pb_MAerstellen.TabStop = false;
            this.pb_MAerstellen.Click += new System.EventHandler(this.pb_MAerstellen_Click);
            this.pb_MAerstellen.MouseHover += new System.EventHandler(this.pb_MAerstellen_MouseHover);
            // 
            // Form_Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.pb_MAerstellen);
            this.Controls.Add(this.pb_REerstellen);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Verwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_verwaltung";
            this.Load += new System.EventHandler(this.Form_Verwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_REerstellen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MAerstellen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.PictureBox pb_REerstellen;
        private System.Windows.Forms.PictureBox pb_MAerstellen;
    }
}