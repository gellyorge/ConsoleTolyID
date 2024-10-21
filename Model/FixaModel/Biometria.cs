﻿
using SQLite;
namespace ConsoleTolyID.ModelCapturas;

[Table("Biometrias")]
public class Biometria
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public double? ComprimentoTotal { get; set; }
    public double? ComprimentoDaCabeca { get; set; }
    public double? LarguraDaCabeca { get; set; }
    public string? PadraoEscudoCefalico { get; set; }
    public double? ComprimentoEscudoCefalico { get; set; }
    public double? LarguraEscudoCefalico { get; set; }
    public double? LarguraInterOrbital { get; set; }
    public double? LarguraInterLacrimal { get; set; }
    public double? ComprimentoDaOrelha { get; set; }
    public double? ComprimentoDaCauda { get; set; }
    public double? LarguraDaCauda { get; set; }
    public double? ComprimentoEscudoEscapular { get; set; }
    public double? SemicircunferenciaEscudoEscapular { get; set; }
    public double? ComprimentoEscudoPelvico { get; set; }
    public double? SemicircunferenciaEscudoPelvico { get; set; }
    public double? LarguraNaSegundaCinta { get; set; }
    public int? NumeroDeCintas { get; set; }
    public double? ComprimentoMaoSemUnha { get; set; }
    public double? ComprimentoUnhaDaMao { get; set; }
    public double? ComprimentoPeSemUnha { get; set; }
    public double? ComprimentoUnhaDoPe { get; set; }
    public double? ComprimentoDoPenis { get; set; }
    public double? LarguraBasePenis { get; set; }
    public double? ComprimentoDoClitoris { get; set; }
}
