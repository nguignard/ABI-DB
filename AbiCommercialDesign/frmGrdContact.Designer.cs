namespace Abi
{
    partial class frmGrdContact
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
            this.btnCltDspQuitter = new System.Windows.Forms.Button();
            this.btnCltDspSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.btnCltDspTous = new System.Windows.Forms.Button();
            this.txtCltDspNomRecherche = new System.Windows.Forms.TextBox();
            this.lblCltDspNomRecherche = new System.Windows.Forms.Label();
            this.btnRech = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCltDspQuitter
            // 
            this.btnCltDspQuitter.Location = new System.Drawing.Point(532, 368);
            this.btnCltDspQuitter.Name = "btnCltDspQuitter";
            this.btnCltDspQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspQuitter.TabIndex = 15;
            this.btnCltDspQuitter.Text = "&Quitter";
            this.btnCltDspQuitter.UseVisualStyleBackColor = true;
            this.btnCltDspQuitter.Click += new System.EventHandler(this.btnCltDspQuitter_Click);
            // 
            // btnCltDspSupprimer
            // 
            this.btnCltDspSupprimer.Location = new System.Drawing.Point(451, 368);
            this.btnCltDspSupprimer.Name = "btnCltDspSupprimer";
            this.btnCltDspSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspSupprimer.TabIndex = 14;
            this.btnCltDspSupprimer.Text = "&Supprimer";
            this.btnCltDspSupprimer.UseVisualStyleBackColor = true;
            this.btnCltDspSupprimer.Click += new System.EventHandler(this.btnCltDspSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(370, 368);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // grdContact
            // 
            this.grdContact.AllowUserToAddRows = false;
            this.grdContact.AllowUserToDeleteRows = false;
            this.grdContact.AllowUserToOrderColumns = true;
            this.grdContact.AllowUserToResizeColumns = false;
            this.grdContact.AllowUserToResizeRows = false;
            this.grdContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContact.Location = new System.Drawing.Point(14, 83);
            this.grdContact.MultiSelect = false;
            this.grdContact.Name = "grdContact";
            this.grdContact.ReadOnly = true;
            this.grdContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContact.Size = new System.Drawing.Size(636, 268);
            this.grdContact.TabIndex = 12;
            this.grdContact.DoubleClick += new System.EventHandler(this.grdContact_DoubleClick);
            // 
            // btnCltDspTous
            // 
            this.btnCltDspTous.Location = new System.Drawing.Point(518, 40);
            this.btnCltDspTous.Name = "btnCltDspTous";
            this.btnCltDspTous.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspTous.TabIndex = 10;
            this.btnCltDspTous.Text = "&Réinitialiser";
            this.btnCltDspTous.UseVisualStyleBackColor = true;
            this.btnCltDspTous.Click += new System.EventHandler(this.btnCltDspTous_Click);
            // 
            // txtCltDspNomRecherche
            // 
            this.txtCltDspNomRecherche.Location = new System.Drawing.Point(114, 41);
            this.txtCltDspNomRecherche.Name = "txtCltDspNomRecherche";
            this.txtCltDspNomRecherche.Size = new System.Drawing.Size(317, 20);
            this.txtCltDspNomRecherche.TabIndex = 9;
            this.txtCltDspNomRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCltDspNomRecherche_KeyUp_1);
            // 
            // lblCltDspNomRecherche
            // 
            this.lblCltDspNomRecherche.AutoSize = true;
            this.lblCltDspNomRecherche.Location = new System.Drawing.Point(11, 45);
            this.lblCltDspNomRecherche.Name = "lblCltDspNomRecherche";
            this.lblCltDspNomRecherche.Size = new System.Drawing.Size(94, 13);
            this.lblCltDspNomRecherche.TabIndex = 8;
            this.lblCltDspNomRecherche.Text = "&Nom Recherché : ";
            // 
            // btnRech
            // 
            this.btnRech.Location = new System.Drawing.Point(437, 40);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(75, 23);
            this.btnRech.TabIndex = 16;
            this.btnRech.Text = "Rechercher";
            this.btnRech.UseVisualStyleBackColor = true;
            // 
            // frmGrdContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 430);
            this.Controls.Add(this.btnRech);
            this.Controls.Add(this.btnCltDspQuitter);
            this.Controls.Add(this.btnCltDspSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grdContact);
            this.Controls.Add(this.btnCltDspTous);
            this.Controls.Add(this.txtCltDspNomRecherche);
            this.Controls.Add(this.lblCltDspNomRecherche);
            this.Name = "frmGrdContact";
            this.Text = "frmGrdContact";
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnCltDspQuitter;
        protected System.Windows.Forms.Button btnCltDspSupprimer;
        protected System.Windows.Forms.Button btnAjouter;
        protected System.Windows.Forms.DataGridView grdContact;
        protected System.Windows.Forms.Button btnCltDspTous;
        protected System.Windows.Forms.TextBox txtCltDspNomRecherche;
        protected System.Windows.Forms.Label lblCltDspNomRecherche;
        protected System.Windows.Forms.Button btnRech;
    }
}