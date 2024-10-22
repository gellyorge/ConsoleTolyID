using ConsoleTolyID;
using Microsoft.Extensions.Configuration;

GerarToken gerarToken = new();
string token = await gerarToken.Gerar();

CadastrarTatuApi api = new();
api.CadastrarTatu(await TatuView.TelaInicio(), token);

while (true)
{
    System.Console.WriteLine();
    CapturaView.TelaInicio(await TatuView.TelaInicio());
}
