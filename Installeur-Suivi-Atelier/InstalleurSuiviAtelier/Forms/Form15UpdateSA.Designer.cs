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
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.labelEmplacement = new System.Windows.Forms.Label();
            this.textBoxEmplacement = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mise à niveau rapide de votre application";
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(12, 9);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(442, 42);
            this.labelInfoEtape.TabIndex = 11;
            this.labelInfoEtape.Text = "Mise à jour du Suivi Atelier";
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParcourir.Location = new System.Drawing.Point(437, 186);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(86, 31);
            this.buttonParcourir.TabIndex = 10;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
            // 
            // labelEmplacement
            // 
            this.labelEmplacement.AutoSize = true;
            this.labelEmplacement.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmplacement.Location = new System.Drawing.Point(49, 161);
            this.labelEmplacement.Name = "labelEmplacement";
            this.labelEmplacement.Size = new System.Drawing.Size(261, 18);
            this.labelEmplacement.TabIndex = 9;
            this.labelEmplacement.Text = "Répertoire d\'installation de TOMCAT :";
            // 
            // textBoxEmplacement
            // 
            this.textBoxEmplacement.Location = new System.Drawing.Point(52, 190);
            this.textBoxEmplacement.Name = "textBoxEmplacement";
            this.textBoxEmplacement.Size = new System.Drawing.Size(379, 22);
            this.textBoxEmplacement.TabIndex = 8;
            this.textBoxEmplacement.Text = "C:\\4CAD\\SuiviAtelier\\Solution_X3Vxx\\Tomcat-8.5";
            this.textBoxEmplacement.TextChanged += new System.EventHandler(this.textBoxEmplacement_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(221, 338);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 50);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Mettre à jour";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(181, 267);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 14;
            // 
            // Form15UpdateSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfoEtape);
            this.Controls.Add(this.buttonParcourir);
            this.Controls.Add(this.labelEmplacement);
            this.Controls.Add(this.textBoxEmplacement);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form15UpdateSA";
            this.Text = "Form15UpdateSA";
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelError;
    }
}