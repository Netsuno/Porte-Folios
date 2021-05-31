namespace dessida
{
    partial class AReparation
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
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temps = new System.Windows.Forms.TextBox();
            this.Machine = new System.Windows.Forms.ComboBox();
            this.Mechanicien = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save.Location = new System.Drawing.Point(331, 335);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 32);
            this.Save.TabIndex = 9;
            this.Save.Text = "Annulé";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(129, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(102, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Machine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(102, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(460, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(102, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mechanicien";
            // 
            // temps
            // 
            this.temps.Location = new System.Drawing.Point(222, 111);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(193, 20);
            this.temps.TabIndex = 16;
            // 
            // Machine
            // 
            this.Machine.FormattingEnabled = true;
            this.Machine.Location = new System.Drawing.Point(222, 45);
            this.Machine.Name = "Machine";
            this.Machine.Size = new System.Drawing.Size(193, 21);
            this.Machine.TabIndex = 18;
            // 
            // Mechanicien
            // 
            this.Mechanicien.FormattingEnabled = true;
            this.Mechanicien.Location = new System.Drawing.Point(222, 172);
            this.Mechanicien.Name = "Mechanicien";
            this.Mechanicien.Size = new System.Drawing.Size(193, 21);
            this.Mechanicien.TabIndex = 20;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(561, 47);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(215, 253);
            this.description.TabIndex = 22;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // AReparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.description);
            this.Controls.Add(this.Mechanicien);
            this.Controls.Add(this.Machine);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "AReparation";
            this.Text = "AReparation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox temps;
        private System.Windows.Forms.ComboBox Machine;
        private System.Windows.Forms.ComboBox Mechanicien;
        private System.Windows.Forms.TextBox description;
    }
}