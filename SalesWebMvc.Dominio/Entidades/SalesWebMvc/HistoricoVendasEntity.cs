using SalesWebMvc.Dominio.Entidades.SalesWebMvc.Enums;

namespace SalesWebMvc.Dominio.Entidades.SalesWebMvc
{
    public class HistoricoVendas
    {
        public int Id { get; set; }
        public DateTime DtVenda { get; set; }
        public double Valor { get; set; }
        public VendedorEntity Vendedor { get; set; }
        public StatusVendaEnum Status { get; set; }
        public HistoricoVendas()
        {
        }

        public HistoricoVendas(int id, DateTime dtVenda, double valor, StatusVendaEnum status, VendedorEntity vendedor)
        {
            Id = id;
            DtVenda = dtVenda;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
