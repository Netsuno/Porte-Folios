namespace dessida
{
    partial class AMachine
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.nserie = new System.Windows.Forms.TextBox();
            this.valeur = new System.Windows.Forms.TextBox();
            this.Emplacement = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.statut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save.Location = new System.Drawing.Point(192, 384);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 32);
            this.Save.TabIndex = 0;
            this.Save.Text = "Sauvegarder";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(395, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Annulé";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(105, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(433, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(92, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Statut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(92, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valeur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(14, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Numero de Serie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(38, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Emplacement";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nom.Location = new System.Drawing.Point(192, 54);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(176, 26);
            this.nom.TabIndex = 8;
            // 
            // nserie
            // 
            this.nserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nserie.Location = new System.Drawing.Point(192, 141);
            this.nserie.Name = "nserie";
            this.nserie.Size = new System.Drawing.Size(176, 26);
            this.nserie.TabIndex = 9;
            // 
            // valeur
            // 
            this.valeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.valeur.Location = new System.Drawing.Point(192, 197);
            this.valeur.Name = "valeur";
            this.valeur.Size = new System.Drawing.Size(176, 26);
            this.valeur.TabIndex = 10;
            // 
            // Emplacement
            // 
            this.Emplacement.FormattingEnabled = true;
            this.Emplacement.Location = new System.Drawing.Point(192, 95);
            this.Emplacement.Name = "Emplacement";
            this.Emplacement.Size = new System.Drawing.Size(176, 21);
            this.Emplacement.TabIndex = 11;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(558, 54);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(230, 213);
            this.description.TabIndex = 12;
            this.description.Text = "";
            // 
            // statut
            // 
            this.statut.AutoCompleteCustomSource.AddRange(new string[] {
            "Fonctionelle",
            "Probleme"});
            this.statut.FormattingEnabled = true;
            this.statut.Items.AddRange(new object[] {
            "Fonctionelle",
            "Ok",
            "Bof"});
            this.statut.Location = new System.Drawing.Point(192, 245);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(176, 21);
            this.statut.TabIndex = 13;
            this.statut.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.description);
            this.Controls.Add(this.Emplacement);
            this.Controls.Add(this.valeur);
            this.Controls.Add(this.nserie);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "AMachine";
            this.Text = "AMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox nserie;
        private System.Windows.Forms.TextBox valeur;
        private System.Windows.Forms.ComboBox Emplacement;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.ComboBox statut;
    }
}