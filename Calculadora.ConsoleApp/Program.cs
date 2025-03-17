namespace Calculadora.ConsoleApp;
internal class Program
{
    static int operationsQuantity = 0;
    static string[] history = new string[200];
    static void Main(string[] args)
    {
        bool isGoing = true;
        do
        {
            string option = ShowMenu();

            if (OptionIsExit(option) == true)
                break;

            else if (OptionIsMultiplicationTable(option))
                MultiplicationTable();

            else if (OptionIsHistory(option))
                ShowHistory();

            else if (InvalidOption(option))
                ShowErrorMessage();

            else
                ShowResult(DoCalculation(option),ref isGoing);
        } while (isGoing);
    }
    static string ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Calculadora Tabajara - 2025");
        Console.WriteLine("----------------------------------\n");

        Console.WriteLine("[1] Somar");
        Console.WriteLine("[2] Subtrair");
        Console.WriteLine("[3] Multiplicação");
        Console.WriteLine("[4] Divisão");
        Console.WriteLine("[5] Tabuada");
        Console.WriteLine("[6] Histórico de Operações");
        Console.WriteLine("[S] Sair");

        Console.Write("\nEscolha uma opção: ");

        string option = Console.ReadLine()!.ToUpper();

        return option;
    }
    static bool OptionIsExit(string option)
    {
        bool isTrue = option == "S";
        return isTrue;
    }
    static bool OptionIsMultiplicationTable(string option)
    {
        return option == "5";
    }
    static bool OptionIsHistory(string option)
    {
        return option == "6";
    }
    static bool InvalidOption(string option)
    {
        bool isInvalid = false;
        if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6" && option != "X")
            isInvalid = true;

        return isInvalid;
    }
    static void ShowErrorMessage()
    {
        Console.Write("\nOpção inválida!\n\nPressione <Enter> e tente novamente.");
        Console.ReadKey();
    }
    static decimal DoCalculation(string option)
    {
        Console.Write("Digite o primeiro número: ");
        string firstNumberString = Console.ReadLine()!;
        decimal firstNumber = Convert.ToDecimal(firstNumberString);

        Console.Write("Digite o segundo número: ");
        string secondNumberString = Console.ReadLine()!;
        decimal secondNumber = Convert.ToDecimal(secondNumberString);

        decimal result = 0;
        string sinal = "";

        if (option == "1")
        {
            sinal = "+";
            result = Calculadora.Addition(firstNumber, secondNumber);
        }

        else if (option == "2")
        {
            sinal = "-";
            result = Calculadora.Subtraction(firstNumber, secondNumber);
        }

        else if (option == "3")
        {
            sinal = "*";
            result = Calculadora.Multiplication(firstNumber, secondNumber);
        }

        else if (option == "4")
        {
            while (secondNumber == 0)
            {
                Console.WriteLine($"\nNão é possível dividir {firstNumber} por zero!");

                Console.Write("Digite o segundo número novamente: ");
                secondNumber = Convert.ToDecimal(Console.ReadLine());
            }

            sinal = "/";
            result = Calculadora.Division(firstNumber, secondNumber);
        }

        history[operationsQuantity] = $"{firstNumber} {sinal} {secondNumber} = {Math.Round(result, 2)}";
        operationsQuantity++;

        return result;
    }
    static void ShowResult(decimal result,ref bool isGoing)
    {
        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("Resultado: " + result.ToString("F2"));
        Console.WriteLine("----------------------------------\n");

        Console.Write("Deseja voltar ao menu? (S/N): ");
        string opcaoContinuar = Console.ReadLine()!.ToUpper();

        while (opcaoContinuar != "S" && opcaoContinuar != "N")
        {
            Console.Write("\nOpção inválida!\n\nPressione <Enter> e selecione novamente.");
            Console.Write("\nDeseja continuar? (S/N): ");
            opcaoContinuar = Console.ReadLine()!.ToUpper();
        }
        if (opcaoContinuar == "N")
            isGoing = false;
    }
    static void MultiplicationTable()
    {
        Console.Clear();
        Console.WriteLine("------------------");
        Console.WriteLine("Tabuada até 10");
        Console.WriteLine("------------------\n");

        // usuário digita um número
        Console.Write("Digite um número para gerar a tabuada: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nTabuada de {number} até 10:");

        // calcula a tabuada até o 10 desse numero // para

        for (int i = 1; i <= 10; i++)
        {
            int r = number * i;
            Console.WriteLine($"{number} x {i} = {r}");
        }

        Console.Write("\nPressione <Enter> para voltar ao menu!");
        Console.ReadKey();
    }
    static void ShowHistory()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Histórico de perações realizadas");
        Console.WriteLine("------------------------------------\n");

        for (int i = 0; i < history.Length; i++)
        {
            if (history[0] == null)
            {
                Console.WriteLine("Não foi realizado nenhuma operação.");
                break;
            }
            if (history[i] != null)
            {
                Console.WriteLine(history[i]);
                continue;
            }
            else if (history[i] == null)
            {
                break;
            }

        }

        Console.Write("\nPressione <Enter> para voltar ao menu!");
        Console.ReadKey();
    }
}
