namespace SalesWebMvc.Dominio.Entidades.SalesWebMvc
{
    public class VendedorEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public double Salario { get; set; }
        public DepartamentoEntity Departamento { get; set; }
        public ICollection<HistoricoVendas> HistoricoVendas { get; set; } = new List<HistoricoVendas>();

        public VendedorEntity()
        {
        }

        public VendedorEntity(int id, string nome, string email, DateTime dtNascimento, double salario)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DtNascimento = dtNascimento;
            Salario = salario;
        }

        public void AdicionarVendas(HistoricoVendas historico)
        {
            HistoricoVendas.Add(historico);
        }

        public void RemoverVendas(HistoricoVendas historico)
        {
            HistoricoVendas.Remove(historico);
        }

        public double TotalVendas(DateTime dtInicial, DateTime dtFinal)
        {
            return HistoricoVendas.Where(p => p.DtVenda >= dtInicial && p.DtVenda <= dtFinal).Sum(p => p.Valor);
        }
    }
}
