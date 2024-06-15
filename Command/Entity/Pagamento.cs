namespace Command.Entity
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public double Valor { get; set; }
    }
}
