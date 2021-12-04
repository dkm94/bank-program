using System;
using System.Collections.Generic;
using System.Linq;

namespace Banque // Nom du projet
{
    public class CompteEpargne : Compte // Le CompteEpargne (enfant) hérite de Compte (parent)
    {
        private double tauxInteret; // Champ (variable) de type numérique
        public CompteEpargne(String nom) : base(nom)
        { // Constructeur
            tauxInteret=10;
        }

        public CompteEpargne(String nom, double solde) : base(nom, solde)
        { // Constructeur
            tauxInteret=10;
        }

        public override void retrait(double montant)
        { // On réécrit la fonction de retrait
            if(solde - montant < 0){ // si le solde - montant du retrait est inférieur à 0
                throw new DecouvertException();
            } // sinon
            solde = solde - montant;
        }

        public override void depot(double montant)
        {// On réécrit la fonction de dépôt
            double somme= montant + montant* (tauxInteret/100); // On déclare une fonction somme = montant du dépôt + montant du dépôt * intérêts
            base.depot(somme); // somme = montant du dépôt + intérêts
            // on récupère la fonction dépôt de la base Compte
        }
    }

}