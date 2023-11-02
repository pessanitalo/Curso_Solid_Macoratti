namespace Exercicio_DIP
{
    public class RecuperarSenha
    {
        private IDatabaseConnection _conexao;

        public RecuperarSenha(IDatabaseConnection conexao)
        {
            _conexao = conexao;
        }

        public void GerarSenha()
        {
            _conexao.Conectar();
        }
    }
}
