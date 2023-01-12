using Newtonsoft.Json;

namespace RnCore.Abstractions;

public interface IJsonHelper
{
  T? DeserializeObject<T>(string value);
  string SerializeObject(object? value);
  string SerializeObject(object? value, bool prettyPrint);
}

public class JsonHelper : IJsonHelper
{
  public T? DeserializeObject<T>(string value) =>
    JsonConvert.DeserializeObject<T>(value);

  public string SerializeObject(object? value) =>
    SerializeObject(value, false);

  public string SerializeObject(object? value, bool prettyPrint) =>
    JsonConvert.SerializeObject(value, prettyPrint ? Formatting.Indented : Formatting.None);
}
