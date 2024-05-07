using Pattern.Strategy.Sispag.Instrucoes.Interfaces;

namespace Pattern.Strategy.Sispag.Instrucoes
{
    public class AlteracaoDataPagamento : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando a data de pagamento.";
    }
}