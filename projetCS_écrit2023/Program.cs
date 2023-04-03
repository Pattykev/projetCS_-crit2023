using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetCS_écrit2023
{
    class Program
    {
        public static int CarréMagique(int cote)
        {
            int[,] carre = new int[cote, cote];
            int a, sommeColonne=0, sommeLigne=0;

            //remplir le carre en vérifiant les valeurs entrées

            for (int i = 0; i < cote; i++)
            {
                     for (int k = 0; k < cote; k++)
                        {
                            a = Convert.ToInt32(Console.ReadLine());
                            if (a <= cote * cote)
                            {
                                carre[i, k] = a;
                                
                            }
                           else
                           {
                                do{
                                Console.WriteLine("Entrer un nombre inférieur ou égal à: "+ cote*cote);
                                a = Convert.ToInt32(Console.ReadLine());
                                } while (a > cote*cote);
                                carre[i, k] = a;

                            }
                    }
                            
             
               
            }
            //vérifer que le tableau est un carré magique

            for (int i = 0; i < cote; i++)
            {
                for (int c = 0; c < cote; c++)
                {
                    sommeColonne += carre[c, i];
                    sommeLigne += carre[i, c];

                }
                //test s'il s'agit d'un carre magique
                if (sommeColonne != sommeLigne)
                {
                    Console.WriteLine("Il ne s'agit pas d'un carré magique " + sommeColonne + " " + sommeLigne);
                    Console.ReadLine();
                    return 0;
                }
            }

            //il s'agit d'un carre magique

                Console.WriteLine("Il s'agit d'un carré magique, la somme commune  vaut: " + sommeColonne + " " + sommeLigne);
                Console.ReadLine();
                return 0;
        
        }
        static void Main(string[] args)
        {
            
            Personne p1 = new Personne("Kévine", "Paty", 20);
            Personne p2 = new Personne("Kévine", "Pattyca", 19);
            Personne p3 = new Personne("Kévin", "Pattyca", 19);
            List<Personne> cp = new List<Personne>();
            cp.Add(p1);
            cp.Add(p2);
            cp.Add(p3);
            Console.WriteLine( p1.AfficherPersonne());
            Console.WriteLine( p2.AfficherPersonne());
            Console.WriteLine(Personne.Combien());
            Console.WriteLine(Personne.Combien(cp));
            Console.ReadLine();
             
           // CarréMagique(3);
        }
    }
}
