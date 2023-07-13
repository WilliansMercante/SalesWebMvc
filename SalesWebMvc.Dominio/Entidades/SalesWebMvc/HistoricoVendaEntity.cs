using SalesWebMvc.Dominio.Entidades.SalesWebMvc.Enums;

namespace SalesWebMvc.Dominio.Entidades.SalesWebMvc
{
    public class HistoricoVendaEntity : Entidade
    {
        public DateTime DtVenda { get; set; }
        public double Valor { get; set; }
        public int IdVendedor { get; set; }
        public VendedorEntity Vendedor { get; set; }
        public StatusVendaEnum Status { get; set; }

        public HistoricoVendaEntity()
        {
        }

        public HistoricoVendaEntity(int id, DateTime dtVenda, double valor, StatusVendaEnum status, VendedorEntity vendedor)
        {
            Id = id;
            DtVenda = dtVenda;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
