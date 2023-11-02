namespace Exemplo02_LSP
{
    public class CalcularSomaNumerosPares : Calculadora
    {
        public CalcularSomaNumerosPares(int[] numeros) : base(numeros)
        { }

        public override int Calcular() => _numeros.Where(x => x % 2 == 0).Sum();

    }
}
