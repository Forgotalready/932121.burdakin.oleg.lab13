namespace Lab13.Generator;

public sealed class QuestionGenerator
{
  private readonly List<String> _operations = ["+", "*", "-", "/"];
  
  public Question GenerateQuestion()
  {
    var random = new Random();
    int firstNumber =  random.Next(1, 10);
    int secondNumber = random.Next(1, 10);

    int operationsAmount = _operations.Count;
    String operation = _operations[random.Next(0, operationsAmount)];

    return new Question { FirstNumber = firstNumber, SecondNumber = secondNumber, Operation = operation };
  }
}