using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abi
{
    public partial class frmGrdContacts : Abi.frmGrdClt
    {
        int idClient, idContact;
        private FicheClient leClientActif;

        public frmGrdContacts()
        {
            this.idClient = Donnees.idClientActif;
            leClientActif = Donnees.ListeFicheClient[this.idClient];

            InitializeComponent();
            controlesVisuels();
            afficheContacts();
        }


        //BEGIN - GESTION DES BOUTONS/////////////////////////////////////::
        /// <summary>
        /// Affiche un Contact individuel vide pour ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnAjouter_Click(object sender, EventArgs e)
        {
            frmContact frmContact = new frmContact();

            if (frmContact.ShowDialog() == DialogResult.OK)
            {
                controlesVisuels();// réaffiche la liste des Contacts
                afficheContacts();
            }
        }


        /// <summary>
        /// bouton fermer: Ferme le Form de recherche de Client retourne à frmMDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnCltDspQuitter_Click(object sender, EventArgs e)
        {

            Donnees.ListeFicheClient.Clear();
            this.Close();
        }

        /// <summary>
        /// Boutton supprimer , supprime le Client selectionne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            if (this.grdCltDsp.CurrentRow != null)
            {
                this.idContact = (Int32)this.grdCltDsp.CurrentRow.Cells[0].Value;
            }

            Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.RemoveAt(this.idContact);
            this.controlesVisuels();
            this.afficheContacts();
        }

        /// <summary>
        /// Doubvle Clic sur le Grid : ouvre le Client Sellectionnne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void grdCltDsp_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdCltDsp.CurrentRow != null)
            {
                this.idContact = (Int32)this.grdCltDsp.CurrentRow.Cells[0].Value;
            }

            Donnees.idClientActif = this.idContact;
            frmContact frmContact = new frmContact(Donnees.ListeFicheClient[this.idClient].ListContacts[this.idContact]);
            if (frmContact.ShowDialog() == DialogResult.OK)
            {
                this.afficheContacts();
            }
        }

        //END - GESTION DES BOUTONS/////////////////////////////////////::










        /// <summary>
        /// Permets de rendre accessible les bons boutons version non optimisee mais plus secur
        /// </summary>
        protected override void controlesVisuels()
        {
            //Place tout les controles en Accessibles
            base.btnAjouter.Enabled = true;
            base.btnCltDspQuitter.Enabled = true;
            base.btnCltDspRechercher.Enabled = true;
            base.btnCltDspSupprimer.Enabled = true;
            base.btnCltDspTous.Enabled = true;
            base.txtCltDspNomRecherche.ReadOnly = false;


            //si il n'y a pas encore de Client, Rechercher, supprimer et tous ne sont pas visible
            if (Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts == null)
            {
                base.btnAjouter.Enabled = true;
                base.btnCltDspQuitter.Enabled = true;
                base.btnCltDspRechercher.Enabled = false;
                base.btnCltDspSupprimer.Enabled = false;
                base.btnCltDspTous.Enabled = false;
                base.txtCltDspNomRecherche.ReadOnly = true;
                base.grdCltDsp.Visible = false; // le Grid est remplacé par un message "pas de Contact"
                                                //  this.lblContactVide.Visible = true;
            }
            else
            {
                base.btnAjouter.Enabled = true;
                base.btnCltDspQuitter.Enabled = true;
                base.btnCltDspRechercher.Enabled = true;
                base.btnCltDspSupprimer.Enabled = true;
                base.btnCltDspTous.Enabled = true;
                base.txtCltDspNomRecherche.ReadOnly = false;
                base.grdCltDsp.Visible = true;
                //  this.lblContactVide.Visible = false;
            }
        }



        private void afficheContacts()
        {

            if (Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts != null) // l'affichage du Grid ne se fait que si il existe des contacts
            {
                DataTable dt = new DataTable();
                DataRow dr;

                dt.Columns.Add(new DataColumn("Societe", typeof(Int32)));
                dt.Columns.Add(new DataColumn("Nom", typeof(string)));
                dt.Columns.Add(new DataColumn("Prenom", typeof(string)));
                dt.Columns.Add(new DataColumn("Fonction", typeof(Decimal)));
                dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

                for (int i = 0; i < Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Entreprise;
                    dr[1] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Nom;
                    dr[2] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Prenom;
                    dr[3] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Fonction;
                    dr[4] = Donnees.ListeFicheClient[Donnees.idClientActif].ListContacts[i].Telephone;
                    dt.Rows.Add(dr);
                }

                base.grdCltDsp.DataSource = dt;
                base.grdCltDsp.Refresh();

                dt = null;
                dr = null;
            }

        }

    }
}
