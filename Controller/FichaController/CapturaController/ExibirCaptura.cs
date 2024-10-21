using System.ComponentModel;
using Microsoft.VisualBasic;
using TolyID.Services;

namespace ConsoleTolyID;

public static class ExibirCaptura
{
    public static async void Exibir(Tatu tatu)
    {
        foreach (var item in tatu.Capturas!)
        {
            System.Console.WriteLine(item);
        }

    }
}
