using System;
using System.Collections.Generic;
using System.Linq;

namespace Banque // Nom du projet
{
    public class ComptePremium : Compte // Le ComptePremium (enfant) hérite de Compte (parent)
    {
        private double decouvertAutorise { get; set; } //  les accesseurs get et set de la propriété n’effectuent aucune autre opération que la définition ou la récupération d’une valeur dans un champ de stockage privé
        // la variable se contente de définir ou récupérer la valeur dans un champ
        public ComptePremium(string nom) : base(nom)
        { // Constructeur
        }
        public ComptePremium(string nom, double solde) : base(nom, solde)
        {// Constructeur
            decouvertAutorise = 500;
        }

        public override void retrait(double somme) 
        { // On réécrit la fonction retrait de Compte
            if(solde - somme < decouvertAutorise * (-1)) // si solde - retrait est inférieurau découvert autorisé
            { // exemple: 100 - 200 < -500        => OK
            // exemple: 100 - 700 < -500        => Exception
                throw new DecouvertException();
            } // sinon
            solde -= somme;
        }
    }
}