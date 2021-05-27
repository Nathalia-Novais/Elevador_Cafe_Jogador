using System;
namespace jogador.classes
{
    public abstract class JogaFut
    {
            public string nome;
            public int nascimento;
            public string nacionalidade;
            public string altura;
            public int peso;

            public int calcular;

            public string dados()
            {
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();

                Console.WriteLine("Qual o ano do seu nascimento?");
                nascimento = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a sua nacionalidade?");
                nacionalidade = Console.ReadLine();

                Console.WriteLine("Qual a sua altura?");
                altura = Console.ReadLine();

                Console.WriteLine("Qual o seu peso");
                peso = int.Parse(Console.ReadLine());

                calcular = DateTime.Now.Year - nascimento;

                Console.WriteLine($@"Nome:{nome} 
Idade:{calcular}
Nacionalidade:{nacionalidade} 
Altura:{altura} 
Peso:{peso}");
                return "";
            }
        }
    }