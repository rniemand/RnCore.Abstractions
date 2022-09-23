# FileAbstraction

```cs
public interface IFileAbstraction
{
  bool Exists([NotNullWhen(true)] string? path);
  void Delete(string path);
  void WriteAllText(string path, string? contents);
  void WriteAllText(string path, string? contents, Encoding encoding);
  Task WriteAllTextAsync(string path, string? contents, CancellationToken cancellationToken = default);
  Task WriteAllTextAsync(string path, string? contents, Encoding encoding, CancellationToken cancellationToken = default);
  string ReadAllText(string path);
  string ReadAllText(string path, Encoding encoding);
  Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default);
  Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default);
}
```
