using ConsoleTolyID.ModelCapturas;

namespace ConsoleTolyID;

public class CadastrarBiometria
{
    public Biometria Cadastrar()
    {
        Biometria biometria = new();
        #region Biometria

        // Comprimento Total
        Console.WriteLine("Comprimento Total:");
        biometria.ComprimentoTotal = ValidarCamposService.ValidarDouble();

        // Comprimento da Cabeça
        Console.WriteLine("Comprimento da Cabeça:");
        biometria.ComprimentoDaCabeca = ValidarCamposService.ValidarDouble();

        // Largura da Cabeça
        Console.WriteLine("Largura da Cabeça:");
        biometria.LarguraDaCabeca = ValidarCamposService.ValidarDouble();

        // Padrão do Escudo Cefálico
        Console.WriteLine("Padrão do Escudo Cefálico:");
        biometria.PadraoEscudoCefalico = Console.ReadLine();

        // Comprimento do Escudo Cefálico
        Console.WriteLine("Comprimento do Escudo Cefálico:");
        biometria.ComprimentoEscudoCefalico = ValidarCamposService.ValidarDouble();

        // Largura do Escudo Cefálico
        Console.WriteLine("Largura do Escudo Cefálico:");
        biometria.LarguraEscudoCefalico = ValidarCamposService.ValidarDouble();

        // Largura Interorbital
        Console.WriteLine("Largura Interorbital:");
        biometria.LarguraInterOrbital = ValidarCamposService.ValidarDouble();

        // Largura Interlacrimal
        Console.WriteLine("Largura Interlacrimal:");
        biometria.LarguraInterLacrimal = ValidarCamposService.ValidarDouble();

        // Comprimento da Orelha
        Console.WriteLine("Comprimento da Orelha:");
        biometria.ComprimentoDaOrelha = ValidarCamposService.ValidarDouble();

        // Comprimento da Cauda
        Console.WriteLine("Comprimento da Cauda:");
        biometria.ComprimentoDaCauda = ValidarCamposService.ValidarDouble();

        // Largura da Cauda
        Console.WriteLine("Largura da Cauda:");
        biometria.LarguraDaCauda = ValidarCamposService.ValidarDouble();

        // Comprimento do Escudo Escapular
        Console.WriteLine("Comprimento do Escudo Escapular:");
        biometria.ComprimentoEscudoEscapular = ValidarCamposService.ValidarDouble();

        // Semicircunferência do Escudo Escapular
        Console.WriteLine("Semicircunferência do Escudo Escapular:");
        biometria.SemicircunferenciaEscudoEscapular = ValidarCamposService.ValidarDouble();

        // Comprimento do Escudo Pélvico
        Console.WriteLine("Comprimento do Escudo Pélvico:");
        biometria.ComprimentoEscudoPelvico = ValidarCamposService.ValidarDouble();

        // Semicircunferência do Escudo Pélvico
        Console.WriteLine("Semicircunferência do Escudo Pélvico:");
        biometria.SemicircunferenciaEscudoPelvico = ValidarCamposService.ValidarDouble();

        // Largura na Segunda Cinta
        Console.WriteLine("Largura na Segunda Cinta:");
        biometria.LarguraNaSegundaCinta = ValidarCamposService.ValidarDouble();

        // Número de Cintas
        Console.WriteLine("Número de Cintas:");
        biometria.NumeroDeCintas = ValidarCamposService.ValidarInt();

        // Comprimento da Mão Sem Unha
        Console.WriteLine("Comprimento da Mão Sem Unha:");
        biometria.ComprimentoMaoSemUnha = ValidarCamposService.ValidarDouble();

        // Comprimento da Unha da Mão
        Console.WriteLine("Comprimento da Unha da Mão:");
        biometria.ComprimentoUnhaDaMao = ValidarCamposService.ValidarDouble();

        // Comprimento do Pé Sem Unha
        Console.WriteLine("Comprimento do Pé Sem Unha:");
        biometria.ComprimentoPeSemUnha = ValidarCamposService.ValidarDouble();

        // Comprimento da Unha do Pé
        Console.WriteLine("Comprimento da Unha do Pé:");
        biometria.ComprimentoUnhaDoPe = ValidarCamposService.ValidarDouble();

        // Comprimento do Pênis
        Console.WriteLine("Comprimento do Pênis:");
        biometria.ComprimentoDoPenis = ValidarCamposService.ValidarDouble();

        // Largura da Base do Pênis
        Console.WriteLine("Largura da Base do Pênis:");
        biometria.LarguraBasePenis = ValidarCamposService.ValidarDouble();

        // Comprimento do Clitóris
        Console.WriteLine("Comprimento do Clitóris:");
        biometria.ComprimentoDoClitoris = ValidarCamposService.ValidarDouble();

        #endregion
        return biometria;
    }
}
