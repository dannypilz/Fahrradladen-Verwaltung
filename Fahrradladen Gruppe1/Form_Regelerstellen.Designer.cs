namespace Fahrradladen_Gruppe1
{
    partial class Form_Regelerstellen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Regelerstellen));
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_regel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_teilb = new System.Windows.Forms.TextBox();
            this.tb_teila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_produkte = new System.Windows.Forms.DataGridView();
            this.btn_erstellen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(633, -4);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 37;
            this.lbl_close.Text = "x";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click_1);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_min.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.Color.White;
            this.lbl_min.Location = new System.Drawing.Point(614, -4);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 36;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgv_regel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_teilb);
            this.groupBox1.Controls.Add(this.tb_teila);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_produkte);
            this.groupBox1.Controls.Add(this.btn_erstellen);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 404);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regel erstellen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bestehende Regeln";
            // 
            // dgv_regel
            // 
            this.dgv_regel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_regel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_regel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_regel.Location = new System.Drawing.Point(372, 54);
            this.dgv_regel.Name = "dgv_regel";
            this.dgv_regel.Size = new System.Drawing.Size(241, 157);
            this.dgv_regel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teil B";
            // 
            // tb_teilb
            // 
            this.tb_teilb.Location = new System.Drawing.Point(115, 75);
            this.tb_teilb.Name = "tb_teilb";
            this.tb_teilb.Size = new System.Drawing.Size(182, 32);
            this.tb_teilb.TabIndex = 4;
            // 
            // tb_teila
            // 
            this.tb_teila.Location = new System.Drawing.Point(115, 31);
            this.tb_teila.Name = "tb_teila";
            this.tb_teila.Size = new System.Drawing.Size(182, 32);
            this.tb_teila.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teil A";
            // 
            // dgv_produkte
            // 
            this.dgv_produkte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_produkte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produkte.Location = new System.Drawing.Point(6, 217);
            this.dgv_produkte.Name = "dgv_produkte";
            this.dgv_produkte.Size = new System.Drawing.Size(607, 181);
            this.dgv_produkte.TabIndex = 1;
            // 
            // btn_erstellen
            // 
            this.btn_erstellen.Location = new System.Drawing.Point(19, 163);
            this.btn_erstellen.Name = "btn_erstellen";
            this.btn_erstellen.Size = new System.Drawing.Size(212, 33);
            this.btn_erstellen.TabIndex = 0;
            this.btn_erstellen.Text = "Regel erstellen";
            this.btn_erstellen.UseVisualStyleBackColor = true;
            this.btn_erstellen.Click += new System.EventHandler(this.btn_erstellen_Click);
            // 
            // Form_Regelerstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(652, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form_Regelerstellen";
            this.Text = "Form_Regelerstellen";
            this.Load += new System.EventHandler(this.Form_Regelerstellen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_teilb;
        private System.Windows.Forms.TextBox tb_teila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_produkte;
        private System.Windows.Forms.Button btn_erstellen;
        private System.Windows.Forms.DataGridView dgv_regel;
        private System.Windows.Forms.Label label3;
    }
}