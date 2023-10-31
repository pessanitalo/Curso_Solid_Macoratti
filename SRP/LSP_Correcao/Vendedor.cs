namespace LSP_Correcao
{
    public class Vendedor : Funcionario
    {
        double comissao = 300;
        public Vendedor(string nome, string cargo) : base(nome, cargo)
        {
        }

        public override double calculaSalario(double salario)
        {
            return salario + comissao;
        }
    }
}
