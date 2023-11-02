namespace Exemplo02_LSP
{
    internal class CalcularSoma : Calculadora
    {
        public CalcularSoma(int[] numeros) : base(numeros) { }

        public override int Calcular() => _numeros.Sum();        
    }
}
