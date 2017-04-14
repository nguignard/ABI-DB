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

        //Cette Collection est le reflet de ce qui se passe dans VISUAL

        //Collection liste des Clients de la Société, static pour être accessible sans instanciation par toutes les autres classes
        public static List<Client> ListeFicheClient = new List<Client>();
        //Compte le nombre total de Client
        public static Int32 nbrClient = 0;


        //Création de la collection de ce qui se passe dans la BASE DE DONNEE
        public static DbAbiEntities Db = new DbAbiEntities();


        // Convertir un Contact vers un TContact

        public static TContact convertToContact(Contact c)
        {
            TContact tc = new TContact();

            tc.IdClient = c.IdClient;
            tc.IdContact = c.IdClient;

            tc.Entreprise = c.Entreprise;
            tc.Nom = c.Nom;
            tc.Prenom = c.Prenom;
            tc.Fonction = c.Fonction;
            tc.Telephone = c.Telephone;
            tc.Projet = c.Projet;
            tc.Activite = c.Activite;

            return tc;
        }



        // Convertir un Client vers un TClient

        public static TClient convertToTClient(Client c)
        {
            TClient tc = new TClient();

            tc.IdClient = c.IdClient;

            tc.Effectif = c.Effectif;
            tc.CA = c.CA;
            tc.RaisonSociale = tc.RaisonSociale;
            tc.TypeSociete = tc.TypeSociete;
            tc.Nature = tc.Nature;
            tc.RaisonSociale = c.RaisonSociale;
            tc.TypeSociete = c.TypeSociete;
            tc.Nature = c.Nature;
            tc.Adresse = c.Adresse;
            tc.CP = c.CP;
            tc.Ville = c.Ville;
            tc.Activite = c.Activite;
            tc.Telephone = c.Telephone;
            tc.CommentComm = c.CommentComm;

            //nbrContact??

            return tc;
        }


        //Export vers la database

        static void ToDB()
        {

            if (ListeFicheClient.Count > Db.TClient.ToList().Count)
            {
                TClient tc = new Abi.TClient();
                Db.TClient.Add(tc);
            }
            //else
            //{
            //    if(ListeFicheClient.Count < Db.TClient.ToList().Count)
            //    {

            //    }
            //}

            for (int i = 0; i < ListeFicheClient.Count; i++)
            {
                Db.TClient.ToList()[i] = convertToTClient(ListeFicheClient[i]);

                for (int j = 0; j < ListeFicheClient.Count; j++)
                {
                    Db.TContact.ToList()[j] = convertToContact(ListeFicheClient[i].ListContacts[j]);
                }
            }

            Db.SaveChanges();
        }
    }
}
