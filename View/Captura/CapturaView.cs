namespace ConsoleTolyID;

public static class CapturaView
{
    public static void TelaInicio(Tatu tatu)
    {
        try
        {
            System.Console.WriteLine("1- Cadastrar Capturas\n2- Exibir Capturas");
            switch (System.Console.ReadLine())
            {
                case "1":
                    CadastrarCaptura.Cadastrar(tatu);
                    TelaInicio(tatu);
                    break;
                case "2":
                    ExibirCaptura.Exibir(tatu);
                    break;
                default:
                    TelaInicio(tatu);
                    break;
            }
        }
        catch
        {

        }

    }
}
