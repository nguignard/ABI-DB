namespace Abi
{
    partial class frmGrdContacts
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
            this.lblContactVide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblContactVide
            // 
            this.lblContactVide.AutoSize = true;
            this.lblContactVide.BackColor = System.Drawing.SystemColors.Info;
            this.lblContactVide.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblContactVide.Location = new System.Drawing.Point(166, 341);
            this.lblContactVide.Name = "lblContactVide";
            this.lblContactVide.Size = new System.Drawing.Size(197, 13);
            this.lblContactVide.TabIndex = 8;
            this.lblContactVide.Text = "Le Client n\'a pas encore de Contact >>>";
            // 
            // frmGrdContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(618, 371);
            this.Controls.Add(this.lblContactVide);
            this.Name = "frmGrdContacts";
            this.Text = "ABI - LISTE CONTACT                                                              " +
    "                                                                      ";
            this.Controls.SetChildIndex(this.lblCltDspNomRecherche, 0);
            this.Controls.SetChildIndex(this.txtCltDspNomRecherche, 0);
            this.Controls.SetChildIndex(this.btnCltDspTous, 0);
            this.Controls.SetChildIndex(this.btnCltDspRechercher, 0);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnCltDspSupprimer, 0);
            this.Controls.SetChildIndex(this.btnCltDspQuitter, 0);
            this.Controls.SetChildIndex(this.lblContactVide, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblContactVide;
    }
}
