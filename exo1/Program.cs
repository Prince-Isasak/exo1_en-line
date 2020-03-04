using System;
using System.Collections.Generic;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste = new List<int>();
            var som = 0;
            while (true)
            {
                
                Console.WriteLine("Enter des prix sans fcfa");
                var user = Console.ReadLine();               
                if (user == "c'est finis")               
                break;
                else
                {
                    var NombreUser = Convert.ToInt32(user);
                    liste.Add(NombreUser);
                }
                
            }
            foreach (var item in liste)
            {
                som += item;
            }
            Console.WriteLine("la somme est :"+" "+ som);
        }
    }
}
