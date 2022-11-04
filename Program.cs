internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("***** Bem vindo ao Guess Game! *****\n");
        Console.ForegroundColor = ConsoleColor.White;

        char JogarDeNovo = 'S';
        int QuantidadeDeVidas = 0, Valor = 0, Sorteado = 0;
        var Aleatorio = new Random();

        while (JogarDeNovo == 'S')
        {
            char NivelDificuldade = ' ';

            while (NivelDificuldade != 'F' && NivelDificuldade != 'M' && NivelDificuldade != 'D' && JogarDeNovo == 'S')
            {
                Console.WriteLine("(F) Fácil   😨");
                Console.WriteLine("(M) Miédio  😰");
                Console.WriteLine("(D) Difícil 😱\n");
                Console.Write("Escolha a dificuldade: ");
                NivelDificuldade = char.Parse(Console.ReadLine());
                NivelDificuldade = char.ToUpper(NivelDificuldade);

                // FÁCIL
                if (NivelDificuldade == 'F')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEstou pensando em um valor entre: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1 e 10");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Em qual valor estou pensando? 🤔");
                    Console.ForegroundColor = ConsoleColor.White;
                    Sorteado = Aleatorio.Next(1, 10 + 1);

                    for (int vidas = 3; vidas > 0; vidas--)
                    {
                        Console.WriteLine($"\nQuantidade de vidas: {vidas}");
                        Console.Write("Entre com seu chute: ");
                        Valor = int.Parse(Console.ReadLine());

                        if (Valor < 1 || Valor > 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("OPÇÃO INVÁLIDA 😡");
                            Console.WriteLine("O VALOR DEVE SER ENTRE 1 e 10 😤");
                            vidas++;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (Valor > Sorteado)
                        {
                            Console.WriteLine("Chute muito alto 😵");
                        }
                        else if (Valor < Sorteado)
                        {
                            Console.WriteLine("Chute muito baixo 😓");
                        }
                        else
                        {
                            Console.WriteLine("Parabéns! você acertou! 🏆");
                            break;
                        }
                        Console.WriteLine();

                        if (vidas == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"O valor correto era: {Sorteado}");
                            Console.WriteLine("PERDEU! 💀");
                            Console.WriteLine("HEAHEAHEA");
                        }
                    }
                } // MÉDIO
                else if (NivelDificuldade == 'M')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEstou pensando em um valor entre: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1 e 50");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Em qual valor estou pensando? 🤔");
                    Console.ForegroundColor = ConsoleColor.White;
                    Sorteado = Aleatorio.Next(1, 50 + 1);

                    for (int vidas = 4; vidas > 0; vidas--)
                    {
                        Console.WriteLine($"\nQuantidade de vidas: {vidas}");
                        Console.Write("Entre com seu chute: ");
                        Valor = int.Parse(Console.ReadLine());

                        if (Valor < 1 || Valor > 50)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("OPÇÃO INVÁLIDA 😡");
                            Console.WriteLine("O VALOR DEVE SER ENTRE 1 e 50 😤");
                            vidas++;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (Valor > Sorteado)
                        {
                            Console.WriteLine("Chute muito alto 😵");
                        }
                        else if (Valor < Sorteado)
                        {
                            Console.WriteLine("Chute muito baixo 😓");
                        }
                        else
                        {
                            Console.WriteLine("Parabéns! você acertou! 🏆");
                            break;
                        }
                        Console.WriteLine();

                        if (vidas == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"O valor correto era: {Sorteado}");
                            Console.WriteLine("PERDEU! 💀");
                            Console.WriteLine("HEAHEAHEA");
                        }
                    }
                }   // DIFÍCIL
                else if (NivelDificuldade == 'D')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEstou pensando em um valor entre: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1 e 100");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Em qual valor estou pensando? 🤔");
                    Console.ForegroundColor = ConsoleColor.White;
                    Sorteado = Aleatorio.Next(1, 100 + 1);

                    for (int vidas = 5; vidas > 0; vidas--)
                    {
                        Console.WriteLine($"\nQuantidade de vidas: {vidas}");
                        Console.Write("Entre com seu chute: ");
                        Valor = int.Parse(Console.ReadLine());

                        if (Valor < 1 || Valor > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("OPÇÃO INVÁLIDA 😡");
                            Console.WriteLine("O VALOR DEVE SER ENTRE 1 e 100 😤");
                            vidas++;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (Valor > Sorteado)
                        {
                            Console.WriteLine("Chute muito alto 😵");
                        }
                        else if (Valor < Sorteado)
                        {
                            Console.WriteLine("Chute muito baixo 😓");
                        }
                        else
                        {
                            Console.WriteLine("Parabéns! você acertou! 🏆");
                            break;
                        }
                        Console.WriteLine();

                        if (vidas == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"O valor correto era: {Sorteado}");
                            Console.WriteLine("PERDEU! �");
                            Console.WriteLine("HEAHEAHEA");
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("OPÇÃO INVÁLIDA 😡");
                    Console.WriteLine("FAVOR ESCOLHER UM VALOR VÁLIDO.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            // PERGUNTAR SE QUER JOGAR DE NOVO
            Console.Write("Jogar de novo? S/N: ");
            JogarDeNovo = char.Parse(Console.ReadLine());
            JogarDeNovo = char.ToUpper(JogarDeNovo);

            while (JogarDeNovo != 'S' && JogarDeNovo != 'N')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OPÇÃO INVÁLIDA 😡");
                Console.WriteLine("FAVOR ESCOLHER UM VALOR VÁLIDO.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Jogar de novo? S/N: ");
                JogarDeNovo = char.Parse(Console.ReadLine());
                JogarDeNovo = char.ToUpper(JogarDeNovo);
            }

            if (JogarDeNovo == 'N')
            {
                break;
            }
            else if (JogarDeNovo == 'S')
            {
                continue;
            }
        }// fim jogardenovo

    }
}