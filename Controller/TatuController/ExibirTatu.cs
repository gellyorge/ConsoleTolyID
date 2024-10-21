using TolyID.Services;

namespace ConsoleTolyID;

public static class ExibirTatu
{
    public static async Task<Tatu> Exibir()
    {
        try
        {
            var banco = new TatuService();
            var lista = await banco.GetTatus();
            Dictionary<int, Tatu> dicionario = new Dictionary<int, Tatu>();

            foreach (var item in lista)
            {
                dicionario.Add(item.Id, item);
                System.Console.WriteLine(item);
            }

            if (dicionario.Count == 0) return null;

            System.Console.WriteLine("Digite o ID do tatu para seguir:");
            while (true)
            {
                try
                {
                    int id = ValidarCamposService.ValidarInt();
                    if (dicionario.TryGetValue(id, out var tatu))
                    {
                        return tatu;
                    }
                    else
                    {
                        System.Console.WriteLine("ID não encontrado, tente novamente.");
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }
        catch
        {
            System.Console.WriteLine("Não foi possível selecionar o item");
            return null; // Retorno adicionado para garantir um valor
        }
    }

}
