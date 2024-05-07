using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;

namespace Pattern.Strategy.Pagamentos.Instrucoes
{
    public class InclusaoRegistroBloqueado : IInstrucaoMovimentoInclusao
    {
        public string EfetuarCadastro() => "Incluindo registro com status Bloqueado.";
    }
}