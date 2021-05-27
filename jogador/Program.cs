using System;
using jogador.classes;

namespace jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Em qual posição você joga?
A-atacante
D-Defesa
M-meio de campo");
            string opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "a":
                    JogadorAtaque a = new JogadorAtaque();
                    Console.WriteLine(a.dados());
                    Console.WriteLine($"a idade média para se aposentar da posicão atacante é de {a.ima} faltam { a.ima - a.calcular} anos para você se aposentar");
                break;
                case "d":
                    JogadorDefesa d = new JogadorDefesa();
                    Console.WriteLine(d.dados());
                    Console.WriteLine($"a idade média para se aposentar da posição defesa é de {d.imd} faltam { d.imd - d.calcular} anos para você se aposentar");
                break;
                case "m":
                    MeioDeCampo m = new MeioDeCampo();
                    Console.WriteLine(m.dados());
                    Console.WriteLine($"a idade média para se aposentar da posição Meio de Campo é de {m.imm} faltam { m.imm - m.calcular} anos para você se aposentar");
                break;


                default:
                    break;
            }
        }
    }
}
