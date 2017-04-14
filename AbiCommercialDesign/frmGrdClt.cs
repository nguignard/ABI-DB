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
    public partial class frmGrdClt : Form
    {
        private frmClt frmFicheClient; //attribut de Class
        private Int32 idClient;
        private Client client;

        /// <summary>
        /// Constructeur de la fenetre liste Client et ajout de 5 Clients pour test
        /// </summary>
        public frmGrdClt()
        {
            //BEGIN  - JEU DE TEST: Création de 5 Clients virtuels comme jeux de test a l'ouverture du Form
            //List<Contact> lc;
            for (int i = 0; i < 5; i++)
            {
                //lc = new List<Contact>();
                Donnees.ListeFicheClient.Add(new Client(Donnees.nbrClient++, 20 * i, 30 * i, "SARL" + i.ToString(), "Public", "Ancienne", "Adrese" + i.ToString(), "0680" + i.ToString(), "ville" + i.ToString(), "Agro", "0606060" + i.ToString(), i.ToString()));
            }
            //END - JEU DE TEST

            //INITIALISATION DES COMPOSANTS ET AFFICHAGES DES CLIENTS
            InitializeComponent();
            controlesVisuels();
            afficheClients();
        }


        //BEGIN - GESTION DES BOUTONS/////////////////////////////////////::
        /// <summary>
        /// btnAjouter_Click : Affiche un client individuel vide pour ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmFicheClient = new frmClt();

            if (frmFicheClient.ShowDialog() == DialogResult.OK)
            {
                controlesVisuels();// réaffiche la liste des Clients
                afficheClients();
            }
        }

        /// <summary>
        /// btnCltDspQuitter_Click: Ferme le Form de recherche de Client retourne à frmMDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspQuitter_Click(object sender, EventArgs e)
        {
            Donnees.ListeFicheClient.Clear();
            this.Close();
        }

        /// <summary>
        /// Boutton supprimer , supprime le Client selectionne, apres confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCltDspSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {

                //Recherche du Client à supprimer
                if (grdCltDsp.CurrentRow != null)
                {
                    idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
                }
                foreach (Client c in Donnees.ListeFicheClient)
                {
                    if (c.IdClient == idClient)
                    {
                        client = c;
                    }
                }
                Donnees.ListeFicheClient.Remove(client);
                this.controlesVisuels();
                this.afficheClients();
            }
        }

        /// <summary>
        /// grdCltDsp_DoubleClick: Doubvle Clic sur le Grid : ouvre le Client Selectionnne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCltDsp_DoubleClick(object sender, EventArgs e)
        {
            //Recherche du Client à Modifier
            if (grdCltDsp.CurrentRow != null)
            {
                idClient = (Int32)grdCltDsp.CurrentRow.Cells[0].Value;
            }
            foreach (Client c in Donnees.ListeFicheClient)
            {
                if (c.IdClient == idClient)
                {
                    client = c;
                }
            }


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
            afficheClients();
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
        //END - GESTION DES BOUTONS/////////////////////////////////////::




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

            dt.Columns.Add(new DataColumn("Numéro Client", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(string)));
            dt.Columns.Add(new DataColumn("CA", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("Nature", typeof(String)));

            for (int i = 0; i < Donnees.ListeFicheClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeFicheClient[i].IdClient;
                dr[1] = Donnees.ListeFicheClient[i].RaisonSociale;
                dr[2] = Donnees.ListeFicheClient[i].Telephone;
                dr[3] = Donnees.ListeFicheClient[i].CA;
                dr[4] = Donnees.ListeFicheClient[i].Nature;
                dt.Rows.Add(dr);
            }

            this.grdCltDsp.DataSource = dt.DefaultView;
            this.grdCltDsp.Refresh();

            dt = null;
            dr = null;
        }

    }
}
