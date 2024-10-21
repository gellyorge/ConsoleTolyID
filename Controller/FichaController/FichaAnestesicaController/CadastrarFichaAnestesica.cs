namespace ConsoleTolyID;

public class CadastrarFichaAnestesica
{
    public FichaAnestesica Cadastrar(){

        FichaAnestesica fichaA = new();
        #region Ficha Anestesica
            System.Console.WriteLine("Tipo Anestesico ou Dose");
            fichaA.TipoAnestesicoOuDose = System.Console.ReadLine();

            System.Console.WriteLine("Via de Administracao");
            fichaA.ViaDeAdministracao = System.Console.ReadLine();

            System.Console.WriteLine("Aplicacao");
            fichaA.Aplicacao = ValidarCamposService.ValidarTimeSpan();

            System.Console.WriteLine("Inducao");
            fichaA.Inducao = ValidarCamposService.ValidarTimeSpan();

            System.Console.WriteLine("Retorno");
            fichaA.Retorno = ValidarCamposService.ValidarTimeSpan();

            System.Console.WriteLine("Parametros Fisiologicos");

            while(System.Console.ReadLine() == "s"){
                System.Console.WriteLine("Digite 's' para Adicionar um Parametro Fisiologico ou qualquer tecla para sair ");
                
                ParametroFisiologico parametro = new CadastrarParametroFisiologico().Cadastrar();
                fichaA.ParametrosFisiologicos.Add(parametro);
            }
        
            #endregion
        
        return fichaA;
    }
}
