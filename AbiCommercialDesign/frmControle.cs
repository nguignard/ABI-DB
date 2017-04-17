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
    public partial class frmControle : Form
    {
        public frmControle()
        {
            InitializeComponent();
            DB();
            VS();

        }





        /// <summary>
        /// Methode afficheClients:  Prépare l'affichage et Affiche les Clients dans le dataGrid 
        /// </summary>
        private void DB()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            //Nomage des colonnes
            dt.Columns.Add(new DataColumn("Numéro Client", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(string)));
            dt.Columns.Add(new DataColumn("CA", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("Nature", typeof(String)));

            for (int i = 0; i < Donnees.Db.TClient.ToList().Count; i++)//remplissage d'une Datarow
            {
                dr = dt.NewRow();
                dr[0] = Donnees.Db.TClient.ToList()[i].IdClient;
                dr[1] = Donnees.Db.TClient.ToList()[i].RaisonSociale;
                dr[2] = Donnees.Db.TClient.ToList()[i].Telephone;
                dr[3] = Donnees.Db.TClient.ToList()[i].CA;
                dr[4] = Donnees.Db.TClient.ToList()[i].Nature;
                dt.Rows.Add(dr); //ajout a la collection des lignes
            }

            this.grdDB.DataSource = dt.DefaultView;//DefaultView permet d'utiliser le trie
            this.grdDB.Refresh();

            dt = null;
            dr = null;
        }

        private void VS()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            //Nomage des colonnes
            dt.Columns.Add(new DataColumn("Numéro Client", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Raison Sociale", typeof(string)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(string)));
            dt.Columns.Add(new DataColumn("CA", typeof(Decimal)));
            dt.Columns.Add(new DataColumn("Nature", typeof(String)));

            for (int i = 0; i < Donnees.ListeFicheClient.Count; i++)//remplissage d'une Datarow
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ListeFicheClient[i].IdClient;
                dr[1] = Donnees.ListeFicheClient[i].RaisonSociale;
                dr[2] = Donnees.ListeFicheClient[i].Telephone;
                dr[3] = Donnees.ListeFicheClient[i].CA;
                dr[4] = Donnees.ListeFicheClient[i].Nature;
                dt.Rows.Add(dr); //ajout a la collection des lignes
            }

            this.grdVS.DataSource = dt.DefaultView;//DefaultView permet d'utiliser le trie
            this.grdVS.Refresh();

            dt = null;
            dr = null;
        }

    }
}
