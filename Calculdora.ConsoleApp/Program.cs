namespace Calculdora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Calculadora Tabajara - 2025");
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("S - Sair");

            Console.Write("\nEscolha uma opção: ");

            string option = Console.ReadLine().ToUpper();

            if (option == "S")
            {
                return;
            }

            Console.Write("Digite o primeiro número: ");
            string firstNumberString = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberString);

            Console.Write("Digite o segundo número: ");
            string secondNumberString = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberString);

            int result = 0;


            // se / senao / senao se
            if (option == "1")
            {
                result = firstNumber + secondNumber;
            }
            else
            {
                result = firstNumber - secondNumber;
            }

            Console.WriteLine("\n" + result);

            Console.ReadLine();
        }
    }
}
