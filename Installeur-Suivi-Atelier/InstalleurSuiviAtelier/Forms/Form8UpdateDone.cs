using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalleurSuiviAtelier.Forms
{
    public partial class Form8UpdateDone : Form
    {
        public Form8UpdateDone()
        {
            InitializeComponent();
            if (true)
            {
                //ok
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = @"Dans le menu Démarrer, cliquez sur Panneau de configuration, cliquez sur Système et sécurité, puis sur Pare-feu Windows.

- Cliquez sur Paramètres avancés.
- Cliquez sur Règles de trafic entrant.
- Cliquez sur Nouvelle règle dans la fenêtre Actions.
- Cliquez sur Type de règle de Port.
- Cliquez sur Suivant.
- Dans la page Protocole et ports, cliquez sur TCP.
- Sélectionnez Ports locaux spécifiques et tapez la valeur du/des ports utilisés*.
- Cliquez sur Suivant.
- Dans la page Action, cliquez sur Autoriser la connexion.
- Cliquez sur Suivant.
- Dans la page Profil, cliquez sur les options appropriées pour votre environnement.
- Cliquez sur Suivant.
- Dans la page Nom, entrez un nom de Suivi Atelier (TCP sur le(s) ports (=n° choisi(s))).
- Cliquez sur Terminer.

*Si vous installez plusieurs Suivi Atelier, il faut ajouter la liste des numéros de port que vous avez utilisée.
";
            string title = "Aide";
            MessageBox.Show(message, title);
        }
    }
}
