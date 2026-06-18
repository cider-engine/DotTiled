using System.IO;
using System.Threading.Tasks;

namespace DotTiled.Serialization;

/// <summary>
/// Uses the underlying host file system to read Tiled resources from a given path.
/// </summary>
public class FileSystemResourceReader : IResourceReader
{
  /// <summary>
  /// Initializes a new instance of the <see cref="FileSystemResourceReader"/> class.
  /// </summary>
  public FileSystemResourceReader() { }

  /// <inheritdoc/>
  public Task<string> ReadAsync(string resourcePath) => File.ReadAllTextAsync(resourcePath);
}
