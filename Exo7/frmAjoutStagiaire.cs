using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exo7;
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
            if (Tool.Controle(txtNum.Text))
            {
                if (Tool.Controle(txtCodePostal.Text))
                {
                    if (this.Instancie())
                    {
                        MStagiaire.Nstag += 1;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("code Postal Incorrect", "Erreur FrmAjoutStagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } else
            {
                MessageBox.Show("Matricule incorrect", "Erreur FrmAjoutStagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Boolean Instancie()
        {
            MStagiaire stagiaire = new MStagiaire();
            try
            {
                stagiaire.NumOsia = Int32.Parse(base.txtNum.Text.Trim());
                stagiaire.Nom = base.txtName.Text;
                stagiaire.Prenom = base.txtFirstName.Text;
                stagiaire.Rue = base.txtAddress.Text;
                stagiaire.Ville = base.txtTown.Text;
                stagiaire.Codepostal = base.txtCodePostal.Text.Trim();
                Donnees.listStagiaire.Add(stagiaire);
                return true;
            }
            catch
            {
                stagiaire = null;
                MessageBox.Show("Erreur entrée ", "Erreur FrmAjoutStagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
