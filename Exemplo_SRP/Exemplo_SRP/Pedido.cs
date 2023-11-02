namespace SRP
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int PrecoTotal { get; set; }

        private ILogger logger;
        private EnviarEmail enviarEmail;

        public Pedido()
        {
            logger = new RegistraLog();
            enviarEmail = new EnviarEmail();
        }

        public void IncluirPedido()
        {
            try
            {
                //codigo para incluir o pedido
                logger.Info("Incluir pedido");
                enviarEmail.Assunto = "Pedido concluido";
                enviarEmail.Destinatario = "email@gmail.com";
                enviarEmail.Enviar();
            }
            catch (Exception ex)
            {

                logger.Info("Erro ao enviar email " + ex.Message);
            }
        }

        public void DeletarPedido()
        {
            try
            {
                //codigo para deletar o pedido
                logger.Info("Pedido deletado com sucesso " + DateTime.Now);
            }
            catch (Exception ex)
            {
                logger.Info("Erro ao deletar o pedido " + ex.Message);

            }
        }

    }
}
