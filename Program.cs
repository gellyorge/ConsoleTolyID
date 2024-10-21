using SQLiteNetExtensionsAsync.Extensions;
using SQLite;
using ConsoleTolyID.ModelCapturas;
using ConsoleTolyID;
using TolyID.Services;

while (true)
{

    System.Console.WriteLine("1-Cadastrar Tatu");
    System.Console.WriteLine("2-Listar Tatu");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            CadastrarTatu.Cadastrar();
            break;

        case "2":
            Console.Clear();
            await ExibirTatu.Exibir();
            break;
            
        default:
            Console.Clear();
            System.Console.WriteLine("Digite um Numero valido!");
            break;
    }


}
