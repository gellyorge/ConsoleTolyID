using SQLite;
namespace ConsoleTolyID;

[Table("Usuario")]
public class Usuario
{
    [PrimaryKey, AutoIncrement]
    public int Id {get; set;}
    public string? Email{get; set;}
    public string? Senha{get; set;}
}
