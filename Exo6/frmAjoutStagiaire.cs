using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo6
{
    public partial class frmAjoutStagiaire : Exo6.frmStagiaire
    {
        public frmAjoutStagiaire()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            try
            {
                MStagiaire stagiaire = new MStagiaire();
                stagiaire.NumOsia = Int32.Parse(base.txtNum.Text.Trim());
                stagiaire.Nom = base.txtName.Text;
                stagiaire.Prenom = base.txtFirstName.Text;
                stagiaire.Rue = base.txtAddress.Text;
                stagiaire.Ville = base.txtTown.Text;
                stagiaire.Codepostal = base.txtCodePostal.Text.Trim();
                Donnees.listStagiaire.Add(stagiaire);
                MStagiaire.Nstag += 1;
                this.DialogResult = DialogResult.OK;

            }
            catch 
            {
                MessageBox.Show("Erreur entrée ", "Erreur FrmAjoutStagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
