using System.Text.Json;
using System.Threading.Tasks;

namespace DotTiled.Serialization.Tmj;

public abstract partial class TmjReaderBase
{
  internal async Task<Template> ReadTemplate(JsonElement element)
  {
    var type = element.GetRequiredProperty<string>("type");
    var tileset = await element.GetOptionalPropertyCustomAsync<Tileset>("tileset", e => ReadTilesetAsync(e));
    var @object = await element.GetRequiredPropertyCustomAsync<DotTiled.Object>("object", ReadObjectAsync);

    return new Template
    {
      Tileset = tileset,
      Object = @object
    };
  }
}
