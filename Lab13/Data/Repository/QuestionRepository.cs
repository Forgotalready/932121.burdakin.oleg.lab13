using Lab13.Generator;
using Lab13.Services;

namespace Lab13.Data.Repository;

public class QuestionRepository(CalculationService _calculationService)
{
  private readonly Dictionary<Question, int> _answers = new();
  private int _rightAnswersCounter = 0;

  public IEnumerable<KeyValuePair<Question, int>> GetData => _answers;

  public int RightAnswers
  {
    get => _rightAnswersCounter;
    private set => _rightAnswersCounter = value;
  }

  public void InsertUserAnswer(Question question, int userAnswer)
  {
    int rightAnswer = _calculationService.Calculate(question.FirstNumber, question.SecondNumber, question.Operation);
    if (rightAnswer == userAnswer)
    {
      _rightAnswersCounter++;
    }

    _answers.Add(question, userAnswer);
  }
}