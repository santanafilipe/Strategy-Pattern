using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;
using Pattern.Strategy.Pagamentos.Processamentos.Base;

namespace Pattern.Strategy.Pagamentos.Strategy.Processamentos
{
    public class Inclusao : ProcessamentoCadastro
    {
        public Inclusao(IInstrucaoMovimentoInclusao instrucaoMovimento) : base(instrucaoMovimento)
        {
        }
    }
}