using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora.ConsoleApp;
public static class Calculadora
{
    public static int OperationsQuantity = 0;
    public static string[] History = new string[200];
    public static decimal Addition(decimal firstNumber, decimal secondNumber)
    {
        decimal result = firstNumber + secondNumber;
        return result;
    }
    public static decimal Subtraction(decimal firstNumber, decimal secondNumber)
    {
        decimal result = firstNumber - secondNumber;
        return result;
    }
    public static decimal Multiplication(decimal firstNumber, decimal secondNumber)
    {
        decimal result = firstNumber * secondNumber;
        return result;
    }
    public static decimal Division(decimal firstNumber, decimal secondNumber)
    {
        decimal result = firstNumber / secondNumber;
        return result;
    }
    public static void MultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
    public static void GetHistory(decimal firstNumber, decimal secondNumber, string signal, decimal result)
    {
        
        History[OperationsQuantity] = $"{firstNumber} {signal} {secondNumber} = {Math.Round(result, 2)}";
    }
}
