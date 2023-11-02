namespace Exercicio_OCP
{
    public class DescontoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 10;
        }
    }
}
