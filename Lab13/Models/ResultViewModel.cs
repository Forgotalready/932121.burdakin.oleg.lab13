using Lab13.Generator;

namespace Lab13.Models;

public sealed class ResultViewModel
{
  public int CorrectAnswersAmount { get; set; }
  public IEnumerable<KeyValuePair<Question, int>> Data { get; set; }
  public int AnswersAmount => Data.Count();
}