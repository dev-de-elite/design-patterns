using DesignPatterns.Console.Criacionais.AbstractFactory.Modelos;

namespace DesignPatterns.Console.Criacionais.AbstractFactory.Fabricas.Interfaces;

public interface IMobiliaFactory
{
    Cadeira CriarCadeira();
    Sofa CriarSofa();
    MesaCentro CriarMesaCentro();
}
