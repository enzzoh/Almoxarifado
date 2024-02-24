using Microsoft.AspNetCore.Http;

namespace APIALmoxarifado.ViewModel
{
    public class ProdutoViewModelSemFoto
    {
        public string nome { get; set; }

        public int estoque { get; set; } = 0;
        public IFormFile photo { get; set; }
    }
}
