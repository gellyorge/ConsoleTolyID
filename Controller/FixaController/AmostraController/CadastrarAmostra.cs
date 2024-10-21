using ConsoleTolyID.ModelCapturas;

namespace ConsoleTolyID;

public class CadastrarAmostra
{
    public Amostras Cadastrar(){

         #region Amostras
            Amostras amostra = new();
            System.Console.WriteLine("Sangue");
            amostra.Sangue = ValidarCamposService.ValidarBool();

            System.Console.WriteLine("Fezes");
            amostra.Fezes = ValidarCamposService.ValidarBool();

            System.Console.WriteLine("Pelo");
            amostra.Pelo = ValidarCamposService.ValidarBool();

            System.Console.WriteLine("Ectoparasitas");
            amostra.Ectoparasitos = ValidarCamposService.ValidarBool();

            System.Console.WriteLine("Swab");
            amostra.Swab = ValidarCamposService.ValidarBool();

            System.Console.WriteLine("Local");
            amostra.Local = ValidarCamposService.ValidarBool();

            System.Console.WriteLine("Outros");
            amostra.Outros = System.Console.ReadLine();
            #endregion
           return amostra;
    }
}
