using SQLite;
using Newtonsoft.Json;
namespace ConsoleTolyID;

[Table("Usuario")]
public class Usuario
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [JsonProperty("email")]
    public string? Email { get; set; }
    [JsonProperty("senha")] 
    public string? Senha { get; set; }
}
