namespace Calculdora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // enquanto condição for verdadeira
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Calculadora Tabajara - 2025");
                Console.WriteLine("----------------------------------\n");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("S - Sair");

                Console.Write("\nEscolha uma opção: ");

                string option = Console.ReadLine().ToUpper();

                if (option == "S")
                    break;

                Console.Write("Digite o primeiro número: ");
                string firstNumberString = Console.ReadLine();
                decimal firstNumber = Convert.ToDecimal(firstNumberString);

                Console.Write("Digite o segundo número: ");
                string secondNumberString = Console.ReadLine();
                decimal secondNumber = Convert.ToDecimal(secondNumberString);

                decimal result = 0;

                // se / senao / senao se
                if (option == "1")
                    result = firstNumber + secondNumber;

                else if (option == "2")
                    result = firstNumber - secondNumber;

                else if (option == "3")
                    result = firstNumber * secondNumber;

                else if (option == "4")
                    result = firstNumber / secondNumber;

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Resultado: " + result.ToString("F2"));
                Console.WriteLine("----------------------------------\n");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar == "N")
                    break;
            }
        }
    }
}
