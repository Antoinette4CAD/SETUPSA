using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalleurSuiviAtelier.Forms
{
    public partial class Form4InstallTomcat : Form
    {
        public Form4InstallTomcat()
        {
            InitializeComponent();

            //On cache les labels 
            labelInfoPort.Text = "";
            labelError.Text = "";
            labelPortDispo.Text = "";

            labelNomService.Text = InstallInfos.getSvcName();    
            labelRepInstall.Text = InstallInfos.repPrincipal + @"\Tomcat-8.5\";
            labelZulu.Text = InstallInfos.zuluPath;

            InstallInfos.tomcatBinPath = Path.Combine(labelRepInstall.Text, "bin");


            //Tooltip
            toolTipTrouverPort.SetToolTip(this.buttonTrouver, "Trouvez un numéro de port qui n'est pas actuellement ouvert sur votre machine.");
        }

        private void CreateAndLaunchTomcatExe()
        {
            //On va utiliser le dossier Temp de windows pour récupérer le fichier archive
            String path = Path.GetTempPath();
            path = Path.Combine(path, "tomcat.exe");

            //On convertit le fichier présent dans les Resources de bytes à un fichier
            File.WriteAllBytes(path, Properties.Resources.tomcatInstal);

            try
            {
                Process.Start(path);
            }
            catch (Exception)
            {
                labelError.Text = "Erreur lors de l'ouverture de l'installeur TOMCAT. Relancez l'installeur en mode administrateur, si l'erreur persiste, installez Tomcat à côté et passez cette étape.";
                label2.Visible = false;
            }
        }




        //Permet de récupérer le prochain port TCP disponible
        static int FreeTcpPort()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelPortDispo.Text = FreeTcpPort().ToString();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            CreateAndLaunchTomcatExe();

            if (!TcpPortIsOpen(8080))
            {
                labelInfoPort.Text = "Le port 8080 n'est pas actuellement ouvert sur votre machine.";
                labelInfoPort.ForeColor = Color.Green;
            }
            else
            {
                labelInfoPort.Text = "Attention, le port 8080 est ouvert et actuellement utilisé sur votre machine.";
                labelInfoPort.ForeColor = Color.Red;
            }

        }

        //Renvoie TRUE si le port en question est ouvert (donc utilisé) false sinon
        private bool TcpPortIsOpen(int portNumber)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            foreach (TcpConnectionInformation tcp in tcpConnInfoArray)
                if (tcp.LocalEndPoint.Port == portNumber)
                    return true;

            return false;
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

            Form5TomcatService f5 = new Form5TomcatService();
            f5.Show();

            this.Hide();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            Form5TomcatService f5 = new Form5TomcatService();
            f5.Show();

            this.Hide();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            Form3JavaPathAndOpenJDK f3 = new Form3JavaPathAndOpenJDK();
            this.Hide();
            f3.Show();
        }
    }
}

