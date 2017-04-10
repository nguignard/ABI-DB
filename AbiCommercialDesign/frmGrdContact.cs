using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abi
{
    public partial class frmGrdContact : Form
    {
        int idContact;
        Client leClient;
        Contact leContact;

        public frmGrdContact(Client fc)
        {
            leClient = fc;

            InitializeComponent();
            controlesVisuels();
            afficheContacts();
        }




        //BEGIN - GESTION DES BOUTONS/////////////////////////////////////::
        /// <summary>
        /// Affiche un client individuel vide pour ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmContact frmNewContact = new frmContact(leClient);

            if (frmNewContact.ShowDialog() == DialogResult.OK)
            {
                controlesVisuels();// réaffiche la liste des Clients
                afficheContacts();
            }
        }

        /// <summary>
        /// bouton fermer: Ferme le Form de recherche de Client retourne à frmMDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Boutton supprimer , supprime le Client selectionne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                if (grdContact.CurrentRow != null)
                {
                    idContact = (Int32)grdContact.CurrentRow.Cells[0].Value;
                }
                foreach (Contact c in leClient.ListContacts)
                {
                    if (c.IdContact == idContact)
                    {
                        leContact = c;
                    }
                }
                leClient.ListContacts.Remove(leContact);
                this.controlesVisuels();
                this.afficheContacts();
            }
        }

        /// <summary>
        /// Doubvle Clic sur le Grid : ouvre le Client Sellectionnne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void grdContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdContact.CurrentRow != null)
            {
                idContact = (Int32)grdContact.CurrentRow.Cells[0].Value;
            }
            foreach (Contact c in leClient.ListContacts)
            {
                if (c.IdContact == idContact)
                {
                    leContact = c;
                }
            }


            frmContact frmContact = new frmContact(this.leClient, this.leContact);
            if (frmContact.ShowDialog() == DialogResult.OK)
            {
                this.controlesVisuels();
                this.afficheContacts();
            }

        

    }
        /// <summary>
        /// Réaffiche la liste complete des Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspTous_Click(object sender, EventArgs e)
        {
            this.txtCltDspNomRecherche.Text = null;
            afficheContacts();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCltDsp_SelectionChanged(object sender, EventArgs e)
        {
            if (grdContact.CurrentRow != null)
            {
                idContact = (Int32)grdContact.CurrentRow.Cells[0].Value;
            }
        }
        /// <summary>
        /// Quand on ecrit dans le txtbox Recherche, commence un tri actif
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCltDspNomRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            ((DataView)(this.grdContact.DataSource)).RowFilter = "[Nom] like '%" + this.txtCltDspNomRecherche.Text + "%'";
        }






        //END - GESTION DES BOUTONS/////////////////////////////////////::










        // BEGIN - FONCTIONS D'AFFICHAGE////////////////////////////////////////////////////////////:

        /// <summary>
        /// Permets de rendre accessible les bons boutons version non optimisee mais plus secur
        /// </summary>
        private void controlesVisuels()
        {
            //Place tout les controles Accessibles
            this.btnAjouter.Enabled = true;
            this.btnCltDspQuitter.Enabled = true;
            this.btnCltDspSupprimer.Enabled = true;
            this.btnCltDspTous.Enabled = true;
            this.txtCltDspNomRecherche.ReadOnly = false;

            //si il n'y a pas encore de Client, Rechercher, supprimer et tous ne sont pas visible
            if (leClient.ListContacts.Count == 0)
            {
                this.btnAjouter.Enabled = true;
                this.btnCltDspQuitter.Enabled = true;
                this.btnCltDspSupprimer.Enabled = false;
                this.btnCltDspTous.Enabled = false;
                this.txtCltDspNomRecherche.ReadOnly = true;
            }
            else
            {
                this.btnAjouter.Enabled = true;
                this.btnCltDspQuitter.Enabled = true;
                this.btnCltDspSupprimer.Enabled = true;
                this.btnCltDspTous.Enabled = true;
                this.txtCltDspNomRecherche.ReadOnly = false;
            }
        }

        /// <summary>
        /// Prépare l'affichage et Affiche les Clients dans le dataGrid 
        /// </summary>
        private void afficheContacts()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("idContact", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(string)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(string)));
            dt.Columns.Add(new DataColumn("Entreprise", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(String)));

            for (int i = 0; i < leClient.ListContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = leClient.ListContacts[i].IdClient;
                dr[1] = leClient.ListContacts[i].Nom;
                dr[2] = leClient.ListContacts[i].Prenom;
                dr[3] = leClient.ListContacts[i].Entreprise;
                dr[4] = leClient.ListContacts[i].Telephone;
                dt.Rows.Add(dr);
            }

            this.grdContact.DataSource = dt.DefaultView;
            this.grdContact.Refresh();

            dt = null;
            dr = null;

        }

    }
}
