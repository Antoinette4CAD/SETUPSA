using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalleurSuiviAtelier.Forms
{
    public partial class Form2CreationRepSA : Form
    {
        public Form2CreationRepSA()
        {
            InitializeComponent();
        }

        private void ButtonSuivant_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(textBoxEmplacement.Text);

            if (Directory.Exists(textBoxEmplacement.Text))
            {
                //Directory exists
            }
            else
            {
                //Directory does not exist
                di.Create();
            }



            //Pour créer le rep d'install Tomcat comme ça l'user le voit
            DirectoryInfo dirTomcat = new DirectoryInfo(Path.Combine(di.FullName, "Tomcat-8.5"));
            dirTomcat.Create();

            //We change form if everything's good
            this.Hide();

            //On met à jour la variable globale de la classe InstallInfos
            InstallInfos.repPrincipal = di.FullName;

            Form3JavaPathAndOpenJDK f3 = new Form3JavaPathAndOpenJDK();
            f3.ShowDialog();
        }

        //When clicking on the textBox, the folder browser opens
        private void TextBoxEmplacement_Enter(object sender, EventArgs e)
        {
            SelectFolderDialog();
        }

        private void ButtonParcourir_Click(object sender, EventArgs e)
        {
            SelectFolderDialog();
        }

        //bool IsValidFilename(string fileName)
        //{
        //    System.IO.FileInfo fi = null;
        //    try
        //    {
        //        fi = new System.IO.FileInfo(fileName);
        //    }
        //    catch (ArgumentException) { }
        //    catch (System.IO.PathTooLongException) { }
        //    catch (NotSupportedException) { }
        //    if (ReferenceEquals(fi, null))
        //    {
        //        return false;// file name is not valid
        //    }
        //    else
        //    {
        //        return true;// file name is valid... May check for existence by calling fi.Exists.
        //    }
        //}

        private void SelectFolderDialog()
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            //Si le folder choisi n'est pas rien, on change ce qu'il y a écrit dans la textBox
            if (result == DialogResult.OK)
                textBoxEmplacement.Text = folderBrowserDialog.SelectedPath;

        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3JavaPathAndOpenJDK f3 = new Form3JavaPathAndOpenJDK();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1Accueil f1 = new Form1Accueil();
            f1.Show();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
