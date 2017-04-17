namespace Abi
{
    partial class frmControle
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
            this.grdDB = new System.Windows.Forms.DataGridView();
            this.grdVS = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVS)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDB
            // 
            this.grdDB.AllowUserToAddRows = false;
            this.grdDB.AllowUserToDeleteRows = false;
            this.grdDB.AllowUserToOrderColumns = true;
            this.grdDB.AllowUserToResizeColumns = false;
            this.grdDB.AllowUserToResizeRows = false;
            this.grdDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDB.Location = new System.Drawing.Point(31, 85);
            this.grdDB.Margin = new System.Windows.Forms.Padding(4);
            this.grdDB.MultiSelect = false;
            this.grdDB.Name = "grdDB";
            this.grdDB.ReadOnly = true;
            this.grdDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDB.Size = new System.Drawing.Size(826, 181);
            this.grdDB.TabIndex = 5;
            // 
            // grdVS
            // 
            this.grdVS.AllowUserToAddRows = false;
            this.grdVS.AllowUserToDeleteRows = false;
            this.grdVS.AllowUserToOrderColumns = true;
            this.grdVS.AllowUserToResizeColumns = false;
            this.grdVS.AllowUserToResizeRows = false;
            this.grdVS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVS.Location = new System.Drawing.Point(31, 299);
            this.grdVS.Margin = new System.Windows.Forms.Padding(4);
            this.grdVS.MultiSelect = false;
            this.grdVS.Name = "grdVS";
            this.grdVS.ReadOnly = true;
            this.grdVS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVS.Size = new System.Drawing.Size(826, 181);
            this.grdVS.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(716, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmControle
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 541);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdVS);
            this.Controls.Add(this.grdDB);
            this.Name = "frmControle";
            this.Text = "Controle";
            ((System.ComponentModel.ISupportInitialize)(this.grdDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView grdDB;
        protected System.Windows.Forms.DataGridView grdVS;
        private System.Windows.Forms.Button btnClose;
    }
}