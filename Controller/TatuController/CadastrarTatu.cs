using TolyID.Services;
namespace ConsoleTolyID;

public static class CadastrarTatu
{
    public static async Task<Tatu> Cadastrar()
    {
        var tatu = new TatuService();
        Tatu novoTatu = new();

        try
        {
            Console.WriteLine("Digite a identificação do animal:");
            novoTatu.IdentificacaoAnimal = Console.ReadLine();

            Console.WriteLine("Digite o número do microchip:");
            novoTatu.NumeroMicrochip = int.Parse(Console.ReadLine()!);
            
            await tatu.SalvaTatu(novoTatu);
            System.Console.WriteLine("Tatu Cadastrado com Sucesso!");
            return novoTatu;
        }
        catch
        {
            Console.Clear();
            System.Console.WriteLine("Digite Dados Validos!");
            return await Cadastrar();
        }
    }
}
