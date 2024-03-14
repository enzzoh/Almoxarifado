using APIALmoxarifado.Properties.Models;
using APIALmoxarifado.Repository;
using APIALmoxarifado.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace APIALmoxarifado.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(ProdutoRepository repositorio)
        {
            _produtoRepository = repositorio;
        }


        [HttpGet]
        [Route("api/v1/produto")]
        public IActionResult Hello()
        {
            return Ok("Hello Mundo");
        }
        [HttpGet]
        [Route("GetAllFake")]

        public IActionResult GetAllFake()
        {
            var produtos = new List<Produto>()
            {
                new Produto()
                {

                    id = 10,
                    nome = "PC HP",
                    estoque =10
                },
                new Produto()
                {
                    id= 20,
                    nome= "PC DELL",

                }
            };
            return Ok(produtos);
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_produtoRepository.GetAll());
        }


        [HttpPost]
        [Route("AdicionarProdutoSemFoto")]
        public IActionResult AdicionarProdutoSemFoto(ProdutoViewModelSemFoto produto)
        {
            try
            {
                _produtoRepository.Add(
                  new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest("Não Cadastrado. Erro: " + ex.Message);
            }
        }



        [HttpPost]
        [Route("AdicionarProdutoComFoto")]
        public IActionResult AdicionarProdutoComFoto([FromForm] ProdutoViewModelSemFoto produto)
        {
            try
            {
                var caminho = Path.Combine("Storage", produto.photo.FileName);

                using Stream fileStream = new FileStream(caminho, FileMode.Create);
                produto.photo.CopyTo(fileStream);

                _produtoRepository.Add(
                  new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = caminho }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest("Não Cadastrado. Erro: " + ex.Message);
            }
        }

        [HttpPost]
        [Route("{id}/GetProduto")]
        public IActionResult GetProduto(int id)
        {
            return Ok(_produtoRepository.GetAll().Find(x => x.id == id));
        }
        [HttpGet]
        [Route("{id}/Download")]
        public IActionResult Download(int id)
        {
            try
            {
                var produto = _produtoRepository.GetAll().Find(x => x.id == id);
                if (produto?.photourl == null)
                {
                    return Ok("Não existe falta cadastrada para o Produto");
                } 
                else
                {
                    var dataBytes = System.IO.File.ReadAllBytes(produto.photourl);
                    return File(dataBytes, "image/jpg");
                }
            }
            catch 
            {
                return BadRequest("Erro");
            }
        }
    }
}
