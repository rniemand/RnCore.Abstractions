# DirectoryAbstraction

```cs
public interface IDirectoryAbstraction
{
  bool Exists([NotNullWhen(true)] string? path);
  DirectoryInfo CreateDirectory(string path);
  string[] GetFiles(string path);
  string[] GetFiles(string path, string searchPattern);
  string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
  string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
  string[] GetDirectories(string path);
  string[] GetDirectories(string path, string searchPattern);
  string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
  string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
}
```
