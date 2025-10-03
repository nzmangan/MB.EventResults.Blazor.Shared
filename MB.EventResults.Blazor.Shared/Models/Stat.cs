namespace MB.EventResults.Blazor.Shared;

public class Stat<T> {
  public T Avarage { get; set; }
  public T Median { get; set; }
  public double? StandardDeviation { get; set; }
  public T Min { get; set; }
  public T Max { get; set; }
  public int Records { get; set; }
  public double Variance { get; set; }
}