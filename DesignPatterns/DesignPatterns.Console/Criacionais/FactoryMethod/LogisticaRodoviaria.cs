namespace DesignPatterns.Console.Criacionais.FactoryMethod;

public class LogisticaRodoviaria : Logistica
{
    public override Logistica CriarTransporte()
    {
        return new LogisticaRodoviaria();
    }
}
