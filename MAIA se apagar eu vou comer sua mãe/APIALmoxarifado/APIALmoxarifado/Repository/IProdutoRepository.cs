using APIALmoxarifado.Properties.Models;

namespace APIALmoxarifado.Repository
{
    public interface IProdutoRepository
    {
        public List<Produto> GetAll();

        void Add(Produto produto);
    }
}
