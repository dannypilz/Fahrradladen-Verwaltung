namespace Fahrradladen_Gruppe1
{
    partial class Form_Kaufvorschläge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kaufvorschläge));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_konfig = new System.Windows.Forms.DataGridView();
            this.dgv_konfigdetails = new System.Windows.Forms.DataGridView();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konfigdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_konfig);
            this.groupBox1.Controls.Add(this.dgv_konfigdetails);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 402);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kauf Vorschläge";
            // 
            // dgv_konfig
            // 
            this.dgv_konfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_konfig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_konfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_konfig.Location = new System.Drawing.Point(6, 31);
            this.dgv_konfig.Name = "dgv_konfig";
            this.dgv_konfig.Size = new System.Drawing.Size(750, 176);
            this.dgv_konfig.TabIndex = 35;
            this.dgv_konfig.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_konfig_CellContentDoubleClick);
            // 
            // dgv_konfigdetails
            // 
            this.dgv_konfigdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_konfigdetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_konfigdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_konfigdetails.Location = new System.Drawing.Point(6, 220);
            this.dgv_konfigdetails.Name = "dgv_konfigdetails";
            this.dgv_konfigdetails.Size = new System.Drawing.Size(750, 176);
            this.dgv_konfigdetails.TabIndex = 34;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(762, -4);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(22, 24);
            this.lbl_close.TabIndex = 33;
            this.lbl_close.Text = "x";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_min.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.Color.White;
            this.lbl_min.Location = new System.Drawing.Point(743, -4);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(22, 24);
            this.lbl_min.TabIndex = 32;
            this.lbl_min.Text = "-";
            this.lbl_min.Click += new System.EventHandler(this.lbl_min_Click);
            // 
            // Form_Kaufvorschläge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 426);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Kaufvorschläge";
            this.Text = "Form_kaufvorschläge";
            this.Load += new System.EventHandler(this.Form_kaufvorschläge_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konfigdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.DataGridView dgv_konfig;
        private System.Windows.Forms.DataGridView dgv_konfigdetails;
    }
}