﻿using System;
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


        // Convertir un Contact vers un TContact

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

            Db.TClient.Add(tc);

            Db.SaveChanges();
           
          






            ////Recherche et detruit le Tclient si il existe,
            ////puis rajoute le TClient à la DB
            //for (Int32 j = 0; j < Db.TClient.ToList().Count; j++)
            //{
            //    Console.WriteLine("idClient" + Db.TClient.ToList()[j].IdClient.ToString());

            //    if (Db.TClient.ToList()[j].IdClient == c.IdClient)
            //        Db.TClient.Remove(Db.TClient.ToList()[j]); 
            //}
            //Db.TClient.Add(tc);

            //Console.WriteLine("DbClient Count " + Db.TClient.ToList().Count.ToString());

            //for (Int32 j = 0; j < Db.TClient.ToList().Count; j++)
            //{
            //    Console.WriteLine("idClient" + Db.TClient.ToList()[j].IdClient.ToString());

            //}



            ////Recherche to les Contacts du TClient existant en DB et les détruits
            //for (Int32 k = 0; k < Db.TContact.ToList().Count; k++)
            //{
            //    if (Db.TContact.ToList()[k].IdClient == c.IdClient)
            //        Db.TContact.Remove(Db.TContact.ToList()[k]);
            //}

            ////ajoute les contact Client en DB
            //for (Int32 k = 0; k < c.ListContacts.Count; k++)
            //{
            //    Db.TContact.Add(convertToTContact(c.ListContacts[k]));
            //}

            //Db.SaveChanges();
        }

        // Convertir un TClient vers un Client
        public static Client convertToClient(TClient tc)
        {
            //Db.SaveChanges();

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

            for (Int32 j = 0; j < Db.TContact.ToList().Count; j++)
            {
                Console.WriteLine(Db.TContact.ToList()[j].IdClient.ToString());
                if (Db.TContact.ToList()[j].IdClient == c.IdClient)
                {
                    c.ListContacts.Add(convertToContact(Db.TContact.ToList()[j]));
                }
            }
            return c;
        }

        //Enregistrement liste complete en DB
        public static void Push()
        {
            foreach (Client c in ListeFicheClient)
            {
                convertToTClient(c);
            }
        }

        //DownLoad liste complete de la DB
        public static void Pull()
        {
            foreach (TClient tc in Db.TClient.ToList())
            {
                convertToClient(tc);
            }
        }
    }
}
