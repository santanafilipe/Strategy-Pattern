using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;

namespace Pattern.Strategy.Pagamentos.Instrucoes
{
    public class Exclusao : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Excluindo um registro.";
    }
}