using SQLite;
using SQLiteNetExtensions.Attributes;
namespace ConsoleTolyID;

[Table("FichaAnestesica")]
public class FichaAnestesica
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string? TipoAnestesicoOuDose { get; set; }
    public string? ViaDeAdministracao { get; set; }
    public TimeSpan Aplicacao { get; set; } = new();
    public TimeSpan Inducao { get; set; } = new();
    public TimeSpan Retorno { get; set; } = new();

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<ParametroFisiologico> ParametrosFisiologicos { get; set; }

    public FichaAnestesica()
    {
        ParametrosFisiologicos = new List<ParametroFisiologico>();
    }
}
