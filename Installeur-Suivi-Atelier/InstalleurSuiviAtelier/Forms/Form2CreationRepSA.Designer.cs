namespace InstalleurSuiviAtelier.Forms
{
    partial class Form2CreationRepSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2CreationRepSA));
            this.textBoxEmplacement = new System.Windows.Forms.TextBox();
            this.labelEmplacement = new System.Windows.Forms.Label();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.labelInfoEtape = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmplacement
            // 
            this.textBoxEmplacement.Location = new System.Drawing.Point(36, 286);
            this.textBoxEmplacement.Name = "textBoxEmplacement";
            this.textBoxEmplacement.Size = new System.Drawing.Size(379, 22);
            this.textBoxEmplacement.TabIndex = 0;
            this.textBoxEmplacement.Text = "C:\\4CAD\\SuiviAtelier\\Solution_X3Vxx";
            this.textBoxEmplacement.Enter += new System.EventHandler(this.TextBoxEmplacement_Enter);
            // 
            // labelEmplacement
            // 
            this.labelEmplacement.AutoSize = true;
            this.labelEmplacement.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmplacement.Location = new System.Drawing.Point(33, 255);
            this.labelEmplacement.Name = "labelEmplacement";
            this.labelEmplacement.Size = new System.Drawing.Size(107, 18);
            this.labelEmplacement.TabIndex = 1;
            this.labelEmplacement.Text = "Emplacement :";
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(420, 481);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(150, 60);
            this.buttonSuivant.TabIndex = 2;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.ButtonSuivant_Click);
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParcourir.Location = new System.Drawing.Point(421, 282);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(86, 31);
            this.buttonParcourir.TabIndex = 4;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.ButtonParcourir_Click);
            // 
            // labelInfoEtape
            // 
            this.labelInfoEtape.AutoSize = true;
            this.labelInfoEtape.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoEtape.Location = new System.Drawing.Point(7, 9);
            this.labelInfoEtape.Name = "labelInfoEtape";
            this.labelInfoEtape.Size = new System.Drawing.Size(382, 84);
            this.labelInfoEtape.TabIndex = 5;
            this.labelInfoEtape.Text = "Création du répertoire \r\nd\'installation principal ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ce répertoire sera la racine des fichiers d\'installation";
            // 
            // Form2CreationRepSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfoEtape);
            this.Controls.Add(this.buttonParcourir);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.labelEmplacement);
            this.Controls.Add(this.textBoxEmplacement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form2CreationRepSA";
            this.Text = "Form2CreationRepSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmplacement;
        private System.Windows.Forms.Label labelEmplacement;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.Label labelInfoEtape;
        private System.Windows.Forms.Label label1;
    }
}