using System;

namespace Partie4Exercice1nv
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] jours = { "lundi", "Mardi", "Mercredi", "jedi", "vendredi", "Samedi" };

            Console.WriteLine("le contenu de l'indice 1" + jours[1]);
            Console.WriteLine("le contenu de l'indice 4" + jours[4]);
            Console.WriteLine("le contenu  du 1ére élement" + jours[0]);
            Console.WriteLine("le continu du 4 éme élement" + jours[3]);
            jours[3] = "jeudi";
           
            Array.Resize(ref jours, jours.Length + 1);
            jours[6] = "dimanche";
          /*  foreach (String jour in jours)
            {
                Console.WriteLine(jour);
            }
            
            */
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(jours[i].ToString());
            }
            



        }
    }
}
