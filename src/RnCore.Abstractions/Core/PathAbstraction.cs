using System.Diagnostics.CodeAnalysis;

namespace RnCore.Abstractions;

public interface IPathAbstraction
{
  string GetFullPath(string path);
  string GetFullPath(string path, string basePath);
  ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);
  string? GetFileNameWithoutExtension(string? path);
  string Combine(params string[] paths);
  string Join(params string?[] paths);
}

[ExcludeFromCodeCoverage]
public class PathAbstraction : IPathAbstraction
{
  public string GetFullPath(string path) => Path.GetFullPath(path);
  public string GetFullPath(string path, string basePath) => Path.GetFullPath(path, basePath);
  public ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path) => Path.GetFileNameWithoutExtension(path);
  public string? GetFileNameWithoutExtension(string? path) => Path.GetFileNameWithoutExtension(path);
  public string Combine(params string[] paths) => Path.Combine(paths);
  public string Join(params string?[] paths) => Path.Join(paths);
}
