using ConsoleTolyID.ModelCapturas;

namespace ConsoleTolyID;

public class CadastrarParametroFisiologico
{
    public ParametroFisiologico Cadastrar(){
        ParametroFisiologico parametroFisiologico = new();

        #region Parametros Fisiologicos
        System.Console.WriteLine("FC");
        parametroFisiologico.Fc = ValidarCamposService.ValidarDouble();
        System.Console.WriteLine("FR");
        parametroFisiologico.Fr = ValidarCamposService.ValidarDouble();
        System.Console.WriteLine("Oximetria");
        parametroFisiologico.Oximetria = ValidarCamposService.ValidarDouble();
        System.Console.WriteLine("Temperatura");
        parametroFisiologico.Temperatura = ValidarCamposService.ValidarDouble();
        #endregion
        
        return parametroFisiologico;
    }
}
