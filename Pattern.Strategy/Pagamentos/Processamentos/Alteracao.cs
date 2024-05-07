using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;
using Pattern.Strategy.Pagamentos.Processamentos.Base;

namespace Pattern.Strategy.Pagamentos.Strategy.Processamentos
{
    public class Alteracao : ProcessamentoCadastro
    {
        public Alteracao(IInstrucaoMovimento instrucaoMovimento) : base(instrucaoMovimento)
        {
        }
    }
}