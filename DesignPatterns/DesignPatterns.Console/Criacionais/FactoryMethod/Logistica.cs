namespace DesignPatterns.Console.Criacionais.FactoryMethod;

public abstract class Logistica
{
    public void ExecutarPlanoEntrega()
    {
        var tranporte = CriarTransporte();
        // Executa o processo de entrega
    }

    public abstract Logistica CriarTransporte();
}
