using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;
using Pattern.Strategy.Pagamentos.Processamentos.Interfaces;

namespace Pattern.Strategy.Pagamentos.Processamentos.Base
{
    public class ProcessamentoCadastro : IProcessamentoCadastro
    {
        private IInstrucaoMovimento _instrucaoMovimento;

        public ProcessamentoCadastro(IInstrucaoMovimento instrucaoMovimento) => _instrucaoMovimento = instrucaoMovimento;

        public string Processar() => _instrucaoMovimento.EfetuarCadastro();
    }
}