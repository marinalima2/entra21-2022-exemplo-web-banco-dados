using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Microsoft.AspNetCore.Mvc;
using Repositorio.BancoDados;

namespace entra21Scharp.ClinicaVeterinariaAplicacao.Controllers
{
    public class RacaController : Controller
    {
        private readonly RacaServico _racaServico;
        private RacaServico racaServico;

        //Construtor: Objetivo construir o objeto de RacaController,
        //Com o minimo necessário para o funcionamento correto
        public RacaController(ClinicaVeterinariaContexto contexto)
        {
            racaServico = new RacaServico(contexto);
        }

        [Route("/raca")]
        [HttpGet]

        public IActionResult ObterTodos()
        {
            return View("Index");
        }

        [Route("/raca/cadastrar")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [Route("/raca/registrar")]
        [HttpGet]
        public IActionResult Registrar(

            [FromQuery] string nome,
            [FromQuery] string especie)
        {
            racaServico.Cadastrar(nome, especie);

            return RedirectToAction("Index");
        }
    }
}
