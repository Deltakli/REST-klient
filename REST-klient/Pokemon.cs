using System.Text.Json.Serialization;


public class Pokemon
{
[JsonPropertyName("name")]
public string Name { get; set; }
[JsonPropertyName("weight")]
public int Weight { get; set; }
[JsonPropertyName("is_deafault")]
public bool is_default { get; set; }
}