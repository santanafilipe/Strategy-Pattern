using Pattern.Strategy.Sispag.Instrucoes.Interfaces;

namespace Pattern.Strategy.Sispag.Instrucoes
{
    public class AlteracaoLiberadoParaBloqueado : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando o status de Liberado para Bloqueado.";
    }
}