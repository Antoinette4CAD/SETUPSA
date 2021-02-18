using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalleurSuiviAtelier.Forms
{
    public partial class Form5TomcatService : Form
    {
        public Form5TomcatService()
        {
            InitializeComponent();
            InitTabImage();

            //Triple maj de l'interface, a optimiser en utilisant les méthodes pour ca
            labelInfo.Text = "- Nom du service Tomcat (copiez/collez dans le configurateur Tomcat) :\n\n" + InstallInfos.getSvcName() + "_" + InstallInfos.versionInstall + "\n\n- Passez le lancement en automatique.";
            this.labelCompteur.Text = "1/4";
            labelOnglet.Text = "";
        }

        private int IndiceTab = 0;
        private Image[] TabImage = new Image[4];
        private void InitTabImage()
        {
            TabImage[0] = Properties.Resources.GeneralTab;
            TabImage[1] = Properties.Resources.LogOnTab;
            TabImage[2] = Properties.Resources.JavaTab;
            TabImage[3] = Properties.Resources.check;
        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Process.Start(InstallInfos.tomcatBinPath + @"\" + GetExecutableName());
            //buttonSuivant.Enabled = true;
        }

        //pour récupérer le nom de l'exécutable tomcat8w.exe (car il peut changer en fonction des paramètres de l'user)
        private String GetExecutableName()
        {
            DirectoryInfo d = new DirectoryInfo(InstallInfos.tomcatBinPath);
            FileInfo[] Files = d.GetFiles("*.exe"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
            }

            //On retourne le deuxième element du tableau car dans le bin on a que 2 .exe, et le 2eme est celui qu'on veut
            return Files[1].Name;
        }

        private void ButtonNextTabGuide_Click(object sender, EventArgs e)
        {

            if (IndiceTab < 3) {
                IndiceTab += 1;
                pictureGuide.Image = TabImage[IndiceTab];

                if(IndiceTab == 3)
                {
                    pictureGuide.SizeMode = PictureBoxSizeMode.CenterImage;
                    buttonSuivant.Enabled = true;
                }

            }

            MajLabelCpt();
            MajLabelInfo();
            MajLabelOnglet();

           
        }



        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if(IndiceTab > 0)
            {
                IndiceTab -= 1;
                pictureGuide.Image = TabImage[IndiceTab];

                if(IndiceTab == 2)
                {
                    pictureGuide.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }

            MajLabelCpt();
            MajLabelInfo();
            MajLabelOnglet();
        }

        private void MajLabelOnglet()
        {
            switch (IndiceTab)
            {
                case 0 :
                    labelOnglet.Text = "Onglet Général";
                    break;
                case 1:
                    labelOnglet.Text = "Onglet Log On";
                    break;
                case 2:
                    labelOnglet.Text = "Onglet Java";
                    break;
                default:
                    labelOnglet.Text = "";
                    break;
            }
        }

        private void MajLabelInfo()
        {
            switch (IndiceTab)
            {
                case 0:
                    labelInfo.Text = "- Nom du service Tomcat (copiez/collez dans le configurateur Tomcat) :\n\n" + InstallInfos.getSvcName() + "_" + InstallInfos.versionInstall + "\n\n- Passez le lancement en automatique.";
                    break;
                case 1:
                    labelInfo.Text = "Utilisez le compte de services windows";
                    break;
                case 2:
                    labelInfo.Text = "Lignes à ajouter en fin de bloc : \n\n" + @"-Dfile.encoding=UTF-8
-DSuiviAtelier.config.location=" + InstallInfos.repPrincipal + @"\SuiviAtelier_config.groovy";
                    labelInfo.ForeColor = Color.Black;
                    break;
                default:
                    labelInfo.Text = "Configuration terminée !\nVous pouvez fermer le configurateur Tomcat et passer à l'étape suivante de l'installation.";
                    labelInfo.ForeColor = Color.Green;
                    break;
            }
        }


        private void MajLabelCpt()
        {
            this.labelCompteur.Text = (IndiceTab + 1) + @"/4";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6ConfigGroovy f6 = new Form6ConfigGroovy();
            f6.Show();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6ConfigGroovy f6 = new Form6ConfigGroovy();
            f6.Show();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            Form4InstallTomcat f4 = new Form4InstallTomcat();
            this.Hide();
            f4.Show();
        }
    }
}

//Icons made by <a href="https://www.flaticon.com/authors/kiranshastry" title="Kiranshastry">Kiranshastry</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>