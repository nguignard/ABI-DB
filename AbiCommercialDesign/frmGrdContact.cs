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
        private int idContact;
        private Client client;
        private Contact contact;

        public frmGrdContact(Client client)
        {
            this.client = client;

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
            contact = new Abi.Contact(client.NbrContact++);
            frmContact frmNewContact = new frmContact(ref contact, true);
            DialogResult result = frmNewContact.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                if (result == DialogResult.Yes)
                {
                    client.ListContacts.Remove(contact);
                }

                if (result == DialogResult.OK)
                {
                    client.ListContacts.Add(contact);
                }

                this.controlesVisuels();
                this.afficheContacts();

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
                foreach (Contact c in client.ListContacts)
                {
                    if (c.IdContact == idContact)
                    {
                        contact = c;
                    }
                }
                if (contact != null)
                {
                    client.ListContacts.Remove(contact);
                }
                this.controlesVisuels();
                this.afficheContacts();
            }
        }

        /// <summary>
        /// Doubvle Clic sur le Grid : ouvre le Client Sellectionnne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
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
            if (client.ListContacts.Count == 0)
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

            for (int i = 0; i < client.ListContacts.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = client.ListContacts[i].IdContact;
                dr[1] = client.ListContacts[i].Nom;
                dr[2] = client.ListContacts[i].Prenom;
                dr[3] = client.ListContacts[i].Entreprise;
                dr[4] = client.ListContacts[i].Telephone;
                dt.Rows.Add(dr);
            }

            this.grdContact.DataSource = dt.DefaultView;
            this.grdContact.Refresh();

            dt = null;
            dr = null;

        }

        private void grdContact_DoubleClick(object sender, EventArgs e)
        {
            if (grdContact.CurrentRow != null)
            {
                idContact = (Int32)grdContact.CurrentRow.Cells[0].Value;
                Console.WriteLine("id : " + idContact);
            }
            foreach (Contact c in client.ListContacts)
            {
                if (c.IdContact == idContact)
                {
                    contact = c;
                }
            }


            frmContact frmContact = new frmContact(ref contact, false);
            DialogResult result = frmContact.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                if (result == DialogResult.Yes)
                {
                    client.ListContacts.Remove(contact);
                }
                this.controlesVisuels();
                this.afficheContacts();
                
            }
            
        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            ((DataView)grdContact.DataSource).RowFilter = "Nom like '%" + txtCltDspNomRecherche.Text + "%'";
        }

        private void txtCltDspNomRecherche_KeyUp_1(object sender, KeyEventArgs e)
        {
            ((DataView)grdContact.DataSource).RowFilter = "Nom like '%" + txtCltDspNomRecherche.Text + "%'";
        }
    }
}
