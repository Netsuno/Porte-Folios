
namespace dessida
{
    partial class CalanIn
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
            this.DGVP = new System.Windows.Forms.DataGridView();
            this.DGVF = new System.Windows.Forms.DataGridView();
            this.DGVR = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Imprimé = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVR)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVP
            // 
            this.DGVP.AllowUserToAddRows = false;
            this.DGVP.AllowUserToDeleteRows = false;
            this.DGVP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVP.Location = new System.Drawing.Point(12, 63);
            this.DGVP.Name = "DGVP";
            this.DGVP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DGVP.Size = new System.Drawing.Size(418, 534);
            this.DGVP.TabIndex = 0;
            this.DGVP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // DGVF
            // 
            this.DGVF.AllowUserToAddRows = false;
            this.DGVF.AllowUserToDeleteRows = false;
            this.DGVF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVF.Location = new System.Drawing.Point(436, 63);
            this.DGVF.Name = "DGVF";
            this.DGVF.Size = new System.Drawing.Size(462, 534);
            this.DGVF.TabIndex = 1;
            // 
            // DGVR
            // 
            this.DGVR.AllowUserToAddRows = false;
            this.DGVR.AllowUserToDeleteRows = false;
            this.DGVR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVR.Location = new System.Drawing.Point(904, 63);
            this.DGVR.Name = "DGVR";
            this.DGVR.Size = new System.Drawing.Size(385, 534);
            this.DGVR.TabIndex = 2;
            this.DGVR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVR_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(167, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entretien Planifié";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(641, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entretien Fait";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1086, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Réparation";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.button2.Location = new System.Drawing.Point(1151, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 33;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.button1.Location = new System.Drawing.Point(716, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 32;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Imprimé
            // 
            this.Imprimé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.Imprimé.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Imprimé.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Imprimé.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.Imprimé.Location = new System.Drawing.Point(259, 12);
            this.Imprimé.Name = "Imprimé";
            this.Imprimé.Size = new System.Drawing.Size(46, 45);
            this.Imprimé.TabIndex = 31;
            this.Imprimé.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Imprimé.UseVisualStyleBackColor = false;
            this.Imprimé.Click += new System.EventHandler(this.Imprimé_Click);
            // 
            // CalanIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1301, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Imprimé);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVR);
            this.Controls.Add(this.DGVF);
            this.Controls.Add(this.DGVP);
            this.Name = "CalanIn";
            this.Text = "CalanIn";
            this.Load += new System.EventHandler(this.CalanIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVP;
        private System.Windows.Forms.DataGridView DGVF;
        private System.Windows.Forms.DataGridView DGVR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Imprimé;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}