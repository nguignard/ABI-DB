using System;
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
    /// frmContact: Display an unique Contact for CRUDE
    /// </summary>
    public partial class frmContact : Form
    {
        private Contact contact; // attribut de classe
        private Boolean isNewContact; // true if it is a new contact

        // BEGIN - CONSTRUCTEURS
        /// <summary>
        /// frmContact: is a constructor based on a new Client, or an existing Client
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="isNewContact"></param>
        public frmContact(ref Contact contact, Boolean isNewContact)
        {
            InitializeComponent();

            controlesVisuels(); // enable buttons
            this.contact = contact;

            this.isNewContact = isNewContact;
            if (!isNewContact)
            {
                afficheContact();// Display a contact
            }
        }
        // END - CONSTRUCTEURS


        //BEGIN - EVENEMENT LIES AUX BOUTONS

        /// <summary>
        /// btnFermer_Click: ferme la boite de dialogue et retourne a la recherche de Client (modal)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// btnSupprimer_Click: after confirmation, Supprime le contacte de la liste des Clients si ce n'est pas un nouveau Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous supprimer ce contact ?", "Suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Yes;// si yes, retourne a frmGridContact, qui lui remove de la collection de contact
            }
        }

        /// <summary>
        /// btnAnnuler_Click: remet a vide les cases ou annule les modifications faites sur le Client actuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (!isNewContact) this.afficheContact();
            else
            {
                this.txtEntreprise.Text = String.Empty;
                this.txtNom.Text = String.Empty;
                this.txtPrenom.Text = String.Empty;
                this.txtFonction.Text = String.Empty;
                this.txtTelephone.Text = String.Empty;
                this.txtProjet.Text = String.Empty;
                this.txtActivite.Text = String.Empty;
                this.txtIdContact.Text = String.Empty;
                this.txtIdClient.Text = String.Empty;
            }
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
            if (this.txtEntreprise.Text.Trim() != String.Empty)//Lecontact a au minimum besoin d'une entreprise
            {
                // tente de rentrer ou modifier un nouveau Client, sinon renvoie une exception (venant des accesseurs)
                try
                {
                    this.contact.Entreprise = this.txtEntreprise.Text.Trim().ToUpper(); //trim enleve les espaces avant et apres la chaine
                    this.contact.Nom = this.txtNom.Text.Trim();
                    this.contact.Prenom = this.txtPrenom.Text.Trim();
                    this.contact.Fonction = this.txtFonction.Text.Trim();//ToUpper met en majuscule
                    this.contact.Telephone = this.txtTelephone.Text.Trim();
                    this.contact.Projet = this.txtProjet.Text;
                    this.contact.Activite = this.txtActivite.Text;

                    this.DialogResult = DialogResult.OK; //ferme la fenetre modale
                }
                catch (Exception ex)
                {
                    if (isNewContact)
                        contact = null;// annule la création si l'essai n'est pas concluant
                    MessageBox.Show(ex.Message); // renvoie le message d'exception
                }
            }
            else MessageBox.Show("Oye une Entreprise peut etre !!!!", "Erreur Nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //END - GESTION DES EVENEMENTS LIES AUX BOUTONS


        //BEGIN - FONCTION D'affichage DIVERS////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// controlesVisuels met tout les controles actifs, puis gere en fonction des cas quel boutons il faut afficher
        /// </summary>
        private void controlesVisuels()
        {
            this.txtEntreprise.Select();// place le curseur sur le txt Entreprise

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
        /// afficheContact: Affiche le Client en cours de modification
        /// </summary>
        private void afficheContact()
        {
            if (contact != null)
            {
                this.txtEntreprise.Text = contact.Entreprise.ToString();
                this.txtNom.Text = contact.Nom.ToString();
                this.txtPrenom.Text = contact.Prenom.ToString();
                this.txtFonction.Text = contact.Fonction.ToString();
                this.txtTelephone.Text = contact.Telephone.ToString();
                this.txtProjet.Text = contact.Projet.ToString();
                this.txtActivite.Text = contact.Activite.ToString();
                this.txtIdContact.Text = contact.IdContact.ToString();

                this.txtIdClient.Text = contact.IdClient.ToString();
            }
        }
    }
}
