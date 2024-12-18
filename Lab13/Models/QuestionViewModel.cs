using Lab13.Generator;
namespace Lab13.Models;

public sealed class QuestionViewModel
{
  private Question _question;

  public Question Question
  {
    get => _question;
    set => _question = value;
  }
  
  private int _answer;

  public int Answer
  {
    get => _answer;
    set => _answer = value;
  }
  
  public String ShowQuestion() => _question.ConvertToString();
}