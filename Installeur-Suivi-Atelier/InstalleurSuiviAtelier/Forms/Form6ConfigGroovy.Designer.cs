namespace InstalleurSuiviAtelier.Forms
{
    partial class Form6ConfigGroovy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6ConfigGroovy));
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelDossierX3 = new System.Windows.Forms.Label();
            this.labelSrv = new System.Windows.Forms.Label();
            this.labelProtocole = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxX3Name = new System.Windows.Forms.TextBox();
            this.textBoxServerAdress = new System.Windows.Forms.TextBox();
            this.radioButtonHTTPS = new System.Windows.Forms.RadioButton();
            this.radioButtonHTTP = new System.Windows.Forms.RadioButton();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(205, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intialisation du fichier \r\nde configuration X3";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(268, 111);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(130, 18);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Utilisateur WS X3 :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(293, 151);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(105, 18);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mot de passe :";
            // 
            // labelDossierX3
            // 
            this.labelDossierX3.AutoSize = true;
            this.labelDossierX3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDossierX3.Location = new System.Drawing.Point(246, 190);
            this.labelDossierX3.Name = "labelDossierX3";
            this.labelDossierX3.Size = new System.Drawing.Size(152, 18);
            this.labelDossierX3.TabIndex = 3;
            this.labelDossierX3.Text = "Nom du pool de WS :";
            // 
            // labelSrv
            // 
            this.labelSrv.AutoSize = true;
            this.labelSrv.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrv.Location = new System.Drawing.Point(258, 229);
            this.labelSrv.Name = "labelSrv";
            this.labelSrv.Size = new System.Drawing.Size(140, 18);
            this.labelSrv.TabIndex = 4;
            this.labelSrv.Text = "Adresse serveur X3 :";
            // 
            // labelProtocole
            // 
            this.labelProtocole.AutoSize = true;
            this.labelProtocole.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProtocole.Location = new System.Drawing.Point(319, 309);
            this.labelProtocole.Name = "labelProtocole";
            this.labelProtocole.Size = new System.Drawing.Size(79, 18);
            this.labelProtocole.TabIndex = 5;
            this.labelProtocole.Text = "Protocole :";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(331, 270);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(67, 18);
            this.labelPort.TabIndex = 6;
            this.labelPort.Text = "Port X3 : ";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(404, 108);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(176, 24);
            this.textBoxUser.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(404, 148);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(176, 24);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxX3Name
            // 
            this.textBoxX3Name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX3Name.Location = new System.Drawing.Point(404, 187);
            this.textBoxX3Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxX3Name.Name = "textBoxX3Name";
            this.textBoxX3Name.Size = new System.Drawing.Size(176, 24);
            this.textBoxX3Name.TabIndex = 10;
            // 
            // textBoxServerAdress
            // 
            this.textBoxServerAdress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServerAdress.Location = new System.Drawing.Point(404, 226);
            this.textBoxServerAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxServerAdress.Name = "textBoxServerAdress";
            this.textBoxServerAdress.Size = new System.Drawing.Size(176, 24);
            this.textBoxServerAdress.TabIndex = 11;
            // 
            // radioButtonHTTPS
            // 
            this.radioButtonHTTPS.AutoSize = true;
            this.radioButtonHTTPS.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHTTPS.Location = new System.Drawing.Point(508, 306);
            this.radioButtonHTTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHTTPS.Name = "radioButtonHTTPS";
            this.radioButtonHTTPS.Size = new System.Drawing.Size(72, 22);
            this.radioButtonHTTPS.TabIndex = 12;
            this.radioButtonHTTPS.TabStop = true;
            this.radioButtonHTTPS.Text = "HTTPS";
            this.radioButtonHTTPS.UseVisualStyleBackColor = true;
            // 
            // radioButtonHTTP
            // 
            this.radioButtonHTTP.AutoSize = true;
            this.radioButtonHTTP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHTTP.Location = new System.Drawing.Point(404, 306);
            this.radioButtonHTTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHTTP.Name = "radioButtonHTTP";
            this.radioButtonHTTP.Size = new System.Drawing.Size(64, 22);
            this.radioButtonHTTP.TabIndex = 13;
            this.radioButtonHTTP.TabStop = true;
            this.radioButtonHTTP.Text = "HTTP";
            this.radioButtonHTTP.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(404, 267);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(176, 24);
            this.textBoxPort.TabIndex = 14;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.buttonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(481, 340);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 28);
            this.buttonGenerate.TabIndex = 18;
            this.buttonGenerate.Text = "Générer";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(195, 346);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(273, 39);
            this.labelError.TabIndex = 19;
            this.labelError.Text = "LABEL ERROR";
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(320, 390);
            this.buttonPrecedent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(100, 28);
            this.buttonPrecedent.TabIndex = 29;
            this.buttonPrecedent.Text = "< Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Enabled = false;
            this.buttonSuivant.Location = new System.Drawing.Point(423, 390);
            this.buttonSuivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(100, 28);
            this.buttonSuivant.TabIndex = 28;
            this.buttonSuivant.Text = "Suivant >";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(536, 390);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 28);
            this.buttonAnnuler.TabIndex = 27;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InstalleurSuiviAtelier.Properties.Resources._4CAD_Group_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 416);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form6ConfigGroovy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.radioButtonHTTP);
            this.Controls.Add(this.radioButtonHTTPS);
            this.Controls.Add(this.textBoxServerAdress);
            this.Controls.Add(this.textBoxX3Name);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelProtocole);
            this.Controls.Add(this.labelSrv);
            this.Controls.Add(this.labelDossierX3);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(666, 477);
            this.MinimumSize = new System.Drawing.Size(666, 477);
            this.Name = "Form6ConfigGroovy";
            this.Text = "4CAD - Installeur suivi atelier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelDossierX3;
        private System.Windows.Forms.Label labelSrv;
        private System.Windows.Forms.Label labelProtocole;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxX3Name;
        private System.Windows.Forms.TextBox textBoxServerAdress;
        private System.Windows.Forms.RadioButton radioButtonHTTPS;
        private System.Windows.Forms.RadioButton radioButtonHTTP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}