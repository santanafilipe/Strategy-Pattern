using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;

namespace Pattern.Strategy.Pagamentos.Instrucoes
{
    public class AlteracaoValor : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando um valor.";
    }
}