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
    public partial class PopUpSvcName : Form
    {
        public String GetSvcName()
        {
            return this.textBoxSvc.Text;
        }

        public PopUpSvcName()
        {
            InitializeComponent();
            buttonOK.DialogResult = DialogResult.OK;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
