namespace Fahrradladen_Gruppe1
{
    partial class Form_Konfigerstellen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Konfigerstellen));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.dgv_konfigprodukte = new System.Windows.Forms.DataGridView();
            this.btn_hinzufügen = new System.Windows.Forms.Button();
            this.btn_entfernen = new System.Windows.Forms.Button();
            this.tb_konfigid = new System.Windows.Forms.TextBox();
            this.tb_konfigname = new System.Windows.Forms.TextBox();
            this.dgv_produkte = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_kundenid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konfigprodukte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(744, -5);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 6;
            this.lbl_close.Text = "x";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_min.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.Color.White;
            this.lbl_min.Location = new System.Drawing.Point(716, -5);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 7;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            // 
            // dgv_konfigprodukte
            // 
            this.dgv_konfigprodukte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_konfigprodukte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_konfigprodukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_konfigprodukte.Location = new System.Drawing.Point(6, 300);
            this.dgv_konfigprodukte.Name = "dgv_konfigprodukte";
            this.dgv_konfigprodukte.Size = new System.Drawing.Size(736, 175);
            this.dgv_konfigprodukte.TabIndex = 16;
            // 
            // btn_hinzufügen
            // 
            this.btn_hinzufügen.Location = new System.Drawing.Point(8, 82);
            this.btn_hinzufügen.Name = "btn_hinzufügen";
            this.btn_hinzufügen.Size = new System.Drawing.Size(137, 32);
            this.btn_hinzufügen.TabIndex = 15;
            this.btn_hinzufügen.Text = "Hinzufügen";
            this.btn_hinzufügen.UseVisualStyleBackColor = true;
            this.btn_hinzufügen.Click += new System.EventHandler(this.btn_hinzufügen_Click);
            // 
            // btn_entfernen
            // 
            this.btn_entfernen.Location = new System.Drawing.Point(162, 81);
            this.btn_entfernen.Name = "btn_entfernen";
            this.btn_entfernen.Size = new System.Drawing.Size(137, 32);
            this.btn_entfernen.TabIndex = 18;
            this.btn_entfernen.Text = "Entfernen";
            this.btn_entfernen.UseVisualStyleBackColor = true;
            this.btn_entfernen.Click += new System.EventHandler(this.btn_entfernen_Click);
            // 
            // tb_konfigid
            // 
            this.tb_konfigid.Enabled = false;
            this.tb_konfigid.Location = new System.Drawing.Point(457, 43);
            this.tb_konfigid.Name = "tb_konfigid";
            this.tb_konfigid.Size = new System.Drawing.Size(133, 32);
            this.tb_konfigid.TabIndex = 22;
            // 
            // tb_konfigname
            // 
            this.tb_konfigname.Location = new System.Drawing.Point(162, 43);
            this.tb_konfigname.Name = "tb_konfigname";
            this.tb_konfigname.Size = new System.Drawing.Size(289, 32);
            this.tb_konfigname.TabIndex = 14;
            // 
            // dgv_produkte
            // 
            this.dgv_produkte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_produkte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produkte.Location = new System.Drawing.Point(6, 120);
            this.dgv_produkte.Name = "dgv_produkte";
            this.dgv_produkte.Size = new System.Drawing.Size(736, 174);
            this.dgv_produkte.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(454, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "KonfigurationsID";
            // 
            // tb_kundenid
            // 
            this.tb_kundenid.Location = new System.Drawing.Point(8, 43);
            this.tb_kundenid.Name = "tb_kundenid";
            this.tb_kundenid.Size = new System.Drawing.Size(137, 32);
            this.tb_kundenid.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Konfigurationsname";
            // 
            // btn_speichern
            // 
            this.btn_speichern.Location = new System.Drawing.Point(305, 82);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(146, 32);
            this.btn_speichern.TabIndex = 21;
            this.btn_speichern.Text = "Speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "KundenID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_speichern);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_kundenid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgv_produkte);
            this.groupBox1.Controls.Add(this.tb_konfigname);
            this.groupBox1.Controls.Add(this.tb_konfigid);
            this.groupBox1.Controls.Add(this.btn_entfernen);
            this.groupBox1.Controls.Add(this.btn_hinzufügen);
            this.groupBox1.Controls.Add(this.dgv_konfigprodukte);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 485);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konfiguration erstellen";
            // 
            // Form_Konfigerstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(764, 533);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Konfigerstellen";
            this.Text = "Form_Konfigerstellen";
            this.Load += new System.EventHandler(this.Form_Konfigerstellen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konfigprodukte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.DataGridView dgv_konfigprodukte;
        private System.Windows.Forms.Button btn_hinzufügen;
        private System.Windows.Forms.Button btn_entfernen;
        private System.Windows.Forms.TextBox tb_konfigid;
        private System.Windows.Forms.TextBox tb_konfigname;
        private System.Windows.Forms.DataGridView dgv_produkte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_kundenid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_speichern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}