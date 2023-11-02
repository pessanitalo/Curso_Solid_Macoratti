namespace Exercicio_DIP
{
    public class MysqlConnection : IDatabaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conectando ao banco de dados");
        }
    }
}
