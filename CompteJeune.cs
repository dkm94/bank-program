using System;
using System.Collections.Generic;
using System.Linq;

namespace Banque // Nom du projet
{
    public class CompteJeune : Compte // Le CompteJeune (enfant) hérite de Compte (parent)
    {
        public CompteJeune(string nom) : base(nom)
        { // Constructeur de CompteJeune
        // Dans Program, la fonction CompteJeune prendra en param le string "nom" hérité de Compte
        // base est le mot-clé qui permet d'accéder aux membres de la classe de base, ici le parent Compte
        }

        public CompteJeune(string nom, double solde) : base(nom, solde)
        { // Constructeur de CompteJeune
            // Dans Program, la fonction CompteJeune prendra en param le string "nom" et le numérique "solde" hérité de Compte
        }
        
        public override void retrait(double somme)
        {   // On utilisera la fonction retrait sur les nouvelles instances crées dans Program, en passant en param le somme du retrait souhaité
            // on réécrit la fonction retrait de Compte qu'on avait déclarée sans corps
            if(solde - somme < 0){ // si le solde - somme du retrait est inférieur à 0
                throw new DecouvertException(); // Si découvert, on retourne une nouvelle Exception (qu'on a créée)
            }
            solde -= somme; // sinon le nouveau solde est égal à solde - somme du retrait
        }
    }

    class DecouvertException : Exception
    { // Créer sa propre Exception:
    // 1: déclarer sa fonction avec le message d'erreur
    // 2: déclarer la fonction void qui va écrire le message d'erreur
            
        public DecouvertException() : base("Decouvert non autorisé")
        { // base = initialise une nouvelle instance d'exception avec un message d'erreur
        }

        public void DisplayError()
        {
                Console.WriteLine(Message);
        }
    }

}