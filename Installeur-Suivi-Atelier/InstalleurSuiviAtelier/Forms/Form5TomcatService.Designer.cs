namespace InstalleurSuiviAtelier.Forms
{
    partial class Form5TomcatService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5TomcatService));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.ButtonNextTabGuide = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.RichTextBox();
            this.labelCompteur = new System.Windows.Forms.Label();
            this.pictureGuide = new System.Windows.Forms.PictureBox();
            this.labelOnglet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(19, 78);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(90, 70);
            this.ButtonStart.TabIndex = 6;
            this.ButtonStart.Text = "Démarrer";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(12, 9);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(538, 42);
            this.labelInfoEtape.TabIndex = 5;
            this.labelInfoEtape.Text = "Configuration du service Tomcat";
            // 
            // ButtonNextTabGuide
            // 
            this.ButtonNextTabGuide.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNextTabGuide.Location = new System.Drawing.Point(461, 250);
            this.ButtonNextTabGuide.Name = "ButtonNextTabGuide";
            this.ButtonNextTabGuide.Size = new System.Drawing.Size(98, 44);
            this.ButtonNextTabGuide.TabIndex = 8;
            this.ButtonNextTabGuide.Text = "Suivant";
            this.ButtonNextTabGuide.UseVisualStyleBackColor = true;
            this.ButtonNextTabGuide.Click += new System.EventHandler(this.ButtonNextTabGuide_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(12, 250);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(100, 44);
            this.buttonPrevious.TabIndex = 10;
            this.buttonPrevious.Text = "Précédent";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(520, 581);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(150, 60);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Suivant";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Suivez les indications afin de paramétrer le service";
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(461, 317);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.ReadOnly = true;
            this.labelInfo.Size = new System.Drawing.Size(193, 135);
            this.labelInfo.TabIndex = 17;
            this.labelInfo.Text = "";
            // 
            // labelCompteur
            // 
            this.labelCompteur.AutoSize = true;
            this.labelCompteur.Location = new System.Drawing.Point(250, 591);
            this.labelCompteur.Name = "labelCompteur";
            this.labelCompteur.Size = new System.Drawing.Size(78, 17);
            this.labelCompteur.TabIndex = 18;
            this.labelCompteur.Text = "LABELCPT";
            // 
            // pictureGuide
            // 
            this.pictureGuide.Image = global::InstalleurSuiviAtelier.Properties.Resources.GeneralTab;
            this.pictureGuide.InitialImage = global::InstalleurSuiviAtelier.Properties.Resources.GeneralTab;
            this.pictureGuide.Location = new System.Drawing.Point(125, 138);
            this.pictureGuide.Name = "pictureGuide";
            this.pictureGuide.Size = new System.Drawing.Size(330, 450);
            this.pictureGuide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGuide.TabIndex = 9;
            this.pictureGuide.TabStop = false;
            // 
            // labelOnglet
            // 
            this.labelOnglet.AutoSize = true;
            this.labelOnglet.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnglet.Location = new System.Drawing.Point(461, 170);
            this.labelOnglet.Name = "labelOnglet";
            this.labelOnglet.Size = new System.Drawing.Size(108, 18);
            this.labelOnglet.TabIndex = 19;
            this.labelOnglet.Text = "LABEL ONGLET";
            // 
            // Form5TomcatService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.labelOnglet);
            this.Controls.Add(this.labelCompteur);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.pictureGuide);
            this.Controls.Add(this.ButtonNextTabGuide);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.labelInfoEtape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "Form5TomcatService";
            this.Text = "4CAD - Installeur suivi atelier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureGuide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label labelInfoEtape;
        private System.Windows.Forms.Button ButtonNextTabGuide;
        private System.Windows.Forms.PictureBox pictureGuide;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox labelInfo;
        private System.Windows.Forms.Label labelCompteur;
        private System.Windows.Forms.Label labelOnglet;
    }
}