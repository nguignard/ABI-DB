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
    /// <summary>
    /// frmGrdContact : affiche la liste des contacts d'un Client donné
    /// </summary>
    public partial class frmGrdContact : Form
    {
        private int idContact;// numero de contact
        private Client client;// le Client auquel sont rattaché les contacts
        private Contact contact;// le contact en cours de création ou de modification

        /// <summary>
        /// frmGrdContact: Contructeur d'un contact du client appele
        /// </summary>
        /// <param name="client"></param>
        public frmGrdContact(Client client)
        {
            this.client = client;

            InitializeComponent();
            controlesVisuels();
            afficheContacts();
        }




        //BEGIN - GESTION DES BOUTONS/////////////////////////////////////::
        /// <summary>
        /// btnAjouter_ClickAffiche un client individuel vide pour ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            contact = new Contact(++client.NbrContact); // instancie un nouveau contact avec un nouvel id

            frmContact frmNewContact = new frmContact(ref contact, true);// instancie la liste des contacts, avec un nouveau contact (true)
            DialogResult result = frmNewContact.ShowDialog();// ouverture modale de la fnêtre
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                if (result == DialogResult.Yes)
                {
                    client.ListContacts.Remove(contact);// on est obligé d'enlever le Client créer inutilement en cas d'annulation
                    client.NbrContact--;
                }
                if (result == DialogResult.OK) //on valide l'ajout du contact dans la collection
                {
                    client.ListContacts.Add(contact);
                }
                //affichage de la liste des Clients
                this.controlesVisuels();
                this.afficheContacts();
            }
        }

        /// <summary>
        /// btnCltDspQuitter_Click: Ferme le Form de recherche de Client retourne à la fiche du contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// btnCltDspSupprimer_Click: Boutton supprimer , supprime le Client selectionne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            //delmande de confirmation de suppression
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                if (grdContact.CurrentRow != null)// si la ligne selectionnees n'est pas vide (cas d'erreur)
                {
                    idContact = (Int32)grdContact.CurrentRow.Cells[0].Value;//recherche l'idContact a supprimer
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
                    client.ListContacts.Remove(contact);//suprime le contact de la liste de contact du client
                    client.NbrContact--;
                }
               // afficheContacts le Grid
                this.controlesVisuels();
                this.afficheContacts();
            }
        }

        /// <summary>
        /// Réaffiche la liste complete des Clients suite à l'entree de lettre dans le txtbox rechercher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspTous_Click(object sender, EventArgs e)
        {
            this.txtCltDspNomRecherche.Text = null;
            afficheContacts();
        }

        /// <summary>
        /// Quand on ecrit dans le txtbox Recherche, commence un tri actif par nom
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCltDspNomRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            //filtre le datagrid par un nom ressemblant a l'inscription dans  txtbox de recherche
            ((DataView)(this.grdContact.DataSource)).RowFilter = "[Nom] like '%" + this.txtCltDspNomRecherche.Text + "%'";
        }

        /// <summary>
        /// grdContact_DoubleClick: permet d'ouvrir en modal une fenêtre individulle d'un contact pour modif ou suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdContact_DoubleClick(object sender, EventArgs e)
        {
            if (grdContact.CurrentRow != null)
            {
                idContact = (Int32)grdContact.CurrentRow.Cells[0].Value;// recherche de l'Id du contact
                //Console.WriteLine("id : " + idContact);
            }
            foreach (Contact c in client.ListContacts)
            {
                if (c.IdContact == idContact)
                {
                    contact = c;//affecte le client trouver dans la liste au contact sur lequel on travail 
                }
            }

            //instancie une fiche individuelle contact en modal
            frmContact frmContact = new frmContact(ref contact, false);
            DialogResult result = frmContact.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                if (result == DialogResult.Yes)
                {
                    client.ListContacts.Remove(contact);//supprime de la liste de contact
                }
                //affichage de la liste contact
                this.controlesVisuels();
                this.afficheContacts();
            }
        }

       /// <summary>
       /// cherche un contact parmi la liste contact
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void txtCltDspNomRecherche_KeyUp_1(object sender, KeyEventArgs e)
        {
            ((DataView)grdContact.DataSource).RowFilter = "Nom like '%" + txtCltDspNomRecherche.Text + "%'";
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

        
    }
}
