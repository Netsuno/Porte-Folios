namespace dessida
{
    partial class Amaintenance
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
            this.machine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entretien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commen = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // machine
            // 
            this.machine.FormattingEnabled = true;
            this.machine.Location = new System.Drawing.Point(141, 53);
            this.machine.Name = "machine";
            this.machine.Size = new System.Drawing.Size(225, 21);
            this.machine.TabIndex = 11;
            this.machine.SelectedIndexChanged += new System.EventHandler(this.machine_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Machine";
            // 
            // entretien
            // 
            this.entretien.FormattingEnabled = true;
            this.entretien.Location = new System.Drawing.Point(141, 113);
            this.entretien.Name = "entretien";
            this.entretien.Size = new System.Drawing.Size(225, 21);
            this.entretien.TabIndex = 13;
            this.entretien.SelectedIndexChanged += new System.EventHandler(this.entretien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Maintenance";
            // 
            // commen
            // 
            this.commen.Location = new System.Drawing.Point(136, 174);
            this.commen.Name = "commen";
            this.commen.Size = new System.Drawing.Size(230, 198);
            this.commen.TabIndex = 15;
            this.commen.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Commentaire";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(136, 472);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 32);
            this.Save.TabIndex = 17;
            this.Save.Text = "Sauvegarder";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Annulé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Amaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(642, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entretien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machine);
            this.Name = "Amaintenance";
            this.Text = "Amaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox machine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox entretien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox commen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button1;
    }
}