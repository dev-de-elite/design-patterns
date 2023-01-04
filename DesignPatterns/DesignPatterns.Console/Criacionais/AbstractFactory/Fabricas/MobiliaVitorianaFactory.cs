using DesignPatterns.Console.Criacionais.AbstractFactory.Fabricas.Interfaces;
using DesignPatterns.Console.Criacionais.AbstractFactory.Modelos;
using DesignPatterns.Console.Criacionais.AbstractFactory.Modelos.Vitoriana;

namespace DesignPatterns.Console.Criacionais.AbstractFactory.Fabricas;

public class MobiliaVitorianaFactory : IMobiliaFactory
{
    public Cadeira CriarCadeira()
    {
        return new CadeiraVitoriana();
    }

    public MesaCentro CriarMesaCentro()
    {
        return new MesaCentroVitoriana();
    }

    public Sofa CriarSofa()
    {
        return new SofaVitoriana();
    }
}
