/**Créer un nouveau projet Exercice40

Le programme doit permettre de saisir plusieurs températures entières, forcément comprises entre -20 et +40 (il faut en contrôler la saisie). Le nombre de températures doit être saisi dès le début du programme. Au final, pour chaque température, il faut afficher sa fréquence soit le nombre de fois où la température a été saisie.
 */

using System;

namespace Exercice40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Saisir le nombre de températures
            Console.Write("Saisir le nombre de températures : ");
            int nb = int.Parse(Console.ReadLine());
            
            //Tableau de températures
            int[] temp = new int[nb];//Taille dimensionnée à nb
            
            //Saisie de températures dans un tableau
            for ( int i = 0; i < nb; i++ )
            {
                do
                {
                    Console.Write("Saisie de la température n°" + (i+1) + " : ");
                    temp[i] = int.Parse(Console.ReadLine());
                } while (temp[i] <= -20 || temp[i] >= 40);
            }

            //Affichage des fréquences
             for (int t = -20;t <= 40; t++ ) 
            {
                //Fréquence
                int frequence = 0;
                for (int i  = 0; i < nb; i++)
                {
                    if (temp[i] == t)
                    {
                        frequence++;
                    }
                }
                if (frequence != 0) 
                {
                    Console.WriteLine("La température " + t + " est apparue " + frequence + " fois.");
                }
            }
            Console.ReadLine();

        }
    }
}


