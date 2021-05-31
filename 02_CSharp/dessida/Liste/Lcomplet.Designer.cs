namespace dessida
{
    partial class Liste_complet
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
            this.button16 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Lime;
            this.button16.Location = new System.Drawing.Point(255, 35);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(145, 51);
            this.button16.TabIndex = 17;
            this.button16.Text = "Demande";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(47, 127);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(587, 628);
            this.dgv1.TabIndex = 18;
            // 
            // Liste_complet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(686, 796);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button16);
            this.Name = "Liste_complet";
            this.Text = "Liste_complet";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.DataGridView dgv1;
    }
}