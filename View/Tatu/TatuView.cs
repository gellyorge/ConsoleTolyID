namespace ConsoleTolyID;

public static class TatuView
{
    public async static Task<Tatu> TelaInicio()
    {
            System.Console.WriteLine("1-Cadastrar Tatu");
            System.Console.WriteLine("2-Listar Tatu");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    return await CadastrarTatu.Cadastrar();
                    
                case "2":
                    Console.Clear();
                    return await ExibirTatu.Exibir();

                default:
                    Console.Clear();
                    System.Console.WriteLine("Digite um Numero valido!");
                    return await TelaInicio();
            }
    }
}
