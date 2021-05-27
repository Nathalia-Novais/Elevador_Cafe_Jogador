using System;
using MaquinaCafe.classes;

namespace MaquinaCafe
{
    class Program
    {
        static void Main(string[] args)
        {

             MaqCafe m = new MaqCafe();
             
            bool outro = false;

            do
            {
              Console.WriteLine("Deseja fazer uma café? (s/n)");
            string opcao1 = Console.ReadLine();

            if (opcao1 == "s")
            {
               
                Console.WriteLine (m.fazerCafe());
            }   

            else
            {
                 outro = true;
            } 
               
            } while (outro == false);
           


        }
    }
}
