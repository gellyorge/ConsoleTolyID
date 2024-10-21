using TolyID.Services;

namespace ConsoleTolyID;

public static class ExibirTatu
{
    public static async Task Exibir()
    {
        try
        {
            var banco = new TatuService();
            var lista = await banco.GetTatus();

            foreach (var item in lista)
            {
                System.Console.WriteLine(item);
            }
        }
        catch
        {
            System.Console.WriteLine("Nao foi possivel Exibir os Itens!");
        }
    }

}
