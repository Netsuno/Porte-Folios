namespace dessida
{
    partial class LMachine
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Imprimé = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "Actualisé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 146);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(856, 625);
            this.dgv1.TabIndex = 29;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // Imprimé
            // 
            this.Imprimé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.Imprimé.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Imprimé.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Imprimé.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.Imprimé.Location = new System.Drawing.Point(822, 12);
            this.Imprimé.Name = "Imprimé";
            this.Imprimé.Size = new System.Drawing.Size(46, 45);
            this.Imprimé.TabIndex = 30;
            this.Imprimé.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Imprimé.UseVisualStyleBackColor = false;
            this.Imprimé.Click += new System.EventHandler(this.button2_Click);
            // 
            // LMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(880, 783);
            this.Controls.Add(this.Imprimé);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LMachine";
            this.Text = "LMachine";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button Imprimé;
    }
}