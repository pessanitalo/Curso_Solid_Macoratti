namespace Correcao_Aplicando_Solid.Interfaces
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int TempoDeContaEmAnos);
    }
}
