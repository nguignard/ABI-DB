namespace Abi
{
    partial class frmDspDocIntervenant
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
            this.components = new System.ComponentModel.Container();
            this.lblNomIntervenant = new System.Windows.Forms.Label();
            this.lblProjet = new System.Windows.Forms.Label();
            this.txtNomIntervenant = new System.Windows.Forms.TextBox();
            this.txtProjet = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomIntervenant
            // 
            this.lblNomIntervenant.AutoSize = true;
            this.lblNomIntervenant.Location = new System.Drawing.Point(12, 13);
            this.lblNomIntervenant.Name = "lblNomIntervenant";
            this.lblNomIntervenant.Size = new System.Drawing.Size(104, 13);
            this.lblNomIntervenant.TabIndex = 0;
            this.lblNomIntervenant.Text = "Nom de l\'intervenant";
            // 
            // lblProjet
            // 
            this.lblProjet.AutoSize = true;
            this.lblProjet.Location = new System.Drawing.Point(13, 39);
            this.lblProjet.Name = "lblProjet";
            this.lblProjet.Size = new System.Drawing.Size(34, 13);
            this.lblProjet.TabIndex = 1;
            this.lblProjet.Text = "Projet";
            // 
            // txtNomIntervenant
            // 
            this.txtNomIntervenant.Location = new System.Drawing.Point(123, 10);
            this.txtNomIntervenant.Name = "txtNomIntervenant";
            this.txtNomIntervenant.ReadOnly = true;
            this.txtNomIntervenant.Size = new System.Drawing.Size(174, 20);
            this.txtNomIntervenant.TabIndex = 2;
            // 
            // txtProjet
            // 
            this.txtProjet.Location = new System.Drawing.Point(123, 36);
            this.txtProjet.Name = "txtProjet";
            this.txtProjet.ReadOnly = true;
            this.txtProjet.Size = new System.Drawing.Size(174, 20);
            this.txtProjet.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(123, 62);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(174, 20);
            this.txtDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(525, 388);
            this.reportViewer1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(462, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Quiiter";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(374, 10);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(163, 20);
            this.txtClient.TabIndex = 9;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(338, 13);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 8;
            this.lblClient.Text = "Client";
            // 
            // frmDspDocIntervenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 524);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtProjet);
            this.Controls.Add(this.txtNomIntervenant);
            this.Controls.Add(this.lblProjet);
            this.Controls.Add(this.lblNomIntervenant);
            this.Name = "frmDspDocIntervenant";
            this.Text = "Detail du Document Intervenant";
            this.Load += new System.EventHandler(this.frmDspDocIntervenant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomIntervenant;
        private System.Windows.Forms.Label lblProjet;
        private System.Windows.Forms.TextBox txtNomIntervenant;
        private System.Windows.Forms.TextBox txtProjet;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ImageList imageList1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblClient;
    }
}