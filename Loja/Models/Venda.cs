namespace Loja.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public int CarroId { get; set; }
        public Carro? Carro { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal? ValorEntrada { get; set; }
        public bool IsAVista { get; set; }
        public int? Parcelas { get; set; }
        public decimal? ValorJuros { get; set; }
        public string? BancoFinanciamento { get; set; }
        public int VendedorId { get; set; }
        public Usuario? Vendedor { get; set; }
        public decimal ComissaoVendedor { get; set; }
        public DateTime? DataEntrega { get; set; }
    }
}
