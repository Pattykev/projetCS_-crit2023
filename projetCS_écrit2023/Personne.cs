using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetCS_écrit2023
{
    class Personne
    {
        private string nom;
        private string prénom;
        private int age;
        private static int nbPersonne=0;

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prénom = prenom;
            this.age = age;
           Personne.nbPersonne += 1;
        }
        public string AfficherPersonne()
        {
            return "Nom :" + this.nom + " Prénom :" + this.prénom + " Age :" + this.age;
        }
        public static string Combien()
        {
           return "Le nombre de personne :" + Personne.nbPersonne;

        }
        public static string Combien(List<Personne> cp)
        {   int n=0;
        foreach (Personne p in cp)
        {
            if (this != null)
            {
                n++;
            }
        }
            return "Le nombre de personne :" + n;

        }
    }
    }
