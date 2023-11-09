namespace Exercicio_02_Corrigido
{
    public class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"c:\dados\log\LogOcorrencias.txt", mensagem);
        }
    }
}
