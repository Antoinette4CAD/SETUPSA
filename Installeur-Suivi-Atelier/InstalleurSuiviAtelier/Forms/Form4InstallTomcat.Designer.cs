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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4InstallTomcat));
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.labelPortDispo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelInfoPort = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelZulu = new System.Windows.Forms.TextBox();
            this.labelRepInstall = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNomService = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(13, 9);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(497, 42);
            this.labelInfoEtape.TabIndex = 0;
            this.labelInfoEtape.Text = "Installation du serveur tomcat";
            // 
            // labelPortDispo
            // 
            this.labelPortDispo.AutoSize = true;
            this.labelPortDispo.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortDispo.ForeColor = System.Drawing.Color.Green;
            this.labelPortDispo.Location = new System.Drawing.Point(202, 302);
            this.labelPortDispo.Name = "labelPortDispo";
            this.labelPortDispo.Size = new System.Drawing.Size(81, 30);
            this.labelPortDispo.TabIndex = 1;
            this.labelPortDispo.Text = "label1";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Trouver un port disponible";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 18);
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
            this.buttonStart.Location = new System.Drawing.Point(20, 125);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 70);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Démarrer";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelInfoPort
            // 
            this.labelInfoPort.AutoSize = true;
            this.labelInfoPort.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPort.Location = new System.Drawing.Point(13, 255);
            this.labelInfoPort.Name = "labelInfoPort";
            this.labelInfoPort.Size = new System.Drawing.Size(89, 18);
            this.labelInfoPort.TabIndex = 5;
            this.labelInfoPort.Text = "LABEL PORT";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(116, 152);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(99, 18);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "LABEL ERROR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Répertoire d\'installation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Emplacement du JDK Zulu :\r\n";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(423, 484);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(150, 60);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "Suivant";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 48);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lancez l\'installeur Tomcat à l\'aide du bouton vert et\r\ncopiez-collez les valeurs " +
    "ci-dessous";
            // 
            // labelZulu
            // 
            this.labelZulu.Location = new System.Drawing.Point(203, 412);
            this.labelZulu.Name = "labelZulu";
            this.labelZulu.ReadOnly = true;
            this.labelZulu.Size = new System.Drawing.Size(315, 22);
            this.labelZulu.TabIndex = 16;
            // 
            // labelRepInstall
            // 
            this.labelRepInstall.Location = new System.Drawing.Point(203, 447);
            this.labelRepInstall.Name = "labelRepInstall";
            this.labelRepInstall.ReadOnly = true;
            this.labelRepInstall.Size = new System.Drawing.Size(315, 22);
            this.labelRepInstall.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom de service conseillé :";
            // 
            // labelNomService
            // 
            this.labelNomService.Location = new System.Drawing.Point(203, 377);
            this.labelNomService.Name = "labelNomService";
            this.labelNomService.ReadOnly = true;
            this.labelNomService.Size = new System.Drawing.Size(315, 22);
            this.labelNomService.TabIndex = 19;
            // 
            // Form4InstallTomcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.labelNomService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRepInstall);
            this.Controls.Add(this.labelZulu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelInfoPort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPortDispo);
            this.Controls.Add(this.labelInfoEtape);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form4InstallTomcat";
            this.Text = "4CAD - Installeur suivi atelier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoEtape;
        private System.Windows.Forms.Label labelPortDispo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelInfoPort;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox labelZulu;
        private System.Windows.Forms.TextBox labelRepInstall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labelNomService;
    }
}