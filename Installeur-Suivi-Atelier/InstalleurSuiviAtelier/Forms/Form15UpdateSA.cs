using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace InstalleurSuiviAtelier.Forms
{
    public partial class Form15UpdateSA : Form
    {
        public Form15UpdateSA()
        {
            InitializeComponent();
        }

        private void buttonParcourir_Click(object sender, EventArgs e)
        {
            SelectFolderDialog();
        }

        private void SelectFolderDialog()
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            //Si le folder choisi n'est pas rien, on change ce qu'il y a écrit dans la textBox
            if (result == DialogResult.OK)
                textBoxEmplacement.Text = folderBrowserDialog.SelectedPath;

        }

        private void textBoxEmplacement_TextChanged(object sender, EventArgs e)
        {

        }




        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            InstallInfos.tomcatBinPath = Path.Combine(textBoxEmplacement.Text, @"\bin");
            String tomcatPath = textBoxEmplacement.Text;

            //Vérifier le chemin
            if (Directory.Exists(textBoxEmplacement.Text))
            {
                //Vérifier l'existence de Tomcat/WebApps
                if (Directory.Exists(Path.Combine(textBoxEmplacement.Text, @"webapps")))
                {
                    String webAppsPath = Path.Combine(textBoxEmplacement.Text, @"webapps");
                    //Vérifier l'existence du .war dedans
                    string[] files = System.IO.Directory.GetFiles(webAppsPath, "*.war", System.IO.SearchOption.TopDirectoryOnly);
                    //if (files.Length > 0)
                    //{
                    //file exist

                    //(supprimer l'ancienne archivee web préssente)

                    if (files.Length > 0)
                    {
                        //SI on a deja un .war on le supprime
                        File.Delete(files[0]);
                    }


                    //STOP LE SERVICE!!!!       
                    String svcName = AskServiceName();

                    SvcManager.StopService(svcName, 15000);


                    Trace.WriteLine("Svc name = " + svcName);


                    //Suppression de l'ancien répertoire de l'appli web
                    try
                    {
                        Directory.Delete(Path.Combine(tomcatPath, @"webapps\SuiviAtelier"), true);
                    }
                    catch
                    {

                    }


                    //mettre les logs dans un old
                    String logPath = Path.Combine(tomcatPath, "logs");
                    string[] logs = Directory.GetFiles(logPath);

                    if (!Directory.Exists(Path.Combine(logPath, "old_logs")))
                    {
                        Directory.CreateDirectory(Path.Combine(logPath, "old_logs")); //attention si on a deja fait une maj ?
                    }

                    foreach (String oneLog in logs)
                    {
                        String fileName = Path.GetFileName(oneLog);
                        String destination = Path.Combine(logPath, "old_logs", fileName);
                        try
                        {
                            File.Move(oneLog, destination);
                        }
                        catch
                        {
                            //Le log est utilisé par un processus, on le laisse dans ce fichier
                            Trace.WriteLine("its ok just a log because service is mal éteint");
                        }


                    }

                    //mettre archivweb
                    //Dans le rep Source AVEC LE NUM DE VERSION

                    //if (!Directory.Exists(Path.Combine(tomcatPath, @"..\Sources")))
                    //{
                    //    Trace.WriteLine(Directory.Exists(Path.Combine(tomcatPath, @"..\Sources")));
                    //    Directory.CreateDirectory(Path.Combine(tomcatPath, @"..\Sources")); //attention si on a deja fait une maj ?
                    //}


                    if (!Directory.Exists(Path.Combine(tomcatPath, @"..\Sources")))
                    {
                        Directory.CreateDirectory(Path.Combine(tomcatPath, @"..\Sources"));
                    }
                    InstallInfos.InstallWebApp(Path.Combine(tomcatPath, @"..\Sources"), true);

                    //Sans la version (suivi atelier) dans webapps
                    InstallInfos.InstallWebApp(webAppsPath, false);




                    //LANCER LE SERVICE
                    SvcManager.StartService(svcName, 15000);

                    //}
                    //else
                    //{
                    //    setErreurOn("ERREUR - Pas de fichier .war dans le répertoire webapps de tomcat");
                    //    throw new Exception("ERREUR - Pas de fichier .war dans le répertoire webapps de tomcat");
                    //    //ERROR MESSAGE
                    //    //Pas d'application .war
                    //}

                }
                else
                {
                    setErreurOn("ERREUR - Le répertoire webapps n'a pas été trouvé");
                    //ERROR MESSAGE 
                    //Pas de repertoire webapps
                    throw new Exception("ERREUR - Le répertoire webapps n'a pas été trouvé");
                }
            }
            else
            {
                setErreurOn("ERREUR - Le répertoire d'installation renseigné n'a pas été trouvé.");
                //ERROR MESSAGE
                //répertoire d'install tomcat introuvable
                throw new Exception("ERREUR - Le répertoire d'installation renseigné n'a pas été trouvé.");
            }
            //Mettre le .war qu'on a en le renommant
            //InstallWebApp();

            labelError.Text = "MISE A JOUR TERMINEE";
            labelError.ForeColor = System.Drawing.Color.Green;

            Form8UpdateDone form = new Form8UpdateDone();
            this.Hide();
            form.Show();
        }

        private String AskServiceName()
        {
            PopUpSvcName dialogBox = new PopUpSvcName();
            String svcName;

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (dialogBox.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                svcName = dialogBox.GetSvcName();
            }
            else
            {
                svcName = "Cancelled";
            }
            dialogBox.Dispose();

            return svcName;
        }

        private void setErreurOn(String texte)
        {
            this.labelError.Text = "Une erreur est survenue lors de la mise à jour de l'application.\n" + texte;
        }

        private void Form15UpdateSA_Load(object sender, EventArgs e)
        {

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
