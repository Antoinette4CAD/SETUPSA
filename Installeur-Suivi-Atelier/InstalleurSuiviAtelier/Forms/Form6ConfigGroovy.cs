using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalleurSuiviAtelier.Forms
{
    public partial class Form6ConfigGroovy : Form
    {
        private const char guillemet = '"';

        public Form6ConfigGroovy()
        {
            InitializeComponent();
            labelError.Text = "";
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (!AllValuesFilled())
            {
                labelError.Text = "Veuillez remplir tous les champs";
                labelError.ForeColor = Color.Red;
                return;
            }
            else
            {
                labelError.Text = "Génération en cours...";
                labelError.ForeColor = Color.Green;
            }

            buttonSuivant.Enabled = true;

            string filePath = InstallInfos.repPrincipal + @"\SuiviAtelier_config.groovy";
            string fileTempPath = Path.GetTempPath() + @"SuiviAtelier_config.groovy";

            string content = GenerateConfigContent();

            //Tout se passe ici
            try
            {            
                //On va créer le fichier dans le répertoire temporaire pour des questions de droits
                StreamWriter file = new StreamWriter(fileTempPath);
                file.Write(content);
                file.Close();

                //Puis on déplace le fichier dans le rép d'install
                File.Move(fileTempPath, filePath);
            }
            catch (Exception)
            {
                labelError.Text = "Impossible de générer " + filePath;
                labelError.ForeColor = Color.Red;
            }
            labelError.Text = "Opération terminée avec succès.";
            labelError.ForeColor = Color.Green;
        }

        private string GenerateConfigContent()
        {
            return @"fcad {
                x3 {
                    lang='FRA'
                    user='" + textBoxUser.Text + @"'
                    pwd='" + textBoxPassword.Text + @"'
                    pool='" + textBoxX3Name.Text + @"'
                    server='" + textBoxServerAdress.Text + @"'
                    protocol='"+ GetProtocol() +@"'
                    port='" + textBoxPort.Text + @"'
                    root=" + guillemet + @"/soap-generic/syracuse/collaboration/syracuse/CAdxWebServiceXmlCC" + guillemet + "\n\t\t}\n}";
        }

        private string GetProtocol()
        {
            if (radioButtonHTTPS.Checked)
                return "https";
            else
                return "http";
        }

        //private string GetRootAdress()
        //{
        //    if (radioButtonUnderPU9.Checked)
        //        return @"/adxwsvc/services/CAdxWebServiceXmlCC";
        //    else
        //        return @"/soap-generic/syracuse/collaboration/syracuse/CAdxWebServiceXmlCC";
        //}

        private bool AllValuesFilled()
        {
            if (textBoxUser.TextLength == 0)
                return false;
            if (textBoxPassword.TextLength == 0)
                return false;
            if (textBoxX3Name.TextLength == 0)
                return false;
            if (textBoxServerAdress.TextLength == 0)
                return false;
            if (!(radioButtonHTTP.Checked || radioButtonHTTPS.Checked))
                return false;
            if (textBoxPort.TextLength == 0)
                return false;

            return true;
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            try
            {
                InstallInfos.InstallWebApp(Path.Combine(InstallInfos.tomcatBinPath, @"..\webapps"/*\SuiviAtelier.war"*/), false);

                Form7InstallDone f7 = new Form7InstallDone();
                f7.Show();

                this.Hide();
            }
            catch (Exception)
            {
                labelError.Text = "Impossible d'installer l'application web dans le répertoire webapps, vérifiez dans un premier temps vos droits d'utilisateur.";
                labelError.ForeColor = Color.Green;
                throw;
            }
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            Form5TomcatService f5 = new Form5TomcatService();
            this.Hide();
            f5.Show();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
