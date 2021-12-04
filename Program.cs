using System;
using System.Collections.Generic;
using System.Linq;

namespace Banque // Nom du projet
{
    public class Program // la classe parent Program est publique pour pouvoir faire hériter ses enfants
    {
        public static void Main(string[] args)
        {
            CompteJeune compteA = new CompteJeune("Amanda", 900);
            ComptePremium compteJ = new ComptePremium("Joan", 1500);
            CompteEpargne compteK = new CompteEpargne("Karim", 3600);
            try
            {
                Console.WriteLine($"{compteA.Titulaire} a un solde de base de {compteA.Solde}€"); // solde de base Amanda
                compteA.retrait(100);
                Console.WriteLine($"{compteA.Titulaire} a un solde après 1er retrait de {compteA.Solde}€"); // Solde après retrait
                compteA.retrait(300); // 2e retrait

                Console.WriteLine($"{compteJ.Titulaire} a un solde de base de {compteJ.Solde}€"); // solde de base Joan
                compteJ.retrait(1000);
                Console.WriteLine($"{compteJ.Titulaire} a un solde après 1er retrait de {compteJ.Solde}€"); // Solde après retrait
                compteJ.retrait(1500); // 2e retrait

                Console.WriteLine($"{compteK.Titulaire} a un solde de base de {compteK.Solde}€"); // solde de base Karim
                compteK.retrait(100);
                Console.WriteLine($"{compteK.Titulaire} a un solde après 1er retrait de {compteK.Solde}€"); // Solde après retrait
                compteK.depot(500);
            }
            catch(DecouvertException de)
            {
                de.DisplayError(); // si exception = si quelqu'un entre en découvert, on affiche un message d'erreur. 
                //(C'est la fonction DecouvertException dans CompteJeune qui contient le message, et la fonction DisplayError qui l'ecrit dans la console)
            }

            // Si je tombe dans une exception dans le try, les opérations suivantes ne sont pas prises en compte. On passe directement ici:
            //(Dans le cas présent, Joan, qui est le deuxième dans la liste, tombe dans l'exception. Donc aucune des opérations de retrait des titulaires suivants ne seront pas prises en compte)
            Console.WriteLine($"{compteA.Titulaire} a un solde final de {compteA.Solde}€"); // Solde après retrait
            Console.WriteLine($"{compteJ.Titulaire} a un solde final de {compteJ.Solde}€"); // Solde après 2e retrait
            Console.WriteLine($"{compteK.Titulaire} a un solde final de {compteK.Solde}€"); // Solde après 2e retrait

        }
    }
}