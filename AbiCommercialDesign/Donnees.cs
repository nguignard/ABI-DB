using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    /// <summary>
    /// Classe publique de donnees statique permettant d'echanger les seuls données utiles
    /// </summary>
    public class Donnees
    {
        //Collection liste des Clients de la Société, static pour être accessible sans instanciation par toutes les autres classes
        public static List<Client> ListeFicheClient = new List<Client>();
        public static Int32 nbrClient = 0;


    }
}
