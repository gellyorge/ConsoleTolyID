using System.Runtime.CompilerServices;
using SQLite;
using TolyID.Services;
using ConsoleTolyID.ModelCapturas;

namespace ConsoleTolyID;

public static class CadastrarCaptura
{
    public static async void Cadastrar(Tatu tatu)
    {
        var banco = new CapturaService();
        try
        {
            Captura captura = new();

            captura.Amostras = new CadastrarAmostra().Cadastrar();
            captura.TatuId = tatu.Id;
            captura.DadosGerais = new CadastrarDadosGerais().Cadastrar();
            captura.FichaAnestesica = new CadastrarFichaAnestesica().Cadastrar();
            captura.Biometria = new CadastrarBiometria().Cadastrar();
            captura.Amostras = new CadastrarAmostra().Cadastrar();

            await banco.SalvaCaptura(captura,tatu);
        }
        catch
        {
            
        }
    }
}
