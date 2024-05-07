using Pattern.Strategy.Sispag.Instrucoes.Interfaces;

namespace Pattern.Strategy.Sispag.Instrucoes
{
    public class AlteracaoValor : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando um valor.";
    }
}