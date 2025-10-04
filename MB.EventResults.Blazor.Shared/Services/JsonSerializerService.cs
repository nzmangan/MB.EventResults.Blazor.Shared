namespace MB.EventResults.Blazor.Shared;

public class JsonSerializerService : IJsonSerializerService {
  private static readonly JsonSerializerOptions _Options = new() { WriteIndented = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

  public T Deserialize<T>(string content) {

    return JsonSerializer.Deserialize<T>(content, _Options);
  }

  public string Serialize<T>(T input) {
    return JsonSerializer.Serialize(input, _Options);
  }
}