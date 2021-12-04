using System;
using System.Collections.Generic;
using System.Linq;

namespace Banque // Nom du projet
{
    public class CompteEpargne : Compte // Le CompteEpargne (enfant) hérite de Compte (parent)
    {
        private double tauxInteret; // Champ (variable) de type numérique
        public CompteEpargne(string nom) : base(nom)
        { // Constructeur
            tauxInteret = 10;
        }

        public CompteEpargne(string nom, double solde) : base(nom, solde)
        { // Constructeur
            tauxInteret = 10;
        }

        public override void retrait(double somme)
        { // On réécrit la fonction de retrait
            if(solde - somme < 0){ // si le solde - somme du retrait est inférieur à 0
                throw new DecouvertException();
            } // sinon
            solde = solde - somme;
        }

        public override void depot(double somme)
        {// On réécrit la fonction de dépôt
            double solde = somme + somme * (tauxInteret/100); // On déclare une fonction somme = somme du dépôt + somme du dépôt * intérêts
            base.depot(solde); // somme = somme du dépôt + intérêts
            // on récupère la fonction dépôt de la base Compte
        }
    }

}