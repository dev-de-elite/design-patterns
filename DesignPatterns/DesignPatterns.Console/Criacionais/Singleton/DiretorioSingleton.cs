namespace DesignPatterns.Console.Criacionais.Singleton;

public sealed class DiretorioSingleton
{
    private DiretorioSingleton() { }

    private static DiretorioSingleton? _instancia;

    public static DiretorioSingleton ObterInstancia()
    {
        if(_instancia == null)
        {
            _instancia = new DiretorioSingleton();
        }
        return _instancia;
    }

    public void SalvarArquivo(string conteudo)
    {
        //Salva o conteúdo em um arquivo no diretório
    }
}
