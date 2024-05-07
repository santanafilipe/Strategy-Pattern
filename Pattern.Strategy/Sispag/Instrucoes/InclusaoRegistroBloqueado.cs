using Pattern.Strategy.Sispag.Instrucoes.Interfaces;

namespace Pattern.Strategy.Sispag.Instrucoes
{
    public class InclusaoRegistroBloqueado : IInstrucaoMovimentoInclusao
    {
        public string EfetuarCadastro() => "Incluindo registro com status Bloqueado.";
    }
}