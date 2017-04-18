using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    public class Contact
    {
        private string entreprise;
        private string nom;
        private string prenom;
        private string fonction;
        private string telephone;
        private string projet;
        private string activite;

        private int idClient; //idClient is the id of the reference Client
        private int idContact; // specific id of the contact into the Client list

        /// <summary>
        /// Constructeur d'un Contact utilisant tout les attributs
        /// </summary>
        /// <param name="idContact"></param>
        /// <param name="idClient"></param>
        /// <param name="entreprise"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="fonction"></param>
        /// <param name="telephone"></param>
        /// <param name="projet"></param>
        /// <param name="activite"></param>
        public Contact(int idContact, int idClient, string entreprise, string nom, string prenom, string fonction, string telephone, string projet, string activite)
        {
            this.idClient = idClient;
            this.idContact = idContact;

            this.entreprise = entreprise;
            this.nom = nom;
            this.prenom = prenom;
            this.fonction = fonction;
            this.telephone = telephone;
            this.projet = projet;
            this.activite = activite;
        }

        /// <summary>
        /// Constructeur d'un Contact à partir de si=on id
        /// </summary>
        /// <param name="idContact"></param>
        public Contact(int idContact)
        {
            this.idContact = idContact;

        }



        public Contact()
        {

        }

        /// <summary>
        /// Accesseur de entreprise sans contrôle
        /// </summary>
        public string Entreprise
        {
            get
            {
                return entreprise;
            }

            set
            {
                entreprise = value;
            }
        }
        /// <summary>
        /// Accesseur Entreprise
        /// </summary>
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        /// <summary>
        /// accesseur Prenonm sans controle
        /// </summary>
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }
        /// <summary>
        /// Accesseur de la Fonction du Contact dans l'entreprise
        /// </summary>
        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
            }
        }
        /// <summary>
        /// Accesseur du téléphone du contact
        /// </summary>
        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        /// <summary>
        /// accesseur du projet sur lequel travail le contact au sein de ABI
        /// </summary> 
        public string Projet
        {
            get
            {
                return projet;
            }

            set
            {
                projet = value;
            }
        }

        /// <summary>
        /// Accesseur de l'activite du Contact
        /// </summary>
        public string Activite
        {
            get
            {
                return activite;
            }

            set
            {
                activite = value;
            }
        }

        /// <summary>
        /// Accesseur de ID Client
        /// </summary>
        public int IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }
        /// <summary>
        /// accesseur du numero de Contact
        /// </summary>
        public int IdContact
        {
            get
            {
                return idContact;
            }

            set
            {
                idContact = value;
            }
        }
    }
}
