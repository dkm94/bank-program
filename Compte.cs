using System;
using System.Collections.Generic;
using System.Linq;

namespace Banque // Nom du projet
{
    public abstract class Compte // la classe parent Compte est publique pour pouvoir faire hériter ses enfants (CompteJeune, CompteEpargne et ComptePremium)
    { // C'est une classe abstraite car elle n'existe pas vraiment, seulement pour pouvoir créer les sous-classes précédemment citées. C'est le modèle commun des 3 sous classes.
    // C'est la classe de base

    //minuscule: champ(field)
    //masjuscule: propriété
        protected double solde; // on déclare l'attribut solde utilisé exclusivement à l'intérieur de la classe
        // C'est une variable de type "double" (c'est un type numérique à virgule flottante)
        public double Solde{ // la propriété Solde sera utilisée à l'extérieur de la classe
            get{return solde;} // le getter retourne le solde
        }

        protected String titulaire; // on déclare l'attribut titulaire utilisé exclusivement à l'intérieur de la classe 
        // C'est une variable de type String
        public String Titulaire{ // la propriété Titulaire sera utilisée à l'extérieur de la classe
            get{return titulaire;} // le getter retourne le titulaire
            set{titulaire= value;} // le setter stocke la valeur de la propriété Titulaire
        }

        public Compte(String nom){ // Constructeur de Compte: nom
            titulaire = nom; // la variable titulaire est égale à nom
        }

        public Compte(String nom, double solde):this(nom){ // Constructeur de Compte: nom et solde
            this.solde = solde; // this est utilisé pour qualifier les membres de la classe Compte, nom et solde qui sont masqués par des noms similaires
            // comme dans Javascript, il permet de se référer à l'objet courant (current instance) donc le nom et le solde de l'instance courante
        }


        public abstract void retrait(double montant); // méthode abstract = méthode virtuelle, autorisée car dans une classe abstract
        // elle sera définie dans les enfants via une méthode override du même nom (retrait)

        public virtual void depot(double montant){ // méthode virtual = méthode qui pourra être modifiée dans les enfants
            solde += montant; // solde = solde + montant
        }
    }
}