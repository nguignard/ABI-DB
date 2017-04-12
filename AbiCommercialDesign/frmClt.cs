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
    /// frmClt: est une fenetre qui gere la creation et la modification d'un Client Particulier
    /// </summary>
    public partial class frmClt : Form
    {
        private Client client; // attribut de classe
        private Boolean isNewClient;// vrai si le client est nouveau, permet d'ajouter un nouveau client a la liste dans donnees,
                                    //ou de remplacer le Client actuel à modifier
                                    //private Client clientVide = new Client(0, 0, 0, "", "", "", "", "00000", "", "", "", "");



        //BEGIN - CONSTRUCTEURS DE CLASSE

        /// <summary>
        /// Constructeur pour un nouveau Client
        /// </summary>
        public frmClt()
        {



            InitializeComponent();
            this.isNewClient = true;
            controlesVisuels(); //met en place les contrôles visuels
        }

        /// <summary>
        /// Constructeur pour un Client Existant
        /// </summary>
        /// <param name="unClient">unClient est de classe ficheClient est est envoye comme paramettre par double clic de la fenetre frmGrdClt </param>
        public frmClt(Client client, Boolean isNewClient)
        {
            

            InitializeComponent();
            this.isNewClient = isNewClient;
            this.client = client;
            controlesVisuels();
            afficheLeClient(client);//fonction permettant d'afficher le Client
        }
        //END - CONSTRUCTEUR DE CLASSE


        //BEGIN - EVENEMENT LIES AUX BOUTONS

        /// <summary>
        /// bouton fermer: ferme la boite de dialogue et retourne a la recherche de Client (modal)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Supprime le contacte de la liste des Clients si ce n'est pas un nouveau Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep = new DialogResult();
            rep = MessageBox.Show("Voulez vous vraiment supprimer?", "suppression", MessageBoxButtons.OKCancel);
            if (rep == DialogResult.OK)
            {
                if (!isNewClient)
                    Donnees.ListeFicheClient.Remove(this.client);
            }
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Bouton annuler: remet a vide les cases ou  annule les modifications faites sur le Client actuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            
                //this.afficheLeClient(client);

            //this.DialogResult = DialogResult.Cancel;
        }


        /// <summary>
        /// au Clic Bouton Valider:
        /// - si c'est un nouveau Client, ajoute à la liste des Clients
        /// - sinon, modifie le Client existant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            this.saveClient();
            this.DialogResult = DialogResult.OK; //ferme la fenetre modale
        }


        private void btnContacts_Click(object sender, EventArgs e)
        {
            this.saveClient();

            frmGrdContact frmModifContact = new frmGrdContact(this.client);
            if (frmModifContact.ShowDialog() == DialogResult.OK)
            {
                this.afficheLeClient(this.client);
            }
        }





        //END - GESTION DES BOUTONS


        //FONCTION D'affichage DIVERS////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// grpStringValue renvoie le string lie au radiboutonS Actif dans la groupbox choisie
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private string grpStringValue(GroupBox g)
        {
            string s;

            if (g == this.grpNature) //si on est dans le groupbox nature, on regarde quel rdb est checked et s renvoi le string
            {
                s = "Principal";
                if (this.rdbSecondaire.Checked)
                    s = "Secondaire";
                if (this.rdbAncienne.Checked)
                    s = "Ancienne";
            }
            else
            {
                s = "Public";
                if (this.rdbTypeClientPrive.Checked)
                    s = "Privé";
            }
            return s;
        }

        /// <summary>
        /// controleVisuel met tout les controles actifs, puis gere en fonction des cas quel boutons il faut afficher
        /// </summary>
        private void controlesVisuels()
        {
            this.txtRaisonSociale.Select();

            //Place tout les controles ON
            this.btnAnnuler.Enabled = true;
            this.btnContacts.Enabled = true;//??tant que pas de controle
            this.btnFermer.Enabled = true;
            this.btnSupprimer.Enabled = true;
            this.btnValider.Enabled = true;//??? Faire un controle pour voir si un txtbox est rempli


            //Verifie dans quel cas les disable
            this.btnContacts.Enabled = true;//??tant que pas de controle
                                            //if(Donnees.ListeFicheClient)

            // Begin - Initialisation de la comboBox Nature de la Société
            this.cbxActivite.Items.Clear();
            this.cbxActivite.Items.AddRange(new string[] { "Agro", "Industrie", "..." });
            //End - Initialisation de la comboBox Nature de la Société
        }

        /// <summary>
        /// Affiche le Client en cours de modification
        /// </summary>
        private void afficheLeClient(Client c)

        {
            if (c != null)
            {
                this.txtIdClient.Text = c.IdClient.ToString();
                this.txtRaisonSociale.Text = c.RaisonSociale.ToString();

                this.txtAdresse.Text = c.Adresse.ToString();
                this.txtCP.Text = c.CP.ToString();
                this.txtVille.Text = c.Ville.ToString();

                //Gestion des radioboutons
                this.rdbAncienne.Checked = true;
                if (c.TypeSociete == "Principal")
                {
                    this.rdbPrincipal.Checked = true;
                }
                else
                {
                    if (c.TypeSociete == "Secondaire")
                    {
                        this.rdbSecondaire.Checked = true;
                    }
                }
                this.rdbTypeClientPublic.Checked = true;
                if (c.Nature == "Privé") this.rdbTypeClientPrive.Checked = true;

                this.cbxActivite.SelectedItem = c.Activite.ToString();
                this.txtTelephone.Text = c.Telephone.ToString();
                this.txtCA.Text = c.CA.ToString();
                this.txtEffectif.Text = c.Effectif.ToString();
                this.txtCommentComm.Text = c.CommentComm.ToString();
            }
        }

        private void saveClient()
        {
            // tente de rentrer ou modifier un nouveau Client, sinon renvoie une exception (venant des accesseurs)
            try
            {
                

                //Création ou modification du Client
                if (isNewClient)
                {
                    client = new Client(Donnees.nbrClient++);
                    getClient();

                    Donnees.ListeFicheClient.Add(client); //Ajoute le nouveau Client à la liste statique dans données
                }
                else
                {
                    getClient();
                    for(Int32 i= 0; i<Donnees.ListeFicheClient.Count; i++)
                    {
                        if(Donnees.ListeFicheClient[i].IdClient == client.IdClient)
                        {
                            Donnees.ListeFicheClient[i] = client;
                        }
                    }

         
                }

            }
            catch (Exception ex)
            {
                if (isNewClient)
                    client = null;// annule la création si l'essai n'est pas concluant
                MessageBox.Show(ex.Message); // renvoie le message d'exception
            }
        }
        
        private void getClient()
        {
            this.client.RaisonSociale = this.txtRaisonSociale.Text.Trim(); //trim enleve les espaces avant et apres la chaine
            this.client.Activite = this.cbxActivite.SelectedItem.ToString().Trim();
            this.client.Adresse = this.txtAdresse.Text.Trim();
            this.client.Ville = this.txtVille.Text.Trim().ToUpper();//ToUpper met en majuscule
            this.client.CP = this.txtCP.Text.Trim();
            this.client.Telephone = this.txtTelephone.Text.Trim();
            this.client.CA = decimal.Parse(this.txtCA.Text.Trim());
            this.client.Effectif = Int32.Parse(this.txtEffectif.Text.Trim());
            this.client.CommentComm = this.txtCommentComm.Text.Trim();
            this.client.Nature = grpStringValue(grpNature);//grpStringValue renvoie le string lie au rdb Actif du grpBox
            this.client.TypeSociete = grpStringValue(grpTypeSociete);
        }

    }
}