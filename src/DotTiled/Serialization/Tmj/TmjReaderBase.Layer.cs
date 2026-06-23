using System.Text.Json;
using System.Threading.Tasks;

namespace DotTiled.Serialization.Tmj;

public abstract partial class TmjReaderBase
{
  internal async Task<BaseLayer> ReadLayerAsync(JsonElement element)
  {
    var type = element.GetRequiredProperty<string>("type");

    return type switch
    {
      "tilelayer" => ReadTileLayer(element),
      "objectgroup" => await ReadObjectLayerAsync(element),
      "imagelayer" => ReadImageLayer(element),
      "group" => await ReadGroupAsync(element),
      _ => throw new JsonException($"Unsupported layer type '{type}'.")
    };
  }
}
