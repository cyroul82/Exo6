namespace Exo7
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRechercer = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblRecherche);
            this.flowLayoutPanel1.Controls.Add(this.txtSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnRechercer);
            this.flowLayoutPanel1.Controls.Add(this.btnTous);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(763, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblRecherche
            // 
            this.lblRecherche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(3, 8);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(89, 13);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Nom recherché : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(98, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnRechercer
            // 
            this.btnRechercer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRechercer.Location = new System.Drawing.Point(408, 3);
            this.btnRechercer.Name = "btnRechercer";
            this.btnRechercer.Size = new System.Drawing.Size(75, 23);
            this.btnRechercer.TabIndex = 2;
            this.btnRechercer.Text = "Rechercher";
            this.btnRechercer.UseVisualStyleBackColor = true;
            // 
            // btnTous
            // 
            this.btnTous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTous.Location = new System.Drawing.Point(489, 3);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(75, 23);
            this.btnTous.TabIndex = 3;
            this.btnTous.Text = "Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btnQuitter);
            this.flowLayoutPanel2.Controls.Add(this.btnAjouter);
            this.flowLayoutPanel2.Controls.Add(this.btnSupprimer);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 481);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(763, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToOrderColumns = true;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(763, 452);
            this.dataGridViewList.TabIndex = 2;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitter.Location = new System.Drawing.Point(685, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.Location = new System.Drawing.Point(604, 3);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSupprimer.Location = new System.Drawing.Point(523, 3);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 510);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRechercer;
        private System.Windows.Forms.Button btnTous;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}

