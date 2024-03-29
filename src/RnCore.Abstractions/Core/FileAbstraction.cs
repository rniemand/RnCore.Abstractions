using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RnCore.Abstractions;

public interface IFileAbstraction
{
  void Copy(string sourceFileName, string destFileName);
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
  void Move(string sourceFileName, string destFileName);
  void Move(string sourceFileName, string destFileName, bool overwrite);
}

[ExcludeFromCodeCoverage]
public class FileAbstraction : IFileAbstraction
{
  public void Copy(string sourceFileName, string destFileName) => File.Copy(sourceFileName, destFileName);
  public bool Exists(string? path) => File.Exists(path);
  public void Delete(string path) => File.Delete(path);
  public void WriteAllText(string path, string? contents) => File.WriteAllText(path, contents);
  public void WriteAllText(string path, string? contents, Encoding encoding) => File.WriteAllText(path, contents, encoding);
  public Task WriteAllTextAsync(string path, string? contents, CancellationToken cancellationToken = default) => File.WriteAllTextAsync(path, contents, cancellationToken);
  public Task WriteAllTextAsync(string path, string? contents, Encoding encoding, CancellationToken cancellationToken = default) => File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
  public string ReadAllText(string path) => File.ReadAllText(path);
  public string ReadAllText(string path, Encoding encoding) => File.ReadAllText(path, encoding);
  public Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default) => File.ReadAllTextAsync(path, cancellationToken);
  public Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default) => File.ReadAllTextAsync(path, encoding, cancellationToken);
  public void Move(string sourceFileName, string destFileName) => File.Move(sourceFileName, destFileName);
  public void Move(string sourceFileName, string destFileName, bool overwrite) => File.Move(sourceFileName, destFileName, overwrite);
}
