using ConsoleTolyID.ModelCapturas;

namespace ConsoleTolyID;

public class CadastrarDadosGerais
{
    public DadosGerais Cadastrar(){
        DadosGerais dadosGerais = new();
        #region Dados Gerais

            Console.WriteLine("Número de Identificação");
            dadosGerais.NumeroIdentificacao = ValidarCamposService.ValidarInt();

            // Local de Captura
            Console.WriteLine("Local de Captura:");
            dadosGerais.LocalDeCaptura = Console.ReadLine();

            // Equipe Responsável
            Console.WriteLine("Equipe Responsável:");
            dadosGerais.EquipeResponsavel = Console.ReadLine();

            // Instituição
            Console.WriteLine("Instituição:");
            dadosGerais.Instituicao = Console.ReadLine();

            // Peso
            Console.WriteLine("Peso:");
            dadosGerais.Peso = ValidarCamposService.ValidarDouble();

            // Data de Captura
            Console.WriteLine("Data de Captura (dd/mm/yyyy) (Padrão: Data Atual):");
            dadosGerais.DataDeCaptura = ValidarCamposService.ValidarData();


            // Horário de Captura
            Console.WriteLine("Horário de Captura (HH:mm) (Padrão: Hora Atual):");
            dadosGerais.HorarioDeCaptura = ValidarCamposService.ValidarTimeSpan();


            // Contato do Responsável
            Console.WriteLine("Contato do Responsável:");
            dadosGerais.ContatoDoResponsavel = Console.ReadLine();

            // Observações
            Console.WriteLine("Observações (Opcional):");
            dadosGerais.Observacoes = Console.ReadLine();
            #endregion
            return dadosGerais;
    }
}
