using InstalleurSuiviAtelier.Forms;
using InstalleurSuiviAtelier.Properties;
using System;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Data;

namespace InstalleurSuiviAtelier
{
    public partial class Form1Accueil : Form
    {
        public Form1Accueil()
        {
            InitializeComponent();
            InitListBox();
            this.buttonSuivant.Enabled = false;
        }

        ////On passe au formulaire suivant
        //private void ButtonInstall_Click(object sender, EventArgs e)
        //{
        //    if (clickButtonGlobal())
        //    {
        //        Form2CreationRepSA f2 = new Form2CreationRepSA();
        //        f2.ShowDialog();
        //    }

        //}

        //private void buttonUpdate_Click(object sender, EventArgs e)
        //{
        //    if (clickButtonGlobal())
        //    {
        //        Form15UpdateSA f2 = new Form15UpdateSA();
        //        f2.ShowDialog();
        //    }
        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    //    private bool clickButtonGlobal()
    //    {
    //        if (listBoxWebApps.SelectedItem == null)
    //        {
    //            MessageBox.Show("Veuillez selectionner une version du Suivi Atelier à mettre en place.", "Choix de version manquant",
    //MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //            return false;
    //        }
    //        else
    //        {
    //            this.Hide();
    //            InstallInfos.versionInstall = listBoxWebApps.SelectedItem.ToString();
    //            return true;
    //        }
    //    }

        //Récupère les différentes version du suivi atelier 
        //formate les noms des ressources, et place dans la liste les différentes versions,
        //sera utilisé pour le reste de l'install/maj
        //Il est nécessaire de cliquer une case
        private void InitListBox()
        {
            //DataTable dt = new DataTable();

            //2 colonnes, 
            //une avec le nom affiché dans la liste déroulante (5.2.8)
            //une avec un pointeur vers la vraie ressource (type byte[])

            //J'ajoute toutes mes ressources

            //Dans la page d'accueil j'affiche la 1 ere colonne pour chaque ligne [2]

            //dt.Columns.Add()



            /* Reference to your resources class -- may be named differently in your case */
            ResourceManager MyResourceClass =
                new ResourceManager(typeof(Resources));

            ResourceSet resourceSet =
                MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            ArrayList listeVersions = new ArrayList();

            foreach (DictionaryEntry entry in resourceSet)
            {
                //REMPLISSAGE DE LA DT  ICI MEME


                string resourceName = entry.Key.ToString();


                //On veut garder seulement les ressources du type "SuiviAtelier_X_X_X_pro"
                //Puis récupérer seulement la version pour l'afficher dans le 
                if (resourceName.StartsWith("SuiviAtelier"))
                {
                    resourceName = Regex.Replace(resourceName, @"[^\d]", "");
                    resourceName = resourceName.Insert(1, ".");
                    resourceName = resourceName.Insert(3, ".");

                    //Console.WriteLine(resourceName);
                    
                    listeVersions.Add(resourceName);
                }

            }

            //On trie la liste par ordre alphabétique
            //listeVersions.Sort();
            //listeVersions.Reverse();

            //Puis on ajoute tout à l'élément graphique ListBox
            foreach (string s in listeVersions)
            {
                //listBoxWebApps.Items.Add(s);
                cbVersions.Items.Add(s);
            }

            //Trace.WriteLine(listBoxWebApps.Sorted);
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (cbVersions.SelectedItem != null)
            {
                InstallInfos.versionInstall = cbVersions.SelectedItem.ToString();
                this.Hide();
                if (rbMaj.Checked)
                {
                    //On est en mise à jour
                    Form15UpdateSA f2 = new Form15UpdateSA();
                    f2.ShowDialog();
                }
                else
                {
                    //Nouvelle install
                    Form2CreationRepSA f2 = new Form2CreationRepSA();
                    f2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une version du Suivi Atelier à mettre en place.", "Choix de version manquant",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbNouvelleInstall_CheckedChanged(object sender, EventArgs e)
        {
            buttonSuivant.Enabled = true;
        }

        private void rbMaj_CheckedChanged(object sender, EventArgs e)
        {
            buttonSuivant.Enabled = true;
        }
    }
}
