using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    /// <summary>
    /// Classe publique de donnees statique permettant d'echanger les seuls données utiles
    /// -entrees Client et mise en base de donnee
    /// </summary>
    public class Donnees
    {
        //Création de la collection de ce qui se passe dans la BASE DE DONNEE
        public static DbAbiEntities Db = new DbAbiEntities();

        //Cette Collection est le reflet de ce qui se passe dans VISUAL
        //Collection liste des Clients de la Société, static pour être accessible sans instanciation par toutes les autres classes
        public static List<Client> ListeFicheClient = new List<Client>();
        //Compte le nombre total de Client
        public static Int32 nbrClient = 0;


        // Convertir un TContact vers un Contact

        public static TContact convertToTContact(Contact c)
        {
            TContact tc = new TContact();

            c.IdClient = tc.IdClient;
            c.IdContact = tc.IdContact;

            c.Entreprise = tc.Entreprise;
            c.Nom = tc.Nom;
            c.Prenom = tc.Prenom;
            c.Fonction = tc.Fonction;
            c.Telephone = tc.Telephone;
            c.Projet = tc.Projet;
            c.Activite = tc.Activite;

            return tc;
        }

        // Convertir un TContact vers un Contact
        public static Contact convertToContact(TContact c)
        {
            Contact tc = new Contact();

            c.IdClient = tc.IdClient;
            c.IdContact = tc.IdContact;

            c.Entreprise = tc.Entreprise;
            c.Nom = tc.Nom;
            c.Prenom = tc.Prenom;
            c.Fonction = tc.Fonction;
            c.Telephone = tc.Telephone;
            c.Projet = tc.Projet;
            c.Activite = tc.Activite;

            return tc;
        }

        // Convertir un Client vers un TClient
        public static void convertToTClient(Client c)
        {
            TClient tc = new TClient();

            // transcrit chaque attribut
            tc.IdClient = c.IdClient;
            // tc.nbrContact = c.nbrContact;?????????

            tc.Effectif = c.Effectif;
            tc.CA = c.CA;
            tc.RaisonSociale = c.RaisonSociale;
            tc.TypeSociete = c.TypeSociete;
            tc.Nature = c.Nature;
            tc.RaisonSociale = c.RaisonSociale;
            tc.TypeSociete = c.TypeSociete;
            tc.Nature = c.Nature;
            tc.Adresse = c.Adresse;
            tc.CP = c.CP;
            tc.Ville = c.Ville;
            tc.Activite = c.Activite;
            tc.Telephone = c.Telephone;
            tc.CommentComm = c.CommentComm;


            //Recherche et detruit le Tclient si il existe,
            //puis rajoute le TClient à la DB
            for (Int32 j = 0; j < Db.TClient.ToList().count; j++)
            {
                if (Db.TClient[j] == c.IdClient)
                    Db.TClient.remove(Db.TClient[j]);
                Db.TClient.Add(tc);
            }

            //Recherche to les contacts du TClient existant en DB et les détruits

            for (Int32 k = 0; k < Db.TContact.ToList().count; k++)
            {
                if (Db.TContact[k].idClient == c.IdClient)
                    Db.TContact.remove(Db.TContact[k]);
            }

            //ajoute les contact Client en DB
            for (Int32 k = 0; k < c.ListContacts.Count; k++)
            {
                Db.TContact.Add(convertToTContact(c.ListContacts[k]));
            }

            Db.TClient.SaveChanges();
            Db.TContact.SaveChanges();
        }

        // Convertir un TClient vers un Client
        public static Client convertToClient(TClient tc)
        {
            Db.TClient.SaveChanges();
            Db.TContact.SaveChanges();

            Client c = new Client();

            c.IdClient = tc.IdClient;
            // c.nbrContact = tc.nbrContact; A ajouter dans la base

            c.Effectif = (int)tc.Effectif;
            c.CA = (int)tc.CA;//??int dans la base, au lieu de decimal
            c.RaisonSociale = c.RaisonSociale;
            c.TypeSociete = c.TypeSociete;
            c.Nature = c.Nature;
            c.RaisonSociale = tc.RaisonSociale;
            c.TypeSociete = tc.TypeSociete;
            c.Nature = tc.Nature;
            c.Adresse = tc.Adresse;
            c.CP = tc.CP;
            c.Ville = tc.Ville;
            c.Activite = tc.Activite;
            c.Telephone = tc.Telephone;
            c.CommentComm = tc.CommentComm;

            c.ListContacts = new List<Contact>();

            for (Int32 j = 0; j < Db.TContact.ToList().Count; j++)
            {
                if (Db.TContact.ToList()[j].idClient == c.IdClient)
                {
                    c.ListContacts.Add(Db.TContact.ToList()[j]);
                }
            }
            return c;
        }

        //Enregistrement liste complete en DB
        public static void Push()
        {
            foreach(Client c in ListeFicheClient)
            {
                convertToTClient(c);
            }
        }

        //DownLoad liste complete de la DB
        public static void Pull()
        {
            foreach (TClient tc in Db.TClient.ToListe())
            {
                convertToClient(tc);
            }
        }






    }
}
