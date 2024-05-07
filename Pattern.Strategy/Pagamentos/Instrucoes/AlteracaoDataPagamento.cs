using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;

namespace Pattern.Strategy.Pagamentos.Instrucoes
{
    public class AlteracaoDataPagamento : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando a data de pagamento.";
    }
}