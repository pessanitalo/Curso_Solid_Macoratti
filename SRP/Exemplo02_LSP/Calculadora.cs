namespace Exemplo02_LSP
{
    public abstract class Calculadora
    {
        protected readonly int[] _numeros;

        protected Calculadora(int[] numeros)
        {
            _numeros = numeros;
        }
        public abstract int Calcular();
    }
}
