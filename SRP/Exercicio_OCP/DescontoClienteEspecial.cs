namespace Exercicio_OCP
{
    public class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 50;
        }
    }
}
