using Pattern.Strategy.Pagamentos.Processamentos.Interfaces;
using Pattern.Strategy.Pagamentos.Strategy.Processamentos;
using Instrucoes = Pattern.Strategy.Pagamentos.Instrucoes;

namespace Pattern.StrategyTests;

[Collection("Pagamentos.StrategyTests")]
public class PagamentosStrategyTests
{
    [Fact]
    public void ShouldReturnIInstrucaoMovimento()
    {
        IProcessamentoCadastro inclusao = new Inclusao(new Instrucoes.InclusaoRegistroLiberado());
        IProcessamentoCadastro alteracao = new Alteracao(new Instrucoes.AlteracaoBloqueadoParaLiberado());
        IProcessamentoCadastro exclusao = new Exclusao(new Instrucoes.Exclusao());

        Assert.Equal(new Instrucoes.InclusaoRegistroLiberado().EfetuarCadastro(),inclusao.Processar());
        Assert.Equal(new Instrucoes.AlteracaoBloqueadoParaLiberado().EfetuarCadastro(), alteracao.Processar());
        Assert.Equal(new Instrucoes.Exclusao().EfetuarCadastro(),exclusao.Processar());
    }
}