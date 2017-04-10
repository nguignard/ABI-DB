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
    public partial class frmContact : Form
    {
        private Client leClientActif;
        private Contact leContact; // attribut de classe
        private bool IsNewContact;// vrai si le client est nouveau, permet d'ajouter un nouveau client a la liste dans donnees,
                                  //ou de remplacer le Client actuel à modifier

        Contact contactVide;

        public frmContact(Client fc)
        {
            leClientActif = fc;
            IsNewContact = true;
            contactVide = new Contact(0, leClientActif.IdClient, "", "", "", "", "", "", "");

            InitializeComponent();
            controlesVisuels();
            afficheContact(contactVide);
        }


        public frmContact(Client fc, Contact c)
        {
            leClientActif = fc;
            IsNewContact = false;
            leContact = c;
            contactVide = new Contact(0, leClientActif.IdClient, "", "", "", "", "", "", "");

            InitializeComponent();
            controlesVisuels();
            afficheContact(leContact);//fonction permettant d'afficher le Contact
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
            if (!IsNewContact)
                leClientActif.ListContacts.Remove(this.leContact);

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Bouton annuler: remet a vide les cases ou  annule les modifications faites sur le Client actuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (IsNewContact)
                this.afficheContact(contactVide);
           else
                this.afficheContact(leContact);
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
            // instanciation de leClient en cas de nouveau Client
            if (IsNewContact)
            {
                leContact = new Contact();

            }
            // tente de rentrer ou modifier un nouveau Client, sinon renvoie une exception (venant des accesseurs)
            try
            {
                this.leContact.Entreprise = this.txtEntreprise.Text.Trim().ToUpper(); //trim enleve les espaces avant et apres la chaine
                this.leContact.Nom = this.txtNom.Text.Trim();
                this.leContact.Prenom = this.txtPrenom.Text.Trim();
                this.leContact.Fonction = this.txtFonction.Text.Trim();//ToUpper met en majuscule
                this.leContact.Telephone = this.txtTelephone.Text.Trim();
                this.leContact.Projet = this.txtProjet.Text;

                this.leContact.Activite = this.txtActivite.Text;
                this.leContact.IdClient = this.leClientActif.IdClient;


                //Création ou modification du Client
                if (IsNewContact)
                {
                    this.leContact.IdClient = this.leClientActif.ListContacts.Count;
                    this.leClientActif.ListContacts.Add(this.leContact); //Ajoute le nouveau Contact à la liste statique dans données
                }
                else
                {
                    leClientActif.ListContacts.Remove(this.leContact);//remplace le Client par le Client modifié
                    leClientActif.ListContacts.Insert(this.leContact.IdContact, this.leContact);
                }
                this.DialogResult = DialogResult.OK; //ferme la fenetre modale

            }
            catch (Exception ex)
            {
                if (IsNewContact)
                    leContact = null;// annule la création si l'essai n'est pas concluant
                MessageBox.Show(ex.Message); // renvoie le message d'exception
            }
        }

        //END - GESTION DES BOUTONS


        //FONCTION D'affichage DIVERS////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// controleVisuel met tout les controles actifs, puis gere en fonction des cas quel boutons il faut afficher
        /// </summary>
        private void controlesVisuels()
        {
            this.txtEntreprise.Select();

            //Place tout les controles ON
            this.btnDocuments.Enabled = false;
            this.btnAnnuler.Enabled = true;
            this.btnValider.Enabled = true;//??? Faire un controle pour voir si un txtbox est rempli
            this.btnSupprimer.Enabled = true;
            this.btnFermer.Enabled = true;

            //Verifie dans quel cas les disable
            this.btnDocuments.Enabled = false;//??tant que pas de controle
                                              //if(Donnees.ListeFicheClient)
            this.txtActivite.Enabled = true;
        }

        /// <summary>
        /// Affiche le Client en cours de modification
        /// </summary>
        private void afficheContact(Contact c)
        {
            this.txtEntreprise.Text = c.Entreprise.ToString();
            this.txtNom.Text = c.Nom.ToString();
            this.txtPrenom.Text = c.Prenom.ToString();
            this.txtFonction.Text = c.Fonction.ToString();
            this.txtTelephone.Text = c.Telephone.ToString();
            this.txtProjet.Text = c.Projet.ToString();

            this.txtActivite.Text = c.Activite.ToString();
            this.txtContact.Text = c.IdContact.ToString();
            this.txtidClient.Text = c.IdClient.ToString();

        }
    }
}
