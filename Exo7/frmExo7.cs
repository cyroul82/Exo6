using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exo6;

namespace Exo7
{
    public partial class frmExo7 : Form
    {
        public frmExo7()
        {
            InitializeComponent();
            afficheButton();
        }

        private void afficheStagiaires()
        {
            
            DataTable dt = new DataTable();
            DataRow dr;
            Int32 i;

            dt.Columns.Add(new DataColumn("Numéro OSIA", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));

            
                for (i = 0; i < Donnees.listStagiaire.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = Donnees.listStagiaire[i].NumOsia;
                    dr[1] = Donnees.listStagiaire[i].Nom;
                    dr[2] = Donnees.listStagiaire[i].Prenom;
                    dt.Rows.Add(dr);
                }
                grdStagiaires.DataSource = dt.DefaultView;

           
            afficheButton();
            

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjoutStagiaire frmAjout = new frmAjoutStagiaire();
            if(frmAjout.ShowDialog() == DialogResult.OK)
            {
                afficheStagiaires();
            }
        }

        private void grdStagiaires_DoubleClick(object sender, EventArgs e)
        {
            Int32 iStag;

            iStag = grdStagiaires.CurrentRow.Index;
            if (iStag != -1)
            {

                MStagiaire stagiaire = Donnees.listStagiaire[iStag];

                frmVisuStagiaire frmVisu = new frmVisuStagiaire(ref stagiaire);

                if (frmVisu.ShowDialog() == DialogResult.OK)
                {
                    afficheStagiaires();
                }
            }
            
        }

        private void afficheButton()
        {
            if (grdStagiaires.RowCount == 0)
            {
                btnSupprimer.Enabled = false;
            }
            else btnSupprimer.Enabled = true;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Int32 index = grdStagiaires.CurrentRow.Index;
            if (index != -1)
            {
                Donnees.listStagiaire.Remove(Donnees.listStagiaire[index]);

                this.afficheStagiaires();
                MStagiaire.Nstag -= 1;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRechercer_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != null)
            {
                ((DataView)grdStagiaires.DataSource).RowFilter = "Nom like '%" + txtSearch.Text + "%'";
            }
        }

        private void btnTous_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            ((DataView)grdStagiaires.DataSource).RowFilter = null;
        }
    }
}
