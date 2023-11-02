namespace Exemplo1_LSP
{
    public class Gerente : Funcionario
    {
        double comissao = 500;
        public Gerente(string nome, string cargo) : base(nome, cargo)
        {
        }

        public double calculaSalario(double salario)
        {
            return salario + comissao;
        }
    }
}
