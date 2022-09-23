using System.Diagnostics.CodeAnalysis;

namespace RnCore.Abstractions;

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

[ExcludeFromCodeCoverage]
public class DirectoryAbstraction : IDirectoryAbstraction
{
  public bool Exists(string? path) => Directory.Exists(path);
  public DirectoryInfo CreateDirectory(string path) => Directory.CreateDirectory(path);
  public string[] GetFiles(string path) => Directory.GetFiles(path);
  public string[] GetFiles(string path, string searchPattern) => Directory.GetFiles(path, searchPattern);
  public string[] GetFiles(string path, string searchPattern, SearchOption searchOption) =>
    Directory.GetFiles(path, searchPattern, searchOption);
  public string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
    Directory.GetFiles(path, searchPattern, enumerationOptions);
  public string[] GetDirectories(string path) => Directory.GetDirectories(path);
  public string[] GetDirectories(string path, string searchPattern) => Directory.GetDirectories(path, searchPattern);
  public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption) =>
    Directory.GetDirectories(path, searchPattern, searchOption);
  public string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
    Directory.GetDirectories(path, searchPattern, enumerationOptions);
}
