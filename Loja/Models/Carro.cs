namespace Loja.Models
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public bool IsNovo { get; set; }
        public int Estoque { get; set; }
    }
}
