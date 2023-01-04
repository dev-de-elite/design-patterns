using DesignPatterns.Console.Criacionais.AbstractFactory.Fabricas.Interfaces;
using DesignPatterns.Console.Criacionais.AbstractFactory.Modelos;
using DesignPatterns.Console.Criacionais.AbstractFactory.Modelos.ArtDeco;

namespace DesignPatterns.Console.Criacionais.AbstractFactory.Fabricas;

public class MobiliaArDecoFactory : IMobiliaFactory
{
    public Cadeira CriarCadeira()
    {
        return new CadeiraArtDeco();
    }

    public MesaCentro CriarMesaCentro()
    {
        return new MesaCentroArtDeco();
    }

    public Sofa CriarSofa()
    {
        return new SofaArtDeco();
    }
}
