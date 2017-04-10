namespace Abi
{
    partial class frmContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblFonctionContact = new System.Windows.Forms.Label();
            this.lblIdActive = new System.Windows.Forms.Label();
            this.lbldContact = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.lblTelContact = new System.Windows.Forms.Label();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.lblProjets = new System.Windows.Forms.Label();
            this.txtEntreprise = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtProjet = new System.Windows.Forms.TextBox();
            this.txtidClient = new System.Windows.Forms.TextBox();
            this.lblidClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDocuments
            // 
            this.btnDocuments.Enabled = false;
            this.btnDocuments.Location = new System.Drawing.Point(7, 294);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(123, 23);
            this.btnDocuments.TabIndex = 30;
            this.btnDocuments.Text = "&Documents";
            this.btnDocuments.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(319, 294);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 29;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(403, 294);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 28;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(576, 294);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 27;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(495, 294);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblFonctionContact
            // 
            this.lblFonctionContact.AutoSize = true;
            this.lblFonctionContact.Location = new System.Drawing.Point(12, 77);
            this.lblFonctionContact.Name = "lblFonctionContact";
            this.lblFonctionContact.Size = new System.Drawing.Size(132, 13);
            this.lblFonctionContact.TabIndex = 33;
            this.lblFonctionContact.Text = "Fonction du Contact Client";
            // 
            // lblIdActive
            // 
            this.lblIdActive.AutoSize = true;
            this.lblIdActive.Location = new System.Drawing.Point(538, 9);
            this.lblIdActive.Name = "lblIdActive";
            this.lblIdActive.Size = new System.Drawing.Size(118, 13);
            this.lblIdActive.TabIndex = 34;
            this.lblIdActive.Text = "Numéro d\'activité Client";
            // 
            // lbldContact
            // 
            this.lbldContact.AutoSize = true;
            this.lbldContact.Location = new System.Drawing.Point(557, 50);
            this.lbldContact.Name = "lbldContact";
            this.lbldContact.Size = new System.Drawing.Size(99, 13);
            this.lbldContact.TabIndex = 35;
            this.lbldContact.Text = "Numéro de Contact";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(12, 31);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(29, 13);
            this.lblNomContact.TabIndex = 36;
            this.lblNomContact.Text = "Nom";
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(12, 53);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomContact.TabIndex = 37;
            this.lblPrenomContact.Text = "Prénom";
            // 
            // lblTelContact
            // 
            this.lblTelContact.AutoSize = true;
            this.lblTelContact.Location = new System.Drawing.Point(12, 99);
            this.lblTelContact.Name = "lblTelContact";
            this.lblTelContact.Size = new System.Drawing.Size(58, 13);
            this.lblTelContact.TabIndex = 38;
            this.lblTelContact.Text = "Téléphone";
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Location = new System.Drawing.Point(9, 9);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(54, 13);
            this.lblEntreprise.TabIndex = 39;
            this.lblEntreprise.Text = "Entreprise";
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Location = new System.Drawing.Point(12, 122);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(39, 13);
            this.lblProjets.TabIndex = 40;
            this.lblProjets.Text = "Projets";
            // 
            // txtEntreprise
            // 
            this.txtEntreprise.Location = new System.Drawing.Point(148, 6);
            this.txtEntreprise.Name = "txtEntreprise";
            this.txtEntreprise.Size = new System.Drawing.Size(299, 20);
            this.txtEntreprise.TabIndex = 41;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(148, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(299, 20);
            this.txtNom.TabIndex = 42;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(148, 50);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(299, 20);
            this.txtPrenom.TabIndex = 43;
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(148, 74);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(299, 20);
            this.txtFonction.TabIndex = 44;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(148, 96);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(299, 20);
            this.txtTelephone.TabIndex = 45;
            // 
            // txtActivite
            // 
            this.txtActivite.Enabled = false;
            this.txtActivite.Location = new System.Drawing.Point(541, 28);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.Size = new System.Drawing.Size(115, 20);
            this.txtActivite.TabIndex = 47;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(541, 66);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(115, 20);
            this.txtContact.TabIndex = 48;
            // 
            // txtProjet
            // 
            this.txtProjet.Location = new System.Drawing.Point(148, 122);
            this.txtProjet.Name = "txtProjet";
            this.txtProjet.Size = new System.Drawing.Size(299, 20);
            this.txtProjet.TabIndex = 49;
            // 
            // txtidClient
            // 
            this.txtidClient.Enabled = false;
            this.txtidClient.Location = new System.Drawing.Point(536, 115);
            this.txtidClient.Name = "txtidClient";
            this.txtidClient.ReadOnly = true;
            this.txtidClient.Size = new System.Drawing.Size(115, 20);
            this.txtidClient.TabIndex = 51;
            // 
            // lblidClient
            // 
            this.lblidClient.AutoSize = true;
            this.lblidClient.Location = new System.Drawing.Point(552, 99);
            this.lblidClient.Name = "lblidClient";
            this.lblidClient.Size = new System.Drawing.Size(88, 13);
            this.lblidClient.TabIndex = 50;
            this.lblidClient.Text = "Numéro de Client";
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 328);
            this.Controls.Add(this.txtidClient);
            this.Controls.Add(this.lblidClient);
            this.Controls.Add(this.txtProjet);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtActivite);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtFonction);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtEntreprise);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.lblEntreprise);
            this.Controls.Add(this.lblTelContact);
            this.Controls.Add(this.lblPrenomContact);
            this.Controls.Add(this.lblNomContact);
            this.Controls.Add(this.lbldContact);
            this.Controls.Add(this.lblIdActive);
            this.Controls.Add(this.lblFonctionContact);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "frmContact";
            this.Text = "ABI - Fiche Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblFonctionContact;
        private System.Windows.Forms.Label lblIdActive;
        private System.Windows.Forms.Label lbldContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblTelContact;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.TextBox txtEntreprise;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtActivite;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtProjet;
        private System.Windows.Forms.TextBox txtidClient;
        private System.Windows.Forms.Label lblidClient;
    }
}