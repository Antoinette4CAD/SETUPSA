namespace InstalleurSuiviAtelier.Forms
{
    partial class Form4InstallTomcat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4InstallTomcat));
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.labelPortDispo = new System.Windows.Forms.Label();
            this.buttonTrouver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelInfoPort = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelZulu = new System.Windows.Forms.TextBox();
            this.labelRepInstall = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNomService = new System.Windows.Forms.TextBox();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.toolTipTrouverPort = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(20, 6);
            this.labelInfoEtape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(402, 35);
            this.labelInfoEtape.TabIndex = 0;
            this.labelInfoEtape.Text = "Installation du serveur tomcat";
            // 
            // labelPortDispo
            // 
            this.labelPortDispo.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortDispo.ForeColor = System.Drawing.Color.Green;
            this.labelPortDispo.Location = new System.Drawing.Point(369, 167);
            this.labelPortDispo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPortDispo.Name = "labelPortDispo";
            this.labelPortDispo.Size = new System.Drawing.Size(100, 20);
            this.labelPortDispo.TabIndex = 1;
            this.labelPortDispo.Text = "label1";
            // 
            // buttonTrouver
            // 
            this.buttonTrouver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTrouver.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrouver.Location = new System.Drawing.Point(278, 169);
            this.buttonTrouver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTrouver.Name = "buttonTrouver";
            this.buttonTrouver.Size = new System.Drawing.Size(75, 23);
            this.buttonTrouver.TabIndex = 2;
            this.buttonTrouver.Text = "Trouver";
            this.buttonTrouver.UseVisualStyleBackColor = true;
            this.buttonTrouver.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Par défaut, tomcat utilise le port 8080 pour communiquer. (HTTP Connector port)\r\n" +
    "";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(24, 94);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Démarrer";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelInfoPort
            // 
            this.labelInfoPort.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPort.Location = new System.Drawing.Point(21, 155);
            this.labelInfoPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoPort.Name = "labelInfoPort";
            this.labelInfoPort.Size = new System.Drawing.Size(225, 45);
            this.labelInfoPort.TabIndex = 5;
            this.labelInfoPort.Text = "LABEL PORT";
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(171, 89);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(276, 32);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "LABEL ERROR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Répertoire d\'installation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Emplacement du JDK Zulu :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lancez l\'installeur Tomcat à l\'aide du bouton vert et\r\ncopiez-collez les valeurs " +
    "ci-dessous";
            // 
            // labelZulu
            // 
            this.labelZulu.Location = new System.Drawing.Point(161, 244);
            this.labelZulu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelZulu.Name = "labelZulu";
            this.labelZulu.ReadOnly = true;
            this.labelZulu.Size = new System.Drawing.Size(304, 20);
            this.labelZulu.TabIndex = 16;
            // 
            // labelRepInstall
            // 
            this.labelRepInstall.Location = new System.Drawing.Point(161, 272);
            this.labelRepInstall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelRepInstall.Name = "labelRepInstall";
            this.labelRepInstall.ReadOnly = true;
            this.labelRepInstall.Size = new System.Drawing.Size(304, 20);
            this.labelRepInstall.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom de service conseillé :";
            // 
            // labelNomService
            // 
            this.labelNomService.Location = new System.Drawing.Point(161, 215);
            this.labelNomService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelNomService.Name = "labelNomService";
            this.labelNomService.ReadOnly = true;
            this.labelNomService.Size = new System.Drawing.Size(304, 20);
            this.labelNomService.TabIndex = 19;
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(240, 323);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(75, 23);
            this.buttonPrecedent.TabIndex = 23;
            this.buttonPrecedent.Text = "< Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(317, 323);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(75, 23);
            this.buttonSuivant.TabIndex = 22;
            this.buttonSuivant.Text = "Suivant >";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(402, 323);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 21;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // toolTipTrouverPort
            // 
            this.toolTipTrouverPort.ToolTipTitle = "Trouver un port disponible";
            // 
            // Form4InstallTomcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 358);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelNomService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRepInstall);
            this.Controls.Add(this.labelZulu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelInfoPort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTrouver);
            this.Controls.Add(this.labelPortDispo);
            this.Controls.Add(this.labelInfoEtape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(505, 397);
            this.MinimumSize = new System.Drawing.Size(505, 397);
            this.Name = "Form4InstallTomcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4CAD - Installeur suivi atelier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoEtape;
        private System.Windows.Forms.Label labelPortDispo;
        private System.Windows.Forms.Button buttonTrouver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelInfoPort;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox labelZulu;
        private System.Windows.Forms.TextBox labelRepInstall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labelNomService;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ToolTip toolTipTrouverPort;
    }
}