namespace Lab13.Services;

public sealed class CalculationService
{
  public int Calculate(int firstNumber, int secondNumber, String operation)
  {
    return operation switch
    { 
        "+" => firstNumber + secondNumber,
        "-" => firstNumber - secondNumber,
        "/" => firstNumber / secondNumber,
        "*" => firstNumber * secondNumber
    };
  }
}