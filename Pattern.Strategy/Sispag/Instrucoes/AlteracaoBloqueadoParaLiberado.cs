using Pattern.Strategy.Sispag.Instrucoes.Interfaces;

namespace Pattern.Strategy.Sispag.Instrucoes
{
    public class AlteracaoBloqueadoParaLiberado : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando o status de Bloqueado para LIberado.";
    }
}