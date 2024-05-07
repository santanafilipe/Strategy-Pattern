using Pattern.Strategy.Sispag.Instrucoes.Interfaces;
using Pattern.Strategy.Sispag.Processamentos.Base;

namespace Pattern.Strategy.Sispag.Strategy.Processamentos
{
    public class Inclusao : ProcessamentoCadastro
    {
        public Inclusao(IInstrucaoMovimentoInclusao instrucaoMovimento) : base(instrucaoMovimento)
        {
        }
    }
}