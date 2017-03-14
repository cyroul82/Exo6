using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo6;

namespace Exo6
{
    public class MStagiaire
    {
        public static Int32 Nstag;
        public Int32 NumOsia { get; set; }


        private String nomStagiaire;
        
        public String Nom {
            get {
                return this.nomStagiaire;
            }
            set {
                this.nomStagiaire = value.Trim().ToUpper(); }
        }
        private String prenomStagiaire;
        public String Prenom
        { get
            {
                return this.prenomStagiaire;
            }
            set
            {
                this.prenomStagiaire = value.Trim().ToLower();
            }
        }
        public String Rue { get; set; }
        private String villeStagiaire;
        public String Ville
        {
            get
            {
                return this.villeStagiaire;
            }
            set
            {
                this.villeStagiaire = value.Trim().ToUpper();
            }
        }
        private String codePostalStagiaire;
        public String Codepostal
        {
            get {
                return this.codePostalStagiaire;
            }
            set {
                Boolean erreur = false;
                if(value.Length == 5)
                {
                    for(Int32 i=0; i<value.Length; i++)
                    {
                        if (!(Char.IsDigit(value[i])))
                        {
                            erreur = true;
                        }
                        if (erreur)
                        {
                            //System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres");
                        }
                        else this.codePostalStagiaire = value;
                    }
                }
                else
                {
                    //System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : must have 5 digits !!!", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres min and max !");
                }
            }
        }
        private Int32 nbreNotes;
        private Double pointsNotes;
    }
}
