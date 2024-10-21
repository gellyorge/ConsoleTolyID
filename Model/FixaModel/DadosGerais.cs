using SQLite;
namespace ConsoleTolyID.ModelCapturas;

[Table("DadosGerais")]
public class DadosGerais
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public int? NumeroIdentificacao { get; set; }
    public string? LocalDeCaptura { get; set; }
    public string? EquipeResponsavel { get; set; }
    public string? Instituicao { get; set; }
    public double? Peso { get; set; }
    public DateTime DataDeCaptura { get; set; } = DateTime.Now; 
    public TimeSpan HorarioDeCaptura { get; set; } = DateTime.Now.TimeOfDay;
    public string? ContatoDoResponsavel { get; set; }
    public string? Observacoes { get; set; }
}
