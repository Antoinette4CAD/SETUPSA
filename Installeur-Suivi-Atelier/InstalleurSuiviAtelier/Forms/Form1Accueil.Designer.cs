namespace InstalleurSuiviAtelier
{
    partial class Form1Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Accueil));
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNouvelleInstall = new System.Windows.Forms.RadioButton();
            this.rbMaj = new System.Windows.Forms.RadioButton();
            this.cbVersions = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.buttonAnnuler.Location = new System.Drawing.Point(266, 334);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(71, 23);
            this.buttonAnnuler.TabIndex = 10;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.buttonSuivant.Location = new System.Drawing.Point(183, 334);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(71, 23);
            this.buttonSuivant.TabIndex = 11;
            this.buttonSuivant.Text = "Suivant >";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSuivant);
            this.groupBox1.Controls.Add(this.rbNouvelleInstall);
            this.groupBox1.Controls.Add(this.buttonAnnuler);
            this.groupBox1.Controls.Add(this.rbMaj);
            this.groupBox1.Controls.Add(this.cbVersions);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(138, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 367);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.label2.Location = new System.Drawing.Point(44, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Version d\'installation :";
            // 
            // rbNouvelleInstall
            // 
            this.rbNouvelleInstall.AutoSize = true;
            this.rbNouvelleInstall.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.rbNouvelleInstall.Location = new System.Drawing.Point(44, 247);
            this.rbNouvelleInstall.Name = "rbNouvelleInstall";
            this.rbNouvelleInstall.Size = new System.Drawing.Size(133, 18);
            this.rbNouvelleInstall.TabIndex = 18;
            this.rbNouvelleInstall.TabStop = true;
            this.rbNouvelleInstall.Text = "Nouvelle installation";
            this.rbNouvelleInstall.UseVisualStyleBackColor = true;
            this.rbNouvelleInstall.CheckedChanged += new System.EventHandler(this.rbNouvelleInstall_CheckedChanged);
            // 
            // rbMaj
            // 
            this.rbMaj.AutoSize = true;
            this.rbMaj.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.rbMaj.Location = new System.Drawing.Point(183, 247);
            this.rbMaj.Name = "rbMaj";
            this.rbMaj.Size = new System.Drawing.Size(83, 18);
            this.rbMaj.TabIndex = 17;
            this.rbMaj.TabStop = true;
            this.rbMaj.Text = "Mise à jour";
            this.rbMaj.UseVisualStyleBackColor = true;
            this.rbMaj.CheckedChanged += new System.EventHandler(this.rbMaj_CheckedChanged);
            // 
            // cbVersions
            // 
            this.cbVersions.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.cbVersions.FormattingEnabled = true;
            this.cbVersions.Location = new System.Drawing.Point(173, 220);
            this.cbVersions.Name = "cbVersions";
            this.cbVersions.Size = new System.Drawing.Size(66, 21);
            this.cbVersions.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 139);
            this.label4.TabIndex = 15;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bienvenue dans l\'installeur 4CAD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(-133, 323);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 43);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InstalleurSuiviAtelier.Properties.Resources._4CAD_Group_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::InstalleurSuiviAtelier.Properties.Resources._4CAD_Group_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 347);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(505, 397);
            this.MinimumSize = new System.Drawing.Size(505, 397);
            this.Name = "Form1Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4CAD - Installeur suivi atelier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNouvelleInstall;
        private System.Windows.Forms.RadioButton rbMaj;
        private System.Windows.Forms.ComboBox cbVersions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

