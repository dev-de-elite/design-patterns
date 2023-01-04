using DesignPatterns.Console.Criacionais.AbstractFactory.Fabricas.Interfaces;
using DesignPatterns.Console.Criacionais.AbstractFactory.Modelos;
using DesignPatterns.Console.Criacionais.AbstractFactory.Modelos.Moderna;

namespace DesignPatterns.Console.Criacionais.AbstractFactory.Fabricas;

public class MobiliaModernaFactory : IMobiliaFactory
{
    public Cadeira CriarCadeira()
    {
        return new CadeiraModerna();
    }

    public MesaCentro CriarMesaCentro()
    {
        return new MesaCentroModerna();
    }

    public Sofa CriarSofa()
    {
        return new SofaModerna();
    }
}
