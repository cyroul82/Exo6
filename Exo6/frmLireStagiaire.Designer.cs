namespace Exo6
{
    partial class frmLireStagiaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMove = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxStagiare.SuspendLayout();
            this.groupBoxMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.Controls.Add(this.btnLast);
            this.groupBoxMove.Controls.Add(this.btnNext);
            this.groupBoxMove.Controls.Add(this.btnPrevious);
            this.groupBoxMove.Controls.Add(this.btnFirst);
            this.groupBoxMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMove.Location = new System.Drawing.Point(82, 217);
            this.groupBoxMove.Name = "groupBoxMove";
            this.groupBoxMove.Size = new System.Drawing.Size(353, 82);
            this.groupBoxMove.TabIndex = 4;
            this.groupBoxMove.TabStop = false;
            this.groupBoxMove.Text = "Se déplacer";
            this.groupBoxMove.Visible = false;
            // 
            // btnLast
            // 
            this.btnLast.Enabled = false;
            this.btnLast.Location = new System.Drawing.Point(261, 35);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Dernier >>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(180, 35);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Suivant >";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(99, 35);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "< Précedent";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.Location = new System.Drawing.Point(18, 35);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<< Premier";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(12, 236);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(212, 13);
            this.lblErreur.TabIndex = 7;
            this.lblErreur.Text = "Il n\'y a aucun stagiaire actuellement";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(360, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(279, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmLireStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(445, 339);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxMove);
            this.Name = "frmLireStagiaire";
            this.Load += new System.EventHandler(this.frmLireStagiaire_Load);
            this.Controls.SetChildIndex(this.groupBoxMove, 0);
            this.Controls.SetChildIndex(this.groupBoxStagiare, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.lblErreur, 0);
            this.groupBoxStagiare.ResumeLayout(false);
            this.groupBoxStagiare.PerformLayout();
            this.groupBoxMove.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMove;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblErreur;
    }
}
