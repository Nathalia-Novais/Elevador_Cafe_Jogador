using System;
using elevador.classes;

namespace elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                social soc = new social();
                servico ser = new servico();


                Console.WriteLine(@" Qual elevador você quer usar?
1 - Social
2 - Serviço");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine(soc.Inicializar());

                        do
                        {
                            Console.WriteLine(@"Qual opção você quer escolher?
1 - Entrar
2 - Sair
3 - Subir
4 - Descer");

                            int opcaoelevador = int.Parse(Console.ReadLine());

                            switch (opcaoelevador)
                            {
                                case 1:

                                    Console.WriteLine(soc.Entrar());
                                    break;


                                case 2:
                                    Console.WriteLine(soc.Sair());

                                    break;
                                case 3:
                                    Console.WriteLine(soc.Subir());
                                    break;
                                case 4:
                                    Console.WriteLine(soc.Descer());
                                    break;
                                default:
                                    Console.WriteLine("Digite uma opção válida");
                                    break;
                            }
                        } while (soc.Pessoas > 0);
                        break;

                    case 2:


                        ser.Inicializar();

                        do
                        {
                            Console.WriteLine(@"O que você quer realizar
1 - Entrar                    
2 - Sair
3 - Subir
4 - Descer
5 - Adicionar Caixa
6 - Remover caixa");
                            int opcaoElevador2 = int.Parse(Console.ReadLine());

                            switch (opcaoElevador2)
                            {
                                case 1:

                                    Console.WriteLine(ser.Entrar());

                                    break;
                                case 2:

                                    Console.WriteLine(ser.Sair());

                                    break;
                                case 3:
                                    Console.WriteLine(ser.Subir());
                                    break;
                                case 4:
                                    Console.WriteLine(ser.Descer());

                                    break;
                                case 5:
                                    Console.WriteLine(ser.AdicionarCaixa());
                                    break;
                                case 6:
                                    Console.WriteLine(ser.RetirarCaixa());
                                    break;
                                default:
                                    break;
                            }

                        } while (ser.Pessoas > 0);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
