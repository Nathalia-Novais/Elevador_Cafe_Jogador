using System;
namespace MaquinaCafe.classes
{
    public class MaqCafe
    {
        public int acucarDisponivel = 20;

        public string fazerCafe()

        {

            Console.WriteLine(@"Você deseja escolher quanto de açucar desejada no café? (s/n) 
OBS:a maquina adiciona 10g por padrão");
            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "s":
                    Console.Write("Quanta gramas de açucar você deseja ? ");
                    int quanto = int.Parse(Console.ReadLine());

                    if (quanto <= acucarDisponivel)
                    {
                        int atualizar = acucarDisponivel - quanto;
                        acucarDisponivel = atualizar;
                        Console.WriteLine($"Você adicionou {quanto}g de açucar no café, agora a maquina só possui {atualizar}g de açucar");

                    }
                    else
                    {
                        Console.WriteLine("A máquina não possui essa quantidade de açucar disponível");
                        Console.WriteLine("Fazendo café sem açucar...");
                    }
                    break;

                case "n":
                    if (acucarDisponivel >= 0)
                    {
                        Console.WriteLine("A máquina adicionou 10 gramas de açucar por padrão.");
                        acucarDisponivel = acucarDisponivel - 10;
                    }
                    else
                    {
                        Console.WriteLine("A máquina não possui essa quantidade de açucar disponível");
                        Console.WriteLine("Fazendo café sem açucar...");
                    }

                    break;


                default:
                    Console.WriteLine("A escolha desejada é inválida.");
                    break;

            }
            return "O café está pronto";
        }
    }
}
