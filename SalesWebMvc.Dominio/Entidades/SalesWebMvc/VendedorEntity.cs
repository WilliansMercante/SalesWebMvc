namespace SalesWebMvc.Dominio.Entidades.SalesWebMvc
{
    public class VendedorEntity : Entidade
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public double Salario { get; set; }
        public int IdDepartamento { get; set; }
        public DepartamentoEntity Departamento { get; set; }
        public bool FlAtivo { get; set; }
        public ICollection<HistoricoVendaEntity> HistoricoVendas { get; set; } = new List<HistoricoVendaEntity>();

        public VendedorEntity()
        {
        }

        public VendedorEntity(int id, string nome, string email, DateTime dtNascimento, double salario, int idDepartamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DtNascimento = dtNascimento;
            Salario = salario;
            IdDepartamento = idDepartamento;
        }

        public void AdicionarVendas(HistoricoVendaEntity historico)
        {
            HistoricoVendas.Add(historico);
        }

        public void RemoverVendas(HistoricoVendaEntity historico)
        {
            HistoricoVendas.Remove(historico);
        }

        public double TotalVendas(DateTime dtInicial, DateTime dtFinal)
        {
            return HistoricoVendas.Where(p => p.DtVenda >= dtInicial && p.DtVenda <= dtFinal).Sum(p => p.Valor);
        }
    }
}
