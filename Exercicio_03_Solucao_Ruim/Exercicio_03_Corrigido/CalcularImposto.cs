namespace Exercicio_03_Corrigido
{
    public class CalcularImposto
    {
        public decimal Calcular(ICalcularImpostoPais calcular)
        {
            return calcular.CalcularValorImposto();
        }
    }
}
