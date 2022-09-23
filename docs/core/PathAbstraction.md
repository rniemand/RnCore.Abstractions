# PathAbstraction

```cs
public interface IPathAbstraction
{
  string GetFullPath(string path);
  string GetFullPath(string path, string basePath);
  ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);
  string? GetFileNameWithoutExtension(string? path);
}
```
