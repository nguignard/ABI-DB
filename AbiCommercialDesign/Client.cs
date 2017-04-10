using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    /// <summary>
    /// FicheClient est la Classe définnissant ce qu'est un Client de l'entreprise
    /// </summary>
    public class Client
    {
        //BEGIN ATTRIBUT
        private Int32 idClient;
        private Int32 effectif;
        private decimal ca;
        private string raisonSociale;
        private string typeSociete;
        private string nature;
        private string adresse;
        private string cp;
        private string ville;
        private string activite;
        private string telephone;
        private string commentComm;
        private List<Contact> listContacts =new List<Contact>();
        // END ATTRIBUT




        //BEGIN - CONSTRUCTEURS DE LA CLASSE

        /// <summary>
        /// Constructeur avec tout les Attributs
        /// </summary>
        /// <param name="idClient"></param>
        /// <param name="raisonSociale"></param>
        /// <param name="typeSociete"></param>
        /// <param name="nature"></param>
        /// <param name="adresse"></param>
        /// <param name="cp"></param>
        /// <param name="ville"></param>
        /// <param name="activite"></param>
        /// <param name="telephone"></param>
        /// <param name="ca"></param>
        /// <param name="effectif"></param>
        /// <param name="commentComm"></param>
       

        /// <summary>
        /// Constructeur demandant aucun attribut
        /// </summary>
        public Client()
        {
          
        }

        public Client(int idClient, int effectif, decimal ca, string raisonSociale, string typeSociete, string nature, string adresse, string cp, string ville, string activite, string telephone, string commentComm, List<Contact> listContacts)
        {
            this.IdClient = idClient;
            this.Effectif = effectif;
            this.CA = ca;
            this.RaisonSociale = raisonSociale;
            this.TypeSociete = typeSociete;
            this.Nature = nature;
            this.Adresse = adresse;
            this.CP = cp;
            this.Ville = ville;
            this.Activite = activite;
            this.Telephone = telephone;
            this.CommentComm = commentComm;
            this.ListContacts = listContacts;
        }

        //END CONSTRUCTEURS


        //  DEBUT ACCESSEURS



        /// <summary>
        /// Accesseur IdClient, controle egalement qu'on entre bien un entier, ou renvoie une exception
        /// </summary>
        public int IdClient
        {
            get
            {
                return idClient;
            }
            set { idClient= value; }

        }

        /// <summary>
        /// RaisonSociale est un accesseur a raisonSocial, qui entre egalement la raison Sociale en Majuscule sans espace devant ou derriere 
        /// </summary>
        public string RaisonSociale
        {
            get
            {
                return raisonSociale;
            }

            set
            {
                raisonSociale = value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// TypeSociété est un accesseur sur des donnees pres remplies, donc pas de controle
        /// </summary>
        public string TypeSociete
        {
            get
            {
                return typeSociete;
            }

            set
            {
                typeSociete = value;
            }
        }

        /// <summary>
        /// Nature est un accesseur sur des donnees pres remplies, donc pas de controle
        /// </summary>
        public string Nature
        {
            get
            {
                return nature;
            }

            set
            {
                nature = value;
            }
        }
        /// <summary>
        /// Adresse
        /// </summary>
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value.ToLower().Trim();
            }
        }

        /// <summary>
        /// Activité accesseur sans controle car sur une comboliste pré rempli
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
        /// Accesseur à téléphone, sans contrôle de format
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
        /// Accesseur de ca , qui contrôle aussi que c'est bien un décimal, sinon renvoie une exception
        /// </summary>
        public decimal CA
        {
            get
            {
                return ca;
            }
            set
            {
                if (!decimal.TryParse(value.ToString(), out ca))
                    throw new Exception(value.ToString() + " : n'est pas un CA de Client Valide, il doit être un Décimal");
            }
        }

        /// <summary>
        /// accesseur à effectif, qui contrôle aussi que c'est un entier
        /// </summary>
        public int Effectif
        {
            get
            {
                return effectif;
            }

            set
            {
                if (Outils.EstEntier(value.ToString()))
                    effectif = value;
                else
                    throw new Exception(value.ToString() + " : n'est pas un EFFECTIF  Valide, il doit être un nombre de moins de 10 chiffre");
            }
        }
        /// <summary>
        /// Accesseur a commentaire commercial, sans contrôle
        /// </summary>
        public string CommentComm
        {
            get
            {
                return commentComm;
            }

            set
            {
                commentComm = value;
            }
        }

        /// <summary>
        /// Accesseur à cp, contrôle egalement qu'il n'y a que 5 chiffres 
        /// </summary>
        public string CP
        {
            get
            {
                return cp;
            }

            set
            {
                if(Outils.EstCodePostal(value.ToString()))
                cp = value;
                else
                    throw new Exception(value.ToString() + " : n'est pas un CODE POSTAL valide, il doit être un nombre de 5 chiffres");

            }
        }
        /// <summary>
        /// accesseur a ville, met la ville en majuscule
        /// </summary>
        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value.ToString().ToUpper();
            }
        }
        /// <summary>
        /// Accesseur a la Liste de Contactd'un Client
        /// </summary>
        public List<Contact> ListContacts
        {
            get
            {
                return listContacts;
            }

            set
            {
                listContacts = value;
            }
        }

        // FIN ACCESSEURS




    }
}
