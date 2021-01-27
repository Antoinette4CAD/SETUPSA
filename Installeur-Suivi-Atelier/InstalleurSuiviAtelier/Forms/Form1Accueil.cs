using InstalleurSuiviAtelier.Forms;
using InstalleurSuiviAtelier.Properties;
using System;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace InstalleurSuiviAtelier
{
    public partial class Form1Accueil : Form
    {
        public Form1Accueil()
        {
            InitializeComponent();
            InitListBox();


        }

        //On passe au formulaire suivant
        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            if (clickButtonGlobal())
            {
                Form2CreationRepSA f2 = new Form2CreationRepSA();
                f2.ShowDialog();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (clickButtonGlobal())
            {
                Form15UpdateSA f2 = new Form15UpdateSA();
                f2.ShowDialog();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private bool clickButtonGlobal()
        {
            if (listBoxWebApps.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une version du Suivi Atelier à mettre en place.", "Choix de version manquant",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                this.Hide();
                InstallInfos.versionInstall = listBoxWebApps.SelectedItem.ToString();
                return true;
            }
        }

        //Récupère les différentes version du suivi atelier 
        //formate les noms des ressources, et place dans la liste les différentes versions,
        //sera utilisé pour le reste de l'install/maj
        //Il est nécessaire de cliquer une case
        private void InitListBox()
        {
            
            /* Reference to your resources class -- may be named differently in your case */
            ResourceManager MyResourceClass =
                new ResourceManager(typeof(Resources));

            ResourceSet resourceSet =
                MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            ArrayList listeVersions = new ArrayList();

            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceName = entry.Key.ToString();


                //On veut garder seulement les ressources du type "SuiviAtelier_X_X_X_pro"
                //Puis récupérer seulement la version pour l'afficher dans le 
                if (resourceName.StartsWith("SuiviAtelier"))
                {
                    resourceName = Regex.Replace(resourceName, @"[^\d]", "");
                    resourceName = resourceName.Insert(1, ".");
                    resourceName = resourceName.Insert(3, ".");

                    listeVersions.Add(resourceName);
                    //listBoxWebApps.Items.Add(resourceName);
                }

            }

            //On trie la liste par ordre alphabétique
            listeVersions.Sort();
            listeVersions.Reverse();
            //Puis on ajoute tout à l'élément graphique ListBox
            foreach (string s in listeVersions)
            {
                listBoxWebApps.Items.Add(s);
            }

            Trace.WriteLine(listBoxWebApps.Sorted);
        }
    }
}
