using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;
using Pattern.Strategy.Pagamentos.Processamentos.Base;

namespace Pattern.Strategy.Pagamentos.Strategy.Processamentos
{
    public class Exclusao : ProcessamentoCadastro
    {
        public Exclusao(IInstrucaoMovimento instrucaoMovimento) : base(instrucaoMovimento)
        {
        }
    }
}