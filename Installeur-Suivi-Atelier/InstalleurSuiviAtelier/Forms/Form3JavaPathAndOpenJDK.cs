using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace InstalleurSuiviAtelier.Forms
{
    public partial class Form3JavaPathAndOpenJDK : Form
    {
        public Form3JavaPathAndOpenJDK()
        {
            InitializeComponent();
            buttonSkip.Hide();
            try
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(GetJavaInstallationPath());
                textBoxJAVA_HOME.Text = di.Parent.FullName;
            }
            catch (Exception)
            {
                //TODO : Créer un rep ProgamFiles\Java et installer le Zulu dedans, proposer avec un bouton
                textBoxJAVA_HOME.Text = "JAVA n'est pas installé sur votre machine.";
                textBoxJAVA_HOME.ForeColor = Color.Red;
                label1.Text = "Installez JAVA et redémarrez l'installeur.";
            }
        }




        private void ButtonSuivant_Click(object sender, EventArgs e)
        {
            try
            {
                InstallInfos.zuluPath = textBoxJAVA_HOME.Text + @"\jdk1.7.0_222-zulu";

                if (!Directory.Exists(textBoxJAVA_HOME.Text + @"\jdk1.7.0_222-zulu"))
                {
                    UnzipFile();



                    this.Hide();
                    Form4InstallTomcat f4 = new Form4InstallTomcat();
                    f4.Show();
                }
                else
                {
                    label1.Text = "Le JDK Zulu est déjà installé avec la bonne version sur votre machine\nVous pouvez passer l'étape.";
                    label1.ForeColor = Color.Green;
                    buttonSkip.Enabled = true;
                    buttonSkip.Show();

                    //buttonSuivan.Enabled = false;
                    labelJAVA_HOME.Visible = false;
                    buttonSuivant.Enabled = false;
                    textBoxJAVA_HOME.Hide();
                    buttonParcourir.Hide();
                }

            }
            catch (Exception)
            {
                label1.Text = "Une erreur est survenue lors de l'extraction du JDK_Zulu vers : " + textBoxJAVA_HOME.Text + "\n\nVeillez à lancer l'application en mode administrateur.\nVérifiez que le JDK n'existe pas déjà.\nSi c'est le cas, supprimez le JDK et relancez l'installation (ou passez cette étape).";
                label1.ForeColor = Color.Red;
            }


        }


        private void UnzipFile()
        {
            //On va utiliser le dossier Temp de windows pour récupérer le fichier archive
            String path = Path.GetTempPath();
            path = Path.Combine(path, "jdk_zulu.zip");

            //On convertit le fichier présent dans les Resources de bytes à un fichier
            File.WriteAllBytes(path, Properties.Resources.jdk_zulu);

            try
            {
                ZipFile.ExtractToDirectory(path, textBoxJAVA_HOME.Text);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private String GetJavaInstallationPath()
        {
            String javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment";
            using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey))
            {
                String currentVersion = baseKey.GetValue("CurrentVersion").ToString();
                using (var homeKey = baseKey.OpenSubKey(currentVersion))
                    return homeKey.GetValue("JavaHome").ToString();
            }
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4InstallTomcat f4 = new Form4InstallTomcat();
            f4.Show();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2CreationRepSA f2 = new Form2CreationRepSA();
            f2.Show();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonParcourir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            //Si le folder choisi n'est pas rien, on change ce qu'il y a écrit dans la textBox
            if (result == DialogResult.OK)
                textBoxJAVA_HOME.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
