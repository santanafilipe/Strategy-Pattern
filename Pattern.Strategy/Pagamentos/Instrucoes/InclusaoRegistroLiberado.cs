using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;

namespace Pattern.Strategy.Pagamentos.Instrucoes
{
    public class InclusaoRegistroLiberado : IInstrucaoMovimentoInclusao
    {
        public string EfetuarCadastro() => "Incluindo registro com Status Liberado.";
    }
}