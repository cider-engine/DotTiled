using System;
using System.Threading.Tasks;
using System.Xml;

namespace DotTiled.Serialization.Tmx;

/// <summary>
/// A tileset reader for the Tiled XML format.
/// </summary>
public class TsxTilesetReader : TmxReaderBase, ITilesetReader
{
  /// <summary>
  /// Constructs a new <see cref="TsxTilesetReader"/>.
  /// </summary>
  /// <inheritdoc />
  public TsxTilesetReader(
    XmlReader reader,
    Func<string, Task<Tileset>> externalTilesetResolver,
    Func<string, Task<Template>> externalTemplateResolver,
    Func<string, Optional<ICustomTypeDefinition>> customTypeResolver) : base(
      reader, externalTilesetResolver, externalTemplateResolver, customTypeResolver)
  { }

  /// <inheritdoc/>
  public Tileset ReadTileset() => ReadTilesetAsync().GetAwaiter().GetResult();

  /// <inheritdoc/>
  public Task<Tileset> ReadTilesetAsync() => base.ReadTilesetAsync();
}
