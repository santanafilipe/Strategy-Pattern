using Pattern.Strategy.Sispag.Processamentos.Interfaces;
using Pattern.Strategy.Sispag.Strategy.Processamentos;
using Instrucoes = Pattern.Strategy.Sispag.Instrucoes;

namespace Pattern.StrategyTests;

[Collection("Sispag.StrategyTests")]
public class SispagStrategyTests
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