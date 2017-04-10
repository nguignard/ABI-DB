namespace Abi
{
    partial class frmGrdClt
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
            this.lblCltDspNomRecherche = new System.Windows.Forms.Label();
            this.txtCltDspNomRecherche = new System.Windows.Forms.TextBox();
            this.btnCltDspTous = new System.Windows.Forms.Button();
            this.grdCltDsp = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnCltDspSupprimer = new System.Windows.Forms.Button();
            this.btnCltDspQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCltDsp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCltDspNomRecherche
            // 
            this.lblCltDspNomRecherche.AutoSize = true;
            this.lblCltDspNomRecherche.Location = new System.Drawing.Point(10, 13);
            this.lblCltDspNomRecherche.Name = "lblCltDspNomRecherche";
            this.lblCltDspNomRecherche.Size = new System.Drawing.Size(94, 13);
            this.lblCltDspNomRecherche.TabIndex = 0;
            this.lblCltDspNomRecherche.Text = "&Nom Recherché : ";
            // 
            // txtCltDspNomRecherche
            // 
            this.txtCltDspNomRecherche.Location = new System.Drawing.Point(113, 10);
            this.txtCltDspNomRecherche.Name = "txtCltDspNomRecherche";
            this.txtCltDspNomRecherche.Size = new System.Drawing.Size(317, 20);
            this.txtCltDspNomRecherche.TabIndex = 1;
            this.txtCltDspNomRecherche.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCltDspNomRecherche_KeyUp);
            // 
            // btnCltDspTous
            // 
            this.btnCltDspTous.Location = new System.Drawing.Point(450, 8);
            this.btnCltDspTous.Name = "btnCltDspTous";
            this.btnCltDspTous.Size = new System.Drawing.Size(156, 23);
            this.btnCltDspTous.TabIndex = 2;
            this.btnCltDspTous.Text = "&Tous Réafficher";
            this.btnCltDspTous.UseVisualStyleBackColor = true;
            this.btnCltDspTous.Click += new System.EventHandler(this.btnCltDspTous_Click);
            // 
            // grdCltDsp
            // 
            this.grdCltDsp.AllowUserToAddRows = false;
            this.grdCltDsp.AllowUserToDeleteRows = false;
            this.grdCltDsp.AllowUserToOrderColumns = true;
            this.grdCltDsp.AllowUserToResizeColumns = false;
            this.grdCltDsp.AllowUserToResizeRows = false;
            this.grdCltDsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCltDsp.Location = new System.Drawing.Point(13, 51);
            this.grdCltDsp.MultiSelect = false;
            this.grdCltDsp.Name = "grdCltDsp";
            this.grdCltDsp.ReadOnly = true;
            this.grdCltDsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCltDsp.Size = new System.Drawing.Size(593, 268);
            this.grdCltDsp.TabIndex = 4;
            this.grdCltDsp.SelectionChanged += new System.EventHandler(this.grdCltDsp_SelectionChanged);
            this.grdCltDsp.DoubleClick += new System.EventHandler(this.grdCltDsp_DoubleClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(369, 336);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnCltDspSupprimer
            // 
            this.btnCltDspSupprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCltDspSupprimer.Location = new System.Drawing.Point(450, 336);
            this.btnCltDspSupprimer.Name = "btnCltDspSupprimer";
            this.btnCltDspSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspSupprimer.TabIndex = 6;
            this.btnCltDspSupprimer.Text = "&Supprimer";
            this.btnCltDspSupprimer.UseVisualStyleBackColor = true;
            this.btnCltDspSupprimer.Click += new System.EventHandler(this.btnCltDspSupprimer_Click);
            // 
            // btnCltDspQuitter
            // 
            this.btnCltDspQuitter.Location = new System.Drawing.Point(531, 336);
            this.btnCltDspQuitter.Name = "btnCltDspQuitter";
            this.btnCltDspQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnCltDspQuitter.TabIndex = 7;
            this.btnCltDspQuitter.Text = "&Quitter";
            this.btnCltDspQuitter.UseVisualStyleBackColor = true;
            this.btnCltDspQuitter.Click += new System.EventHandler(this.btnCltDspQuitter_Click);
            // 
            // frmGrdClt
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCltDspSupprimer;
            this.ClientSize = new System.Drawing.Size(618, 371);
            this.Controls.Add(this.btnCltDspQuitter);
            this.Controls.Add(this.btnCltDspSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grdCltDsp);
            this.Controls.Add(this.btnCltDspTous);
            this.Controls.Add(this.txtCltDspNomRecherche);
            this.Controls.Add(this.lblCltDspNomRecherche);
            this.Name = "frmGrdClt";
            this.Text = "ABI - LISTE CLIENT                                                               " +
    "                                                                     ";
            ((System.ComponentModel.ISupportInitialize)(this.grdCltDsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCltDspNomRecherche;
        protected System.Windows.Forms.TextBox txtCltDspNomRecherche;
        protected System.Windows.Forms.Button btnCltDspTous;
        protected System.Windows.Forms.DataGridView grdCltDsp;
        protected System.Windows.Forms.Button btnAjouter;
        protected System.Windows.Forms.Button btnCltDspSupprimer;
        protected System.Windows.Forms.Button btnCltDspQuitter;
    }
}