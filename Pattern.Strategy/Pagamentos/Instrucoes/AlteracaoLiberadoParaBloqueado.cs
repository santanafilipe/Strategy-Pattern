using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;

namespace Pattern.Strategy.Pagamentos.Instrucoes
{
    public class AlteracaoLiberadoParaBloqueado : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando o status de Liberado para Bloqueado.";
    }
}