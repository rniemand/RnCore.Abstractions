using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace RnCore.Abstractions;

public interface IEnvironmentAbstraction
{
  string CommandLine { get; }
  string CurrentDirectory { get; }
  bool HasShutdownStarted { get; }
  bool Is64BitOperatingSystem { get; }
  bool Is64BitProcess { get; }
  string NewLine { get; }
  OperatingSystem OSVersion { get; }
  int ProcessId { get; }
  int ProcessorCount { get; }
  string? ProcessPath { get; }
  string StackTrace { get; }
  Version Version { get; }

  string ExpandEnvironmentVariables(string name);
  string? GetEnvironmentVariable(string variable);
  string? GetEnvironmentVariable(string variable, EnvironmentVariableTarget target);
  IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target);
  string GetFolderPath(Environment.SpecialFolder folder);
  string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option);
  void SetEnvironmentVariable(string variable, string? value);
  void SetEnvironmentVariable(string variable, string? value, EnvironmentVariableTarget target);
}

[ExcludeFromCodeCoverage]
public class EnvironmentAbstraction : IEnvironmentAbstraction
{
  public string CommandLine => Environment.CommandLine;
  public string CurrentDirectory => Environment.CurrentDirectory;
  public bool HasShutdownStarted => Environment.HasShutdownStarted;
  public bool Is64BitOperatingSystem => Environment.Is64BitOperatingSystem;
  public bool Is64BitProcess => Environment.Is64BitProcess;
  public string NewLine => Environment.NewLine;
  public OperatingSystem OSVersion => Environment.OSVersion;
  public int ProcessId => Environment.ProcessId;
  public int ProcessorCount => Environment.ProcessorCount;
  public string? ProcessPath => Environment.ProcessPath;
  public string StackTrace => Environment.StackTrace;
  public Version Version => Environment.Version;
  public string ExpandEnvironmentVariables(string name) => Environment.ExpandEnvironmentVariables(name);
  public string? GetEnvironmentVariable(string variable) => Environment.GetEnvironmentVariable(variable);
  public string? GetEnvironmentVariable(string variable, EnvironmentVariableTarget target) => Environment.GetEnvironmentVariable(variable, target);
  public IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target) => Environment.GetEnvironmentVariables(target);
  public string GetFolderPath(Environment.SpecialFolder folder) => Environment.GetFolderPath(folder);
  public string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) => Environment.GetFolderPath(folder, option);

  public void SetEnvironmentVariable(string variable, string? value) =>
    Environment.SetEnvironmentVariable(variable, value);

  public void SetEnvironmentVariable(string variable, string? value, EnvironmentVariableTarget target) =>
    Environment.SetEnvironmentVariable(variable, value, target);
}
