namespace Fahrradladen_Gruppe1
{
    partial class Form_LBbuchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LBbuchen));
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_aktuellemenge = new System.Windows.Forms.TextBox();
            this.dgv_produkte = new System.Windows.Forms.DataGridView();
            this.btn_hinzufügen = new System.Windows.Forms.Button();
            this.btn_abziehen = new System.Windows.Forms.Button();
            this.tb_menge = new System.Windows.Forms.TextBox();
            this.rtb_Menge = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_lb10 = new System.Windows.Forms.RichTextBox();
            this.btn_TextClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_min.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.Color.White;
            this.lbl_min.Location = new System.Drawing.Point(919, -5);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 35;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            this.lbl_min.MouseHover += new System.EventHandler(this.lbl_min_MouseHover);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(938, -5);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 36;
            this.lbl_close.Text = "x";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            this.lbl_close.MouseHover += new System.EventHandler(this.lbl_close_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lagerbestände buchen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(470, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Menge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Produkte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(371, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "aktuelle Menge";
            // 
            // tb_aktuellemenge
            // 
            this.tb_aktuellemenge.Enabled = false;
            this.tb_aktuellemenge.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_aktuellemenge.Location = new System.Drawing.Point(541, 96);
            this.tb_aktuellemenge.Name = "tb_aktuellemenge";
            this.tb_aktuellemenge.Size = new System.Drawing.Size(360, 31);
            this.tb_aktuellemenge.TabIndex = 41;
            // 
            // dgv_produkte
            // 
            this.dgv_produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produkte.Location = new System.Drawing.Point(23, 160);
            this.dgv_produkte.Name = "dgv_produkte";
            this.dgv_produkte.Size = new System.Drawing.Size(427, 295);
            this.dgv_produkte.TabIndex = 42;
            this.dgv_produkte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_produkte_CellClick);
            // 
            // btn_hinzufügen
            // 
            this.btn_hinzufügen.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hinzufügen.Location = new System.Drawing.Point(541, 231);
            this.btn_hinzufügen.Name = "btn_hinzufügen";
            this.btn_hinzufügen.Size = new System.Drawing.Size(360, 32);
            this.btn_hinzufügen.TabIndex = 43;
            this.btn_hinzufügen.Text = "Menge hinzufügen";
            this.btn_hinzufügen.UseVisualStyleBackColor = true;
            this.btn_hinzufügen.Click += new System.EventHandler(this.btn_hinzufügen_Click);
            // 
            // btn_abziehen
            // 
            this.btn_abziehen.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abziehen.Location = new System.Drawing.Point(541, 294);
            this.btn_abziehen.Name = "btn_abziehen";
            this.btn_abziehen.Size = new System.Drawing.Size(360, 32);
            this.btn_abziehen.TabIndex = 44;
            this.btn_abziehen.Text = "Menge abziehen";
            this.btn_abziehen.UseVisualStyleBackColor = true;
            this.btn_abziehen.Click += new System.EventHandler(this.btn_abziehen_Click);
            // 
            // tb_menge
            // 
            this.tb_menge.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_menge.Location = new System.Drawing.Point(541, 160);
            this.tb_menge.Name = "tb_menge";
            this.tb_menge.Size = new System.Drawing.Size(360, 31);
            this.tb_menge.TabIndex = 45;
            this.tb_menge.Text = "1";
            // 
            // rtb_Menge
            // 
            this.rtb_Menge.Location = new System.Drawing.Point(541, 352);
            this.rtb_Menge.Name = "rtb_Menge";
            this.rtb_Menge.Size = new System.Drawing.Size(360, 96);
            this.rtb_Menge.TabIndex = 46;
            this.rtb_Menge.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(538, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Produkte bei denen der Lagerbestand unter 10 ist";
            // 
            // rtb_lb10
            // 
            this.rtb_lb10.Location = new System.Drawing.Point(23, 539);
            this.rtb_lb10.Name = "rtb_lb10";
            this.rtb_lb10.Size = new System.Drawing.Size(880, 96);
            this.rtb_lb10.TabIndex = 48;
            this.rtb_lb10.Text = "";
            // 
            // btn_TextClear
            // 
            this.btn_TextClear.Location = new System.Drawing.Point(541, 455);
            this.btn_TextClear.Name = "btn_TextClear";
            this.btn_TextClear.Size = new System.Drawing.Size(125, 23);
            this.btn_TextClear.TabIndex = 49;
            this.btn_TextClear.Text = "Textbox zurücksetzen";
            this.btn_TextClear.UseVisualStyleBackColor = true;
            this.btn_TextClear.Click += new System.EventHandler(this.btn_TextClear_Click);
            // 
            // Form_LBbuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(959, 674);
            this.Controls.Add(this.btn_TextClear);
            this.Controls.Add(this.rtb_lb10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_Menge);
            this.Controls.Add(this.tb_menge);
            this.Controls.Add(this.btn_abziehen);
            this.Controls.Add(this.btn_hinzufügen);
            this.Controls.Add(this.dgv_produkte);
            this.Controls.Add(this.tb_aktuellemenge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_LBbuchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lagerbeständebuchen";
            this.Load += new System.EventHandler(this.Lagerbeständebuchen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_aktuellemenge;
        private System.Windows.Forms.DataGridView dgv_produkte;
        private System.Windows.Forms.Button btn_hinzufügen;
        private System.Windows.Forms.Button btn_abziehen;
        private System.Windows.Forms.TextBox tb_menge;
        private System.Windows.Forms.RichTextBox rtb_Menge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_lb10;
        private System.Windows.Forms.Button btn_TextClear;
    }
}