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
    /// la Form frmGrdClt Affiche la liste des Clients
    /// </summary>
    public partial class frmGrdClt : Form
    {
        // ATTRIBUTS
        private frmClt frmFicheClient; //attribut de Class
        private Int32 idClient;// numero de Client
        private Client client;// une instance de Client niveau class


        //BEGIN - CONSTRUCTEURS
        /// <summary>
        /// Constructeur de la fenetre liste Client et ajout de 5 Clients pour test
        /// </summary>
        public frmGrdClt()
        {
            //BEGIN  - JEU DE TEST: Création de 5 Clients virtuels comme jeux de test a l'ouverture du Form
            for (int i = 0; i < 5; i++)
            {
                Donnees.ListeFicheClient.Add(new Client(Donnees.nbrClient++, 20 * i, 30 * i, "SARL" + i.ToString(), "Public", "Ancienne", "Adrese" + i.ToString(), "0680" + i.ToString(), "ville" + i.ToString(), "Agro", "0606060" + i.ToString(), i.ToString()));
            }
            //END - JEU DE TEST



            //INITIALISATION DES COMPOSANTS ET AFFICHAGES DES CLIENTS
            InitializeComponent();

            controlesVisuels();
            afficheClients();
        }

        //END - CONSTRUCTEURS





        //BEGIN - GESTION DES EVENEMENTS/////////////////////////////////////::
        /// <summary>
        /// btnAjouter_Click : Affiche un client individuel vide pour ajout d'un Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmFicheClient = new frmClt(); //ouverture modale d'un nouveau Client

            if (frmFicheClient.ShowDialog() == DialogResult.OK)
            {
                controlesVisuels();// enable/disable les boutons
                afficheClients();// réaffiche la liste des Clients
            }
        }

        /// <summary>
        /// btnCltDspQuitter_Click: Ferme le Form de recherche de Client retourne à frmMDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// btnCltDspSupprimer_Click , supprime le Client selectionne, apres confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            //Ouverture d'une MessageBox de confirmation de suppression
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                //Recherche du Client à supprimer
                if (grdCltDsp.CurrentRow != null)
                {
                    idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;// on cherche l'id Client situe dans la 1ere Collone du dataGrid
                }
                foreach (Client c in Donnees.ListeFicheClient) // on recherche le Client correspondant dans la collection des cliens
                {
                    if (c.IdClient == idClient)
                    {
                        client = c;
                    }
                }
                Donnees.ListeFicheClient.Remove(client);//suppresssion de la liste des Clients

                this.controlesVisuels();// reaffiche
                this.afficheClients();
            }
        }

        /// <summary>
        /// grdCltDsp_DoubleClick: pour modifier un client, on Double Clic sur le Grid : ouvre le Client Selectionnne dans une fiche individuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCltDsp_DoubleClick(object sender, EventArgs e)
        {
            if (grdCltDsp.CurrentRow != null) //Recherche du Client à Modifier
            {
                idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
            }
            foreach (Client c in Donnees.ListeFicheClient.ToList())
            {
                if (c.IdClient == idClient)
                {
                    client = c;
                }
            }

            //affichage du client trouve dans une form presentant un client individuel
            frmClt frmClient = new frmClt(client, false);
            if (frmClient.ShowDialog() == DialogResult.OK)
            {
                this.controlesVisuels();
                this.afficheClients();

            }
        }

        /// <summary>
        /// btnCltDspTous_Click: Réaffiche la liste complete des Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspTous_Click(object sender, EventArgs e)
        {
            this.txtCltDspNomRecherche.Text = null;
            afficheClients(); // recreer er reaffiche le grid liste des Clients
        }

        /// <summary>
        /// grdCltDsp_SelectionChanged : enregistre l'idClient à chaque changement de selection, est utilisé pour s'assurer la bonne selection d'unClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCltDsp_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCltDsp.CurrentRow != null)
            {
                idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value; //get the value of the id number of the Client that is on the 0 cell of the line
            }
        }

        /// <summary>
        /// txtCltDspNomRecherche_KeyUp: Quand on ecrit dans le txtbox Recherche, commence un tri actif sur la raison sociale
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCltDspNomRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            ((DataView)(this.grdCltDsp.DataSource)).RowFilter = "[Raison Sociale] like '%" + this.txtCltDspNomRecherche.Text + "%'";
        }


        //END - GESTION DES EVENEMENTS/////////////////////////////////////::




        // BEGIN - FONCTIONS D'AFFICHAGE////////////////////////////////////////////////////////////:

        /// <summary>
        /// Methode controlesVisuels Permets de rendre accessible les bons boutons version non optimisee mais plus secur
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
            if (Donnees.ListeFicheClient.Count == 0)
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
        /// Methode afficheClients:  Prépare l'affichage et Affiche les Clients dans le dataGrid 
        /// </summary>
        private void afficheClients()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            //Nomage des colonnes
            dt.Columns.Add(new DataColumn("Numéro Client", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(string)));
            dt.Columns.Add(new DataColumn("CA", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("Nature", typeof(String)));

            for (int i = 0; i < Donnees.ListeFicheClient.Count; i++)//remplissage d'une Datarow
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeFicheClient[i].IdClient;
                dr[1] = Donnees.ListeFicheClient[i].RaisonSociale;
                dr[2] = Donnees.ListeFicheClient[i].Telephone;
                dr[3] = Donnees.ListeFicheClient[i].CA;
                dr[4] = Donnees.ListeFicheClient[i].Nature;
                dt.Rows.Add(dr); //ajout a la collection des lignes
            }

            this.grdCltDsp.DataSource = dt.DefaultView;//DefaultView permet d'utiliser le trie
            this.grdCltDsp.Refresh();

            dt = null;
            dr = null;
        }

    }
}
