using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exo6;

namespace Exo7
{
    public partial class frmVisuStagiaire : Exo6.frmStagiaire
    {
        private MStagiaire stagiaire;
        public frmVisuStagiaire(ref MStagiaire stagiaire)
        {
            this.stagiaire = stagiaire;
            InitializeComponent();
        }

        private void frmVisuStagiaire_Load(object sender, EventArgs e)
        {
            afficheStagiaire(stagiaire);
        }

        private void afficheStagiaire(MStagiaire stagiaire)
        {
            txtNum.Text = stagiaire.NumOsia.ToString();
            txtName.Text = stagiaire.Nom;
            txtAddress.Text = stagiaire.Rue;
            txtCodePostal.Text = stagiaire.Codepostal.ToString();
            txtFirstName.Text = stagiaire.Prenom;
            txtTown.Text = stagiaire.Ville;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (this.Controle())
            {
                if (this.updateSagiaire())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
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

            if (s.Length < 10 && s.Length > 0)
            {
                for (i = 0; i < s.Length; i++)
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

        private Boolean updateSagiaire()
        {
            try
            {
                stagiaire.NumOsia = Int32.Parse(base.txtNum.Text.Trim());
                stagiaire.Nom = base.txtName.Text;
                stagiaire.Prenom = base.txtFirstName.Text;
                stagiaire.Rue = base.txtAddress.Text;
                stagiaire.Ville = base.txtTown.Text;
                stagiaire.Codepostal = base.txtCodePostal.Text.Trim();
                return true;
            }
            catch
            {
                MessageBox.Show("Erreur entrée ", "Erreur FrmAjoutStagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            afficheStagiaire(stagiaire);
            
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
