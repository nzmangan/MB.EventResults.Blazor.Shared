using System.Text;

namespace MB.EventResults.Blazor.Shared;

public static class XmlHelper {
  public static async Task<bool> IsOfXmlType<T>(this IXmlSerializerService xmlSerializerService, Stream content) where T : class {
    try {
      content.Position = 0;
      return (await xmlSerializerService.Deserialize<T>(() => content)) is not null;
    } catch {
      return false;
    }
  }

  public static async Task<bool> IsOfXmlType<T>(this IXmlSerializerService xmlSerializerService, string content) where T : class {
    try {
      using MemoryStream ms = new(Encoding.UTF8.GetBytes(content));
      return (await xmlSerializerService.Deserialize<T>(() => ms)) is not null;
    } catch {
      return false;
    }
  }
}