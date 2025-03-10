namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("=======================================");

                //menu
                Console.WriteLine("\n1.Soma");
                Console.WriteLine("2.Subtração");
                Console.WriteLine("3.Multiplicação");
                Console.WriteLine("4.Divisão");
                Console.WriteLine("5.Tabuada");
                Console.WriteLine("S.Sair");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");


                string opcao = Console.ReadLine().ToUpper();//ToUpper converte a string para maiúscula


                //Sair
                if (opcao == "S")
                {
                    break;
                }
                else if (opcao == "5")
                {
                    Console.WriteLine("\n\n=======================================");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("=======================================");

                    Console.Write("Digite o número da tabuada: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadoTabuada = numeroTabuada * contador;

                        //string linhaTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;
                        Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}"); //interpolação
                    }

                    Console.WriteLine("\nPressione <Enter> para voltar ao menu!");
                    Console.ReadKey();
                    continue;

                }

                Console.Write("Digite o primeiro número: ");
                string n1s = Console.ReadLine();
                decimal n1 = Convert.ToDecimal(n1s);

                Console.Write("Digite o segundo número: ");
                string n2s = Console.ReadLine();
                decimal n2 = Convert.ToDecimal(n2s);

                decimal resultado = 0;

                //Soma
                else if (opcao == "1")
                {

                    //processo
                    resultado = n1 + n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2);
                    Console.WriteLine("Resultado da soma: " + resultado.ToString("F2"));
                    Console.WriteLine("=======================================");

                }


                //Subtração
                else if (opcao == "2")
                {

                    //processo
                    resultado = n1 - n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2);
                    Console.WriteLine("Resultado da sua subtração é: " + resultado.ToString("F2"));
                    Console.WriteLine("=======================================");

                }


                //Multiplicação
                else if (opcao == "3")
                {

                    //processo
                    resultado = n1 * n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2);
                    Console.WriteLine("Resultado da sua multiplacação é: " + resultado.ToString("F2"));
                    Console.WriteLine("=======================================");

                }


                //Divisão
                else if (opcao == "4")
                {

                    //processo
                    while (n2 == 0)
                    {
                        Console.Write("Não é possível dividir por 0\n Digite o segundo número novamente -> ");
                        n2 = Convert.ToDecimal(Console.ReadLine());
                    }
                    resultado = n1 / n2;

                    //saida
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("O primeiro número é: " + n1);
                    Console.WriteLine("O segundo número é: " + n2);
                    Console.WriteLine("Resultado da sua divisão é: " + resultado.ToString("F2"));
                    Console.WriteLine("=======================================");

                }

                Console.WriteLine("Deseja continuar (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;

            }
        }
    }
}
