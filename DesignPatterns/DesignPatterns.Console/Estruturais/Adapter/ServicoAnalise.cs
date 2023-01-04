using DesignPatterns.Console.Estruturais.Adapter.Interfaces;
using DesignPatterns.Console.Estruturais.Adapter.TipoDados;

namespace DesignPatterns.Console.Estruturais.Adapter;

public class ServicoAnalise : IServicoAnalise
{
    public void RealizarAnalise(Json dados)
    {
        // Consulta uma API externa que recebe Json
    }
}
