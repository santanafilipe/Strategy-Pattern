using Pattern.Strategy.Sispag.Instrucoes.Interfaces;
using Pattern.Strategy.Sispag.Processamentos.Interfaces;

namespace Pattern.Strategy.Sispag.Processamentos.Base
{
    public class ProcessamentoCadastro : IProcessamentoCadastro
    {
        private IInstrucaoMovimento _instrucaoMovimento;

        public ProcessamentoCadastro(IInstrucaoMovimento instrucaoMovimento) => _instrucaoMovimento = instrucaoMovimento;

        public string Processar() => _instrucaoMovimento.EfetuarCadastro();
    }
}