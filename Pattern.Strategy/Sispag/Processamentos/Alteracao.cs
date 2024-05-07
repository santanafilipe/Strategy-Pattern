using Pattern.Strategy.Sispag.Instrucoes.Interfaces;
using Pattern.Strategy.Sispag.Processamentos.Base;

namespace Pattern.Strategy.Sispag.Strategy.Processamentos
{
    public class Alteracao : ProcessamentoCadastro
    {
        public Alteracao(IInstrucaoMovimento instrucaoMovimento) : base(instrucaoMovimento)
        {
        }
    }
}