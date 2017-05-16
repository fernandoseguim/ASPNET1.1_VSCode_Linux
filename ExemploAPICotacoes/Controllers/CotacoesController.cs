using Microsoft.AspNetCore.Mvc;

namespace ExemploAPICotacoes.Controllers
{
    [Route("api/[controller]")]
    public class CotacoesController : Controller
    {
        [HttpGet("{id}")]
        public Cotacao Get(
            [FromServices]CotacoesDAO cotacoesDAO,
            string id)
        {
            return cotacoesDAO.Obter(id);
        }
    }
}