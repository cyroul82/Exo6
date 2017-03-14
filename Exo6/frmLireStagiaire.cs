using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo6
{
    public partial class frmLireStagiaire : Exo6.frmStagiaire
    {
        private Int32 iStag;
        public frmLireStagiaire()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAjoutStagiaire frmAjout = new frmAjoutStagiaire();
            if(frmAjout.ShowDialog() == DialogResult.OK)
            {
                base.groupBoxStagiare.Visible = true;
                lblErreur.Visible = false;
                groupBoxMove.Visible = true;
                iStag = MStagiaire.Nstag - 1;
                afficheButtons();
                afficheUnStagiaire(iStag);


            }
        }

        private void afficheUnStagiaire(Int32 i)
        {
            MStagiaire stagiaire = Donnees.listStagiaire[i];
            base.txtNum.Text = stagiaire.NumOsia.ToString();
            base.txtName.Text = stagiaire.Nom;
            base.txtFirstName.Text = stagiaire.Prenom;
            base.txtAddress.Text = stagiaire.Rue;
            base.txtTown.Text = stagiaire.Ville;
            base.txtCodePostal.Text = stagiaire.Codepostal;

        }

        private void frmLireStagiaire_Load(object sender, EventArgs e)
        {
            base.groupBoxStagiare.Visible = false;
            lblErreur.Visible = true;
            groupBoxMove.Visible = false;
        }

        

        private void afficheButtons()
        {
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            if(iStag == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }

            if(iStag == MStagiaire.Nstag - 1)
            {
                btnLast.Enabled = false;
                btnNext.Enabled = false;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            iStag = 0;
            afficheButtons();
            afficheUnStagiaire(iStag);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            iStag -= 1;
            afficheUnStagiaire(iStag);
            afficheButtons();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            iStag += 1;
            afficheUnStagiaire(iStag);
            afficheButtons();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            iStag = MStagiaire.Nstag - 1;
            afficheUnStagiaire(iStag);
            afficheButtons();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
