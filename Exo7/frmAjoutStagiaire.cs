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
            if (this.Controle())
            {
                if (this.Instancie())
                {
                    MStagiaire.Nstag += 1;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Boolean Controle()
        {
            Boolean code = true;
            if (!(EstEntier(txtNum.Text)))
            {
                code = false;
                MessageBox.Show("Matricule incorrect", "Erreur FrmAjoutStagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(EstEntier(txtCodePostal.Text)))
            {
                code = false;
                MessageBox.Show("code Postal Incorrect", "Erreur FrmAjoutStagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return code;
        }

        private Boolean EstEntier(String s)
        {
            Int32 i;
            Char c;
            Boolean code = true;

            if(s.Length < 10 && s.Length > 0)
            {
                for(i=0; i <s.Length; i++)
                {
                    c = s[i];
                    if (!(Char.IsDigit(c)))
                    {
                        code = false;
                    }
                }
            }
            else
            {
                code = false;
            }
            return code;
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
