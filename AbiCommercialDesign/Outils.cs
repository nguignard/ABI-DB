using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abi
{
    /// <summary>
    /// la Classe Outils met a disposition toute les methode utilisées par plusieurs classes
    /// </summary>
    public class Outils
    {
      
        /// <summary>
        /// EstEntier permet de verifier qu'un nombre sous forme de string est bien un Int32
        /// </summary>
        /// <param name="s">retourne true si s est un Int32, false sinon</param>
        /// <returns></returns>
        public static bool EstEntier(string s)
        {
            bool IsInt = true;

            if (s.Length > 0 && s.Length < 10) // un Int32 doit avoir mois de 10 chiffres
            {
                foreach (char c in s)
                {
                    if (!(char.IsDigit(c))) // contrôle que chaque caratere est bien un Digit
                    {
                        IsInt = false;
                    }
                }
            }
            else
            {
                IsInt = false;
            }
            return IsInt;
        }


        /// <summary>
        /// EstCodePostal, si le string est un entier et = 5 chiffres renvoie true, sinon false
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool EstCodePostal(string s)
        {
            if (s.Length == 5)
                return true;
            else
                return false;
        }


        //public static int FindIndex(int index)
        //{
        //   index
        //}




    }
}
