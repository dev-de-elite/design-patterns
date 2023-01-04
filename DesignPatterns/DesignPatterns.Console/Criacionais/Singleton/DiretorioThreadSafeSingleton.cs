namespace DesignPatterns.Console.Criacionais.Singleton;

public sealed class DiretorioThreadSafeSingleton
{
    private DiretorioThreadSafeSingleton() { }

    private static readonly Lazy<DiretorioThreadSafeSingleton> _lazy = new(() => new DiretorioThreadSafeSingleton());

    public static DiretorioThreadSafeSingleton Instance => _lazy.Value;

    public void SalvarArquivo(string conteudo)
    {
        //Salva o conteúdo em um arquivo no diretório
    }
}
