namespace DesignPatterns.Console.Criacionais.FactoryMethod;

public class LogisticaMaritima : Logistica
{
    public override Logistica CriarTransporte()
    {
        return new LogisticaMaritima();
    }
}
