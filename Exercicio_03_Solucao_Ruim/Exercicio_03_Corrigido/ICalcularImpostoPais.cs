namespace Exercicio_03_Corrigido
{
    public interface ICalcularImpostoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }
        decimal CalcularValorImposto();
    }
}
