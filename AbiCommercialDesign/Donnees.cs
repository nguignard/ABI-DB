using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abi;

namespace Abi
{
    /// <summary>
    /// Classe publique de donnees statique permettant d'echanger les seuls données utiles
    /// -entrees Client et mise en base de donnee
    /// </summary>
    public class Donnees
    {
        //Création de la collection de ce qui se passe dans la BASE DE DONNEE
        public static DbAbiEntities10 Db = new DbAbiEntities10();


        //Cette Collection est le reflet de ce qui se passe dans VISUAL
        //Collection liste des Clients de la Société, static pour être accessible sans instanciation par toutes les autres classes
        public static List<Client> ListeFicheClient = new List<Client>();
        //Compte le nombre total de Client
        public static Int32 nbrClient = 0;


        // Convertir un Contact vers un TContact

        public static TContact convertToTContact(Contact c)
        {
            TContact tc = new TContact();

            tc.IdClient = c.IdClient;
            tc.IdContact = c.IdContact;

            tc.Entreprise = c.Entreprise;
            tc.Nom = c.Nom;
            tc.Prenom = c.Prenom;
            tc.Fonction = c.Fonction;
            tc.Telephone = c.Telephone;
            tc.Projet = c.Projet;
            tc.Activite = c.Activite;

            return tc;
        }

        // Convertir un TContact vers un Contact
        public static Contact convertToContact(TContact tc)
        {
            Contact c = new Contact();

            tc.IdClient = c.IdClient;
            tc.IdContact = c.IdContact;

            tc.Entreprise = c.Entreprise;
            tc.Nom = c.Nom;
            tc.Prenom = c.Prenom;
            tc.Fonction = c.Fonction;
            tc.Telephone = c.Telephone;
            tc.Projet = c.Projet;
            tc.Activite = c.Activite;

            return c;
        }

        // Convertir un Client vers un TClient
        public static TClient convertToTClient(Client c)
        {
            TClient tc = new TClient();

            // transcrit chaque attribut
            tc.IdClient = c.IdClient;
            tc.NbrContact = c.NbrContact;
            tc.Effectif = c.Effectif;
            tc.CA = c.CA;

            tc.RaisonSociale = c.RaisonSociale;
            tc.TypeSociete = c.TypeSociete;
            tc.Nature = c.Nature;
            tc.Adresse = c.Adresse;
            tc.CP = c.CP;
            tc.Ville = c.Ville;
            tc.Activite = c.Activite;
            tc.Telephone = c.Telephone;
            tc.CommentComm = c.CommentComm;

            return tc;
        }

        // Convertir un TClient vers un Client
        public static Client convertToClient(TClient tc)
        {
           

            Client c = new Client();

            c.IdClient = tc.IdClient;
            c.NbrContact = tc.NbrContact;

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

            return c;


        }

        //Enregistrement liste complete en DB
        public static void Push()
        {
            TContact tContact;
            TClient tClient;

            for (Int32 j = 0; j < Db.TContact.ToList().Count; j++)
            {
                tContact = Db.TContact.ToList()[j];
                Db.TContact.Remove(tContact);
            }
            for (Int32 j = 0; j < Db.TClient.ToList().Count; j++)
            {
                tClient = Db.TClient.ToList()[j];
                Db.TClient.Remove(tClient);
            }
            Db.SaveChanges();

            foreach (Client clt in ListeFicheClient)
            {
                tClient = convertToTClient(clt);
              

                Db.TClient.Add(tClient);
                Console.WriteLine("tclient.count" + Db.TClient.ToList().Count);

                Db.SaveChanges();

                if (clt.ListContacts != null)
                {
                    foreach (Contact ct in clt.ListContacts)
                    {
                        tContact = convertToTContact(ct);
                        Db.TContact.Add(tContact);
                        Db.SaveChanges();
                    }
                }
            }
          
          
        }

        //DownLoad liste complete de la DB
        public static void Pull()
        {
            Contact contact;
            Client client;

            ListeFicheClient.Clear();

            foreach (TClient tclt in Db.TClient.ToList())
            {
                client = convertToClient(tclt);

   

                foreach (TContact tc in Db.TContact.ToList())
                {
                    contact = convertToContact(tc);

                    if (contact.IdClient == client.IdClient)
                    {
                        client.ListContacts.Add(contact);
                    }
                }
                ListeFicheClient.Add(client);

            }


            //reccuperation du plus grand idClient en DB
            int i = 0;
            foreach (Client c in Donnees.ListeFicheClient)
            {
                if (c.IdClient > i)
                {
                    i = c.IdClient;
                }
            }
            nbrClient = i;
            Console.WriteLine("nBRE cLIENT+ " + nbrClient);




        }
    }
}
