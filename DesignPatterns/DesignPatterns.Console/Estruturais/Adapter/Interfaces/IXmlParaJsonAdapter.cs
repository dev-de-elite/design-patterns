using DesignPatterns.Console.Estruturais.Adapter.TipoDados;

namespace DesignPatterns.Console.Estruturais.Adapter.Interfaces;

public interface IXmlParaJsonAdapter
{
    Json Adaptar(Xml xml);
}
