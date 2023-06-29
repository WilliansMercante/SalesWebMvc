namespace SalesWebMvc.Dominio.Entidades.SalesWebMvc
{
    public class DepartamentoEntity : Entidade
    {
        public string Nome { get; set; }
        public bool FlAtivo { get; set; }
        public ICollection<VendedorEntity> Vendedores { get; set; } = new List<VendedorEntity>();

        public DepartamentoEntity()
        {
        }
        public DepartamentoEntity(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(VendedorEntity vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime dtInicial, DateTime dtFinal)
        {
            return Vendedores.Sum(p => p.TotalVendas(dtInicial, dtFinal));
        }
    }
}
