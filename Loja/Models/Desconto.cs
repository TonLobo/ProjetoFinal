namespace Loja.Models
{
    public class Desconto
    {
        public int DescontoId { get; set; }
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }
        public decimal ValorDesconto { get; set; }
        public bool Aprovado { get; set; }
    }
}
