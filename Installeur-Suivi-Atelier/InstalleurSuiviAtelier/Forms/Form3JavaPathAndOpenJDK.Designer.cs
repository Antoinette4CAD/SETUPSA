namespace InstalleurSuiviAtelier.Forms
{
    partial class Form3JavaPathAndOpenJDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3JavaPathAndOpenJDK));
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.labelJAVA_HOME = new System.Windows.Forms.Label();
            this.textBoxJAVA_HOME = new System.Windows.Forms.TextBox();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParcourir.Location = new System.Drawing.Point(393, 287);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(86, 31);
            this.buttonParcourir.TabIndex = 7;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            // 
            // labelJAVA_HOME
            // 
            this.labelJAVA_HOME.AutoSize = true;
            this.labelJAVA_HOME.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJAVA_HOME.Location = new System.Drawing.Point(92, 263);
            this.labelJAVA_HOME.Name = "labelJAVA_HOME";
            this.labelJAVA_HOME.Size = new System.Drawing.Size(186, 18);
            this.labelJAVA_HOME.TabIndex = 6;
            this.labelJAVA_HOME.Text = "Répertoire principal JAVA :";
            // 
            // textBoxJAVA_HOME
            // 
            this.textBoxJAVA_HOME.Location = new System.Drawing.Point(95, 291);
            this.textBoxJAVA_HOME.Name = "textBoxJAVA_HOME";
            this.textBoxJAVA_HOME.Size = new System.Drawing.Size(292, 22);
            this.textBoxJAVA_HOME.TabIndex = 5;
            this.textBoxJAVA_HOME.Text = "C:\\Program Files\\Java";
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(420, 481);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(150, 60);
            this.buttonSuivant.TabIndex = 8;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.ButtonSuivant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(12, 9);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(397, 42);
            this.labelInfoEtape.TabIndex = 12;
            this.labelInfoEtape.Text = "Installation du JDK Zulu";
            // 
            // buttonSkip
            // 
            this.buttonSkip.Enabled = false;
            this.buttonSkip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkip.Location = new System.Drawing.Point(225, 350);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(75, 25);
            this.buttonSkip.TabIndex = 13;
            this.buttonSkip.Text = "Passer";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 48);
            this.label2.TabIndex = 14;
            this.label2.Text = "L\'application Suivi Atelier fonctionne à l\'aide \r\ndu JDK open source zulu";
            // 
            // Form3JavaPathAndOpenJDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.labelInfoEtape);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonParcourir);
            this.Controls.Add(this.labelJAVA_HOME);
            this.Controls.Add(this.textBoxJAVA_HOME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form3JavaPathAndOpenJDK";
            this.Text = "4CAD - Installeur suivi atelier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.Label labelJAVA_HOME;
        private System.Windows.Forms.TextBox textBoxJAVA_HOME;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfoEtape;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Label label2;
    }
}