using Pattern.Strategy.Sispag.Instrucoes.Interfaces;

namespace Pattern.Strategy.Sispag.Instrucoes
{
    public class InclusaoRegistroLiberado : IInstrucaoMovimentoInclusao
    {
        public string EfetuarCadastro() => "Incluindo registro com Status Liberado.";
    }
}