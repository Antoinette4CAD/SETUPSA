namespace InstalleurSuiviAtelier.Forms
{
    partial class Form15UpdateSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15UpdateSA));
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.labelEmplacement = new System.Windows.Forms.Label();
            this.textBoxEmplacement = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mise à niveau rapide de votre application";
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(191, 9);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(194, 42);
            this.labelInfoEtape.TabIndex = 11;
            this.labelInfoEtape.Text = "Mise à jour";
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParcourir.Location = new System.Drawing.Point(536, 208);
            this.buttonParcourir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(85, 31);
            this.buttonParcourir.TabIndex = 10;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
            // 
            // labelEmplacement
            // 
            this.labelEmplacement.AutoSize = true;
            this.labelEmplacement.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmplacement.Location = new System.Drawing.Point(195, 183);
            this.labelEmplacement.Name = "labelEmplacement";
            this.labelEmplacement.Size = new System.Drawing.Size(261, 18);
            this.labelEmplacement.TabIndex = 9;
            this.labelEmplacement.Text = "Répertoire d\'installation de TOMCAT :";
            // 
            // textBoxEmplacement
            // 
            this.textBoxEmplacement.Location = new System.Drawing.Point(197, 212);
            this.textBoxEmplacement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmplacement.Name = "textBoxEmplacement";
            this.textBoxEmplacement.Size = new System.Drawing.Size(333, 22);
            this.textBoxEmplacement.TabIndex = 8;
            this.textBoxEmplacement.Text = "C:\\4CAD\\SuiviAtelier\\<NomPoolWSX3>\\Tomcat-8.5";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(159, 267);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 14;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(536, 398);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 28);
            this.buttonAnnuler.TabIndex = 15;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(423, 398);
            this.buttonSuivant.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(100, 28);
            this.buttonSuivant.TabIndex = 16;
            this.buttonSuivant.Text = "Suivant >";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 398);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "< Précédent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InstalleurSuiviAtelier.Properties.Resources._4CAD_Group_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::InstalleurSuiviAtelier.Properties.Resources._4CAD_Group_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 427);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form15UpdateSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfoEtape);
            this.Controls.Add(this.buttonParcourir);
            this.Controls.Add(this.labelEmplacement);
            this.Controls.Add(this.textBoxEmplacement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(666, 477);
            this.MinimumSize = new System.Drawing.Size(666, 477);
            this.Name = "Form15UpdateSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4CAD - Installeur suivi atelier";
            this.Load += new System.EventHandler(this.Form15UpdateSA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfoEtape;
        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.Label labelEmplacement;
        private System.Windows.Forms.TextBox textBoxEmplacement;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}