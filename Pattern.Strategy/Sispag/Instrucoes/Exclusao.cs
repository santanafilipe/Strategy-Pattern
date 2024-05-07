using Pattern.Strategy.Sispag.Instrucoes.Interfaces;

namespace Pattern.Strategy.Sispag.Instrucoes
{
    public class Exclusao : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Excluindo um registro.";
    }
}