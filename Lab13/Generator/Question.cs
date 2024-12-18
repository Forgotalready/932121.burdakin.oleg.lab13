namespace Lab13.Generator;
using System;

public sealed class Question
{
  public int FirstNumber { get; set; }
  public int SecondNumber { get; set; }
  public String Operation { get; set; }

  public String ConvertToString()
  {
    return FirstNumber + " " + Operation + " " + SecondNumber;
  }
}