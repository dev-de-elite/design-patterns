using DesignPatterns.Console.Estruturais.Adapter.Interfaces;
using DesignPatterns.Console.Estruturais.Adapter.TipoDados;

namespace DesignPatterns.Console.Estruturais.Adapter
{
    public class AnaliseAcoes
    {
        private readonly IServicoAnalise _servicoAnalise;
        private readonly IXmlParaJsonAdapter _adapterXmlParaJson;

        public AnaliseAcoes(IServicoAnalise servicoAnalise, IXmlParaJsonAdapter adapter)
        {
            _servicoAnalise = servicoAnalise;
            _adapterXmlParaJson = adapter;
        }

        public void RealizarAnaliseAcoes(Xml dados)
        {
            // Realizar uma série de lógicas com o XML
            // Faz uma análise complementar com o serviço externo
            var dadosEmJson = _adapterXmlParaJson.Adaptar(dados);
            _servicoAnalise.RealizarAnalise(dadosEmJson);
        }
    }
}
