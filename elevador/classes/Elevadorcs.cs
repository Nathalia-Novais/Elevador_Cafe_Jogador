using System;
namespace elevador.classes
{
    public abstract class Elevadorcs
    {

        public int andaratual;

        public int andares;

        public int capacidade;

        public int Pessoas;


        public string Inicializar()
        {
            Console.WriteLine("Quantos andares tem o prédio?");
            andares = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade do elevador?");
            capacidade = int.Parse(Console.ReadLine());

            return "";

        }
        public string Entrar()
        {
            if (Pessoas <= capacidade)
            {
                
                Pessoas = Pessoas + 1;
               return$"Entrou uma pessoa no elevador, tem {Pessoas} pessoa(s) no elevador, a capacidade de pessoas é de {capacidade}";
            }
            else
            {
                return "Elevador cheio";
            }
        }
        public string Sair()
        {
            if (Pessoas > 0)
            {

                Pessoas = Pessoas - 1;
                return $"Saiu uma pessoa do elevador, tem {Pessoas} pessoa(s) no elevador";
            }
            else
            {
                return "Elevador vazio, não é possível sair ninguem";
            }
        }
        public int Subir()
        {
             Console.WriteLine($"Para qual andar você quer subir?");
             int andaressubir = int.Parse(Console.ReadLine());

            if (andaressubir <= andares)
            {
                for (int i = 0; i < andaressubir; i++)
                {
                    
                }
               
                Console.WriteLine($" Subimos, agora estamos no {andaressubir}° andar");
               

            }
            else
            {
                Console.WriteLine("você já está no último andar");
            }
            return andares;
        }

        public int Descer()
        {
                Console.WriteLine($"Para qual andar você quer descer?");
               int andardescer = int.Parse(Console.ReadLine());


                 if (andardescer <= andares)
                {
                    
                for (int i = 0; i < andardescer; i++)
                {
                    
                }
               
                    Console.WriteLine($"Descemos, Estamos no {andardescer}° andar");
                   
                }
                else
                {
                    Console.WriteLine("Já estamos no terreo");
                }

            

            return andares;
        }





    }

}
