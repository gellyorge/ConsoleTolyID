using SQLite;
using SQLiteNetExtensions.Attributes;
namespace ConsoleTolyID;


[Table("ParametroFisiologico")]
public class ParametroFisiologico
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [ForeignKey(typeof(FichaAnestesica))]
    public int FichaAnestesicaId { get; set; }
    public double? Fc { get; set; }
    public double? Fr { get; set; }
    public double? Oximetria { get; set; }
    public double? Temperatura { get; set; }
}
