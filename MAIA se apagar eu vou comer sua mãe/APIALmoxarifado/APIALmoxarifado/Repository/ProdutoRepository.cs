using APIALmoxarifado.Infraestrutura;
using APIALmoxarifado.Properties.Models;

namespace APIALmoxarifado.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private ConexaoSQL bdConexao = new ConexaoSQL();

        public void Add(Produto produto)
        {
           
            bdConexao.Add(produto);
            bdConexao.SaveChanges();
        }

        public List<Produto> GetAll()
        {
           
            return bdConexao.Produto.ToList();
        }
    }
}