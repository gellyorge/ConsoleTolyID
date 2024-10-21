using SQLiteNetExtensionsAsync.Extensions;
using SQLite;
using ConsoleTolyID.ModelCapturas;
using ConsoleTolyID;
using TolyID.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



var usuario = new Usuario
{
    Email = "guilherme@toly.com",
    Senha = "123456"
};

var token = await GerarToken.Gerar(usuario)!;


while (true)
{
    System.Console.WriteLine(token);
    System.Console.WriteLine();
    CapturaView.TelaInicio(await TatuView.TelaInicio());
}
