namespace Calculdora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tabajara - 2025\n");

            Console.Write("Digite o primeiro número: ");
            string firstNumberString = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberString);

            Console.Write("Digite o segundo número: ");
            string secondNumberString = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberString);

            int result = firstNumber + secondNumber;

            Console.WriteLine("\nA soma desses número é: " + result);

            Console.ReadKey();
        }
    }
}
