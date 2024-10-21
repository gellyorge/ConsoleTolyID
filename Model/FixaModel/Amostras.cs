using SQLite;
namespace ConsoleTolyID.ModelCapturas;

[Table("Amostras")]
public class Amostras
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public bool Sangue { get; set; }
    public bool Fezes { get; set; }
    public bool Pelo { get; set; }
    public bool Ectoparasitos { get; set; }
    public bool Swab { get; set; }
    public bool Local { get; set; }
    public string? Outros { get; set; }
}
