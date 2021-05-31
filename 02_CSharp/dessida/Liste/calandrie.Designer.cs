
namespace dessida
{
    partial class calandrie
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
            this.CBAnnee = new System.Windows.Forms.ComboBox();
            this.CBMois = new System.Windows.Forms.ComboBox();
            this.DGVT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVT)).BeginInit();
            this.SuspendLayout();
            // 
            // CBAnnee
            // 
            this.CBAnnee.FormattingEnabled = true;
            this.CBAnnee.Location = new System.Drawing.Point(140, 32);
            this.CBAnnee.Name = "CBAnnee";
            this.CBAnnee.Size = new System.Drawing.Size(175, 21);
            this.CBAnnee.TabIndex = 0;
            this.CBAnnee.SelectedIndexChanged += new System.EventHandler(this.CBAnnee_SelectedIndexChanged);
            // 
            // CBMois
            // 
            this.CBMois.FormattingEnabled = true;
            this.CBMois.Location = new System.Drawing.Point(140, 77);
            this.CBMois.Name = "CBMois";
            this.CBMois.Size = new System.Drawing.Size(175, 21);
            this.CBMois.TabIndex = 1;
            // 
            // DGVT
            // 
            this.DGVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVT.Location = new System.Drawing.Point(391, 32);
            this.DGVT.Name = "DGVT";
            this.DGVT.Size = new System.Drawing.Size(397, 406);
            this.DGVT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Annee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mois";
            // 
            // calandrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVT);
            this.Controls.Add(this.CBMois);
            this.Controls.Add(this.CBAnnee);
            this.Name = "calandrie";
            this.Text = "Calendrier";
            this.Load += new System.EventHandler(this.calandrie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBAnnee;
        private System.Windows.Forms.ComboBox CBMois;
        private System.Windows.Forms.DataGridView DGVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}