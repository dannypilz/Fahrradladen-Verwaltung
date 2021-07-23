namespace Fahrradladen_Gruppe1
{
    partial class Form_BEaufnehmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BEaufnehmen));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_entfernen = new System.Windows.Forms.Button();
            this.tb_BestellID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_GP = new System.Windows.Forms.TextBox();
            this.btn_BEaufgeben = new System.Windows.Forms.Button();
            this.btn_hinzufügen = new System.Windows.Forms.Button();
            this.dgv_Warenkorb = new System.Windows.Forms.DataGridView();
            this.tb_KundenID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_AlleProdukte = new System.Windows.Forms.DataGridView();
            this.btn_vorschläge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Warenkorb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlleProdukte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(1126, -4);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 31;
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
            this.lbl_min.Location = new System.Drawing.Point(1107, -4);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 30;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_vorschläge);
            this.groupBox1.Controls.Add(this.btn_entfernen);
            this.groupBox1.Controls.Add(this.tb_BestellID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_GP);
            this.groupBox1.Controls.Add(this.btn_BEaufgeben);
            this.groupBox1.Controls.Add(this.btn_hinzufügen);
            this.groupBox1.Controls.Add(this.dgv_Warenkorb);
            this.groupBox1.Controls.Add(this.tb_KundenID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_AlleProdukte);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 523);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bestellung aufnehmen";
            // 
            // btn_entfernen
            // 
            this.btn_entfernen.ForeColor = System.Drawing.Color.Black;
            this.btn_entfernen.Location = new System.Drawing.Point(696, 132);
            this.btn_entfernen.Name = "btn_entfernen";
            this.btn_entfernen.Size = new System.Drawing.Size(409, 43);
            this.btn_entfernen.TabIndex = 10;
            this.btn_entfernen.Text = "Entfernen";
            this.btn_entfernen.UseVisualStyleBackColor = true;
            this.btn_entfernen.Click += new System.EventHandler(this.btn_entfernen_Click);
            // 
            // tb_BestellID
            // 
            this.tb_BestellID.Enabled = false;
            this.tb_BestellID.Location = new System.Drawing.Point(696, 30);
            this.tb_BestellID.Name = "tb_BestellID";
            this.tb_BestellID.Size = new System.Drawing.Size(409, 32);
            this.tb_BestellID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(474, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bestellungs ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aktueller Preis";
            // 
            // tb_GP
            // 
            this.tb_GP.Enabled = false;
            this.tb_GP.Location = new System.Drawing.Point(897, 258);
            this.tb_GP.Name = "tb_GP";
            this.tb_GP.Size = new System.Drawing.Size(208, 32);
            this.tb_GP.TabIndex = 6;
            this.tb_GP.Text = "0";
            // 
            // btn_BEaufgeben
            // 
            this.btn_BEaufgeben.ForeColor = System.Drawing.Color.Black;
            this.btn_BEaufgeben.Location = new System.Drawing.Point(696, 194);
            this.btn_BEaufgeben.Name = "btn_BEaufgeben";
            this.btn_BEaufgeben.Size = new System.Drawing.Size(409, 43);
            this.btn_BEaufgeben.TabIndex = 5;
            this.btn_BEaufgeben.Text = "Bestellung aufgeben";
            this.btn_BEaufgeben.UseVisualStyleBackColor = true;
            this.btn_BEaufgeben.Click += new System.EventHandler(this.btn_BEaufgeben_Click);
            // 
            // btn_hinzufügen
            // 
            this.btn_hinzufügen.ForeColor = System.Drawing.Color.Black;
            this.btn_hinzufügen.Location = new System.Drawing.Point(696, 73);
            this.btn_hinzufügen.Name = "btn_hinzufügen";
            this.btn_hinzufügen.Size = new System.Drawing.Size(409, 43);
            this.btn_hinzufügen.TabIndex = 4;
            this.btn_hinzufügen.Text = "Hinzufügen";
            this.btn_hinzufügen.UseVisualStyleBackColor = true;
            this.btn_hinzufügen.Click += new System.EventHandler(this.btn_hinzufügen_Click);
            // 
            // dgv_Warenkorb
            // 
            this.dgv_Warenkorb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Warenkorb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Warenkorb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Warenkorb.Location = new System.Drawing.Point(15, 311);
            this.dgv_Warenkorb.Name = "dgv_Warenkorb";
            this.dgv_Warenkorb.Size = new System.Drawing.Size(1090, 198);
            this.dgv_Warenkorb.TabIndex = 3;
            // 
            // tb_KundenID
            // 
            this.tb_KundenID.Location = new System.Drawing.Point(128, 30);
            this.tb_KundenID.Name = "tb_KundenID";
            this.tb_KundenID.Size = new System.Drawing.Size(190, 32);
            this.tb_KundenID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "KundenID";
            // 
            // dgv_AlleProdukte
            // 
            this.dgv_AlleProdukte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv_AlleProdukte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_AlleProdukte.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_AlleProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AlleProdukte.Location = new System.Drawing.Point(15, 73);
            this.dgv_AlleProdukte.Name = "dgv_AlleProdukte";
            this.dgv_AlleProdukte.RowTemplate.Height = 20;
            this.dgv_AlleProdukte.RowTemplate.ReadOnly = true;
            this.dgv_AlleProdukte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AlleProdukte.Size = new System.Drawing.Size(633, 217);
            this.dgv_AlleProdukte.TabIndex = 4;
            // 
            // btn_vorschläge
            // 
            this.btn_vorschläge.Location = new System.Drawing.Point(324, 29);
            this.btn_vorschläge.Name = "btn_vorschläge";
            this.btn_vorschläge.Size = new System.Drawing.Size(144, 32);
            this.btn_vorschläge.TabIndex = 11;
            this.btn_vorschläge.Text = "Vorschläge";
            this.btn_vorschläge.UseVisualStyleBackColor = true;
            this.btn_vorschläge.Click += new System.EventHandler(this.btn_vorschläge_Click);
            // 
            // Form_BEaufnehmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1148, 540);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BEaufnehmen";
            this.Text = "Bestellung_aufnehmen";
            this.Load += new System.EventHandler(this.Bestellung_aufnehmen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Warenkorb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlleProdukte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Warenkorb;
        private System.Windows.Forms.TextBox tb_KundenID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_AlleProdukte;
        private System.Windows.Forms.Button btn_hinzufügen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_GP;
        private System.Windows.Forms.Button btn_BEaufgeben;
        private System.Windows.Forms.TextBox tb_BestellID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_entfernen;
        private System.Windows.Forms.Button btn_vorschläge;
    }
}