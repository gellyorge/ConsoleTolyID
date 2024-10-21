
using SQLite;
using SQLiteNetExtensions.Attributes;
using ConsoleTolyID.ModelCapturas;
namespace ConsoleTolyID;

[Table("Tatu")]
public class Tatu
{
   [PrimaryKey, AutoIncrement]
   public int Id { get; set; }
   public string? IdentificacaoAnimal { get; set; }
   public int NumeroMicrochip { get; set; }

   [OneToMany(CascadeOperations = CascadeOperation.All)]
   public List<Captura>? Capturas { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\nIdentificacao do Animal: {IdentificacaoAnimal}\nNumero do Microchip: {NumeroMicrochip}\n";
    }
}
