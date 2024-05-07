using Pattern.Strategy.Pagamentos.Instrucoes.Interfaces;

namespace Pattern.Strategy.Pagamentos.Instrucoes
{
    public class AlteracaoBloqueadoParaLiberado : IInstrucaoMovimento
    {
        public string EfetuarCadastro() => "Alterando o status de Bloqueado para LIberado.";
    }
}