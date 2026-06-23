using System;
using System.Threading.Tasks;
using System.Xml;

namespace DotTiled.Serialization.Tmx;

/// <summary>
/// A template reader for the Tiled XML format.
/// </summary>
public class TxTemplateReader : TmxReaderBase, ITemplateReader
{
  /// <summary>
  /// Constructs a new <see cref="TxTemplateReader"/>.
  /// </summary>
  /// <inheritdoc />
  public TxTemplateReader(
    XmlReader reader,
    Func<string, Task<Tileset>> externalTilesetResolver,
    Func<string, Task<Template>> externalTemplateResolver,
    Func<string, Optional<ICustomTypeDefinition>> customTypeResolver) : base(
      reader, externalTilesetResolver, externalTemplateResolver, customTypeResolver)
  { }

  /// <inheritdoc/>
  public Template ReadTemplate() => ReadTemplateAsync().GetAwaiter().GetResult();

  /// <inheritdoc/>
  public new Task<Template> ReadTemplateAsync() => base.ReadTemplateAsync();
}
