namespace Calculadora.ConsoleApp;
public static class Calculadora
{
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
}
