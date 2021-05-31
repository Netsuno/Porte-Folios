
namespace dessida
{
    partial class MLMachine
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
            this.CBequipement = new System.Windows.Forms.ComboBox();
            this.DGVMN = new System.Windows.Forms.DataGridView();
            this.DGVMP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBstatut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBdescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVMA = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVR = new System.Windows.Forms.DataGridView();
            this.lieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Imprimé = new System.Windows.Forms.Button();
            this.PBphoto = new System.Windows.Forms.PictureBox();
            this.Vali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // CBequipement
            // 
            this.CBequipement.FormattingEnabled = true;
            this.CBequipement.Location = new System.Drawing.Point(105, 39);
            this.CBequipement.Name = "CBequipement";
            this.CBequipement.Size = new System.Drawing.Size(219, 21);
            this.CBequipement.TabIndex = 30;
            this.CBequipement.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TextUpdate);
            // 
            // DGVMN
            // 
            this.DGVMN.AllowUserToAddRows = false;
            this.DGVMN.AllowUserToDeleteRows = false;
            this.DGVMN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMN.Location = new System.Drawing.Point(596, 47);
            this.DGVMN.Name = "DGVMN";
            this.DGVMN.Size = new System.Drawing.Size(553, 212);
            this.DGVMN.TabIndex = 31;
            this.DGVMN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DGVMP
            // 
            this.DGVMP.AllowUserToAddRows = false;
            this.DGVMP.AllowUserToDeleteRows = false;
            this.DGVMP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMP.Location = new System.Drawing.Point(596, 303);
            this.DGVMP.Name = "DGVMP";
            this.DGVMP.Size = new System.Drawing.Size(553, 249);
            this.DGVMP.TabIndex = 32;
            this.DGVMP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMP_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Equipement";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(808, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Maintenance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(808, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Maintenance prevue";
            // 
            // TBstatut
            // 
            this.TBstatut.Location = new System.Drawing.Point(105, 92);
            this.TBstatut.Name = "TBstatut";
            this.TBstatut.Size = new System.Drawing.Size(219, 20);
            this.TBstatut.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Statut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Description";
            // 
            // TBdescription
            // 
            this.TBdescription.Location = new System.Drawing.Point(105, 118);
            this.TBdescription.Name = "TBdescription";
            this.TBdescription.Size = new System.Drawing.Size(369, 133);
            this.TBdescription.TabIndex = 42;
            this.TBdescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(808, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Maintenance passe";
            // 
            // DGVMA
            // 
            this.DGVMA.AllowUserToAddRows = false;
            this.DGVMA.AllowUserToDeleteRows = false;
            this.DGVMA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMA.Location = new System.Drawing.Point(596, 603);
            this.DGVMA.Name = "DGVMA";
            this.DGVMA.Size = new System.Drawing.Size(553, 268);
            this.DGVMA.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Reparation";
            // 
            // DGVR
            // 
            this.DGVR.AllowUserToAddRows = false;
            this.DGVR.AllowUserToDeleteRows = false;
            this.DGVR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVR.Location = new System.Drawing.Point(22, 603);
            this.DGVR.Name = "DGVR";
            this.DGVR.Size = new System.Drawing.Size(522, 268);
            this.DGVR.TabIndex = 46;
            this.DGVR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVR_CellContentClick);
            // 
            // lieu
            // 
            this.lieu.Location = new System.Drawing.Point(105, 66);
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(89, 20);
            this.lieu.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(28, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Emplacement";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(449, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Dossier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(235, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Réparation";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.button4.Location = new System.Drawing.Point(300, 554);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 43);
            this.button4.TabIndex = 54;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.button3.Location = new System.Drawing.Point(914, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 43);
            this.button3.TabIndex = 53;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.button2.Location = new System.Drawing.Point(919, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 40);
            this.button2.TabIndex = 52;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Imprimé
            // 
            this.Imprimé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.Imprimé.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Imprimé.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Imprimé.Image = global::dessida.Properties.Resources.printer_print_icon_123489__2_;
            this.Imprimé.Location = new System.Drawing.Point(883, 3);
            this.Imprimé.Name = "Imprimé";
            this.Imprimé.Size = new System.Drawing.Size(44, 41);
            this.Imprimé.TabIndex = 51;
            this.Imprimé.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Imprimé.UseVisualStyleBackColor = false;
            this.Imprimé.Click += new System.EventHandler(this.Imprimé_Click);
            // 
            // PBphoto
            // 
            this.PBphoto.Location = new System.Drawing.Point(2, 260);
            this.PBphoto.Name = "PBphoto";
            this.PBphoto.Size = new System.Drawing.Size(522, 292);
            this.PBphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBphoto.TabIndex = 49;
            this.PBphoto.TabStop = false;
            this.PBphoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Vali
            // 
            this.Vali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vali.Location = new System.Drawing.Point(449, 63);
            this.Vali.Name = "Vali";
            this.Vali.Size = new System.Drawing.Size(75, 23);
            this.Vali.TabIndex = 56;
            this.Vali.Text = "Validation";
            this.Vali.UseVisualStyleBackColor = true;
            this.Vali.Click += new System.EventHandler(this.Vali_Click);
            // 
            // MLMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1178, 881);
            this.Controls.Add(this.Vali);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Imprimé);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PBphoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.DGVR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGVMA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBdescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBstatut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVMP);
            this.Controls.Add(this.DGVMN);
            this.Controls.Add(this.CBequipement);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MLMachine";
            this.Text = "MLMachine";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBequipement;
        private System.Windows.Forms.DataGridView DGVMN;
        private System.Windows.Forms.DataGridView DGVMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBstatut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TBdescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVMA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVR;
        private System.Windows.Forms.TextBox lieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PBphoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Imprimé;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Vali;
    }
}