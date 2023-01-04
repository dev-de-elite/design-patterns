using DesignPatterns.Console.Estruturais.Adapter.Interfaces;
using DesignPatterns.Console.Estruturais.Adapter.TipoDados;

namespace DesignPatterns.Console.Estruturais.Adapter;

public class XmlParaJsonAdapter : IXmlParaJsonAdapter
{
    public Json Adaptar(Xml xml)
    {
        // Realiza a conversão necessária entre os dois tipos incompatíveis
        return new Json
        {
            Nome = xml.Fullname
        };
    }
}
