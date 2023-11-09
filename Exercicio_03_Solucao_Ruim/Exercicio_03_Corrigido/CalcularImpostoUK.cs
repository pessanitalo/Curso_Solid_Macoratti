namespace Exercicio_03_Corrigido
{
    public class CalcularImpostoUk : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 10 / 100;
        }
    }
}
