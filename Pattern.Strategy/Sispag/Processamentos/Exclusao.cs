using Pattern.Strategy.Sispag.Instrucoes.Interfaces;
using Pattern.Strategy.Sispag.Processamentos.Base;

namespace Pattern.Strategy.Sispag.Strategy.Processamentos
{
    public class Exclusao : ProcessamentoCadastro
    {
        public Exclusao(IInstrucaoMovimento instrucaoMovimento) : base(instrucaoMovimento)
        {
        }
    }
}