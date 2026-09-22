using Microsoft.AspNetCore.Mvc;
using TaskFlow.Api.Models;

namespace TaskFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private static readonly string[] Produtos =
      [
            "Geladeira", "Fogão", "Máquina de lavar roupas", "Lava-louças",
            "Micro-ondas", "Forno elétrico", "Aspirador de pó", "Airfryer", "Liquidificador", "Batedeira",
            "Ferro de passar", "Purificador de água"
      ];

        [HttpGet]
        public IEnumerable<Vendas> Get()
        {
            return Enumerable.Range(1, 10).Select(index => new Vendas
            {
                Data = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Valor = $"{Random.Shared.Next(10, 1245)}$",
                NomeDoProduto = Produtos[Random.Shared.Next(Produtos.Length)]
            })
          .ToArray();
        }
    }
}
