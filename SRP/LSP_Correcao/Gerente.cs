namespace LSP_Correcao
{
    public class Gerente : Funcionario
    {
        double comissao = 500;
        public Gerente(string nome, string cargo) : base(nome, cargo)
        {
        }

        public override double calculaSalario(double salario)
        {
            return salario + comissao;
        }
    }
}
