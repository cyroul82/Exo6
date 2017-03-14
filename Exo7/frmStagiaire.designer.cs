namespace Exo6
{
    partial class frmStagiaire
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
            this.groupBoxStagiare = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelTown = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.groupBoxStagiare.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStagiare
            // 
            this.groupBoxStagiare.Controls.Add(this.groupBox1);
            this.groupBoxStagiare.Controls.Add(this.txtCodePostal);
            this.groupBoxStagiare.Controls.Add(this.txtTown);
            this.groupBoxStagiare.Controls.Add(this.txtAddress);
            this.groupBoxStagiare.Controls.Add(this.txtFirstName);
            this.groupBoxStagiare.Controls.Add(this.txtName);
            this.groupBoxStagiare.Controls.Add(this.txtNum);
            this.groupBoxStagiare.Controls.Add(this.labelPostalCode);
            this.groupBoxStagiare.Controls.Add(this.labelTown);
            this.groupBoxStagiare.Controls.Add(this.lblAddress);
            this.groupBoxStagiare.Controls.Add(this.labelFirstName);
            this.groupBoxStagiare.Controls.Add(this.lblName);
            this.groupBoxStagiare.Controls.Add(this.lblNum);
            this.groupBoxStagiare.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStagiare.Name = "groupBoxStagiare";
            this.groupBoxStagiare.Size = new System.Drawing.Size(423, 199);
            this.groupBoxStagiare.TabIndex = 0;
            this.groupBoxStagiare.TabStop = false;
            this.groupBoxStagiare.Text = "Stagiaire";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(139, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(103, 155);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(155, 20);
            this.txtCodePostal.TabIndex = 11;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(103, 129);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(314, 20);
            this.txtTown.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 104);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(314, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(103, 78);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(314, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(314, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(103, 26);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(155, 20);
            this.txtNum.TabIndex = 6;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(16, 159);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(73, 13);
            this.labelPostalCode.TabIndex = 5;
            this.labelPostalCode.Text = "Code Postal : ";
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Location = new System.Drawing.Point(19, 133);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(35, 13);
            this.labelTown.TabIndex = 4;
            this.labelTown.Text = "Ville : ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 108);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Adresse : ";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(16, 81);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(52, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Prénom : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nom : ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(16, 30);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(81, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numéro OSIA : ";
            // 
            // frmStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 222);
            this.Controls.Add(this.groupBoxStagiare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStagiaire";
            this.Text = "Form1";
            this.groupBoxStagiare.ResumeLayout(false);
            this.groupBoxStagiare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.GroupBox groupBoxStagiare;
        protected System.Windows.Forms.Label lblName;
        protected System.Windows.Forms.Label lblNum;
        protected System.Windows.Forms.TextBox txtCodePostal;
        protected System.Windows.Forms.TextBox txtTown;
        protected System.Windows.Forms.TextBox txtAddress;
        protected System.Windows.Forms.TextBox txtFirstName;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.TextBox txtNum;
        protected System.Windows.Forms.Label labelPostalCode;
        protected System.Windows.Forms.Label labelTown;
        protected System.Windows.Forms.Label lblAddress;
        protected System.Windows.Forms.Label labelFirstName;
    }
}

