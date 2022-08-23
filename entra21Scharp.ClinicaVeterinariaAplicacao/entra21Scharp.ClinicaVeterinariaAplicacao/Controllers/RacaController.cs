using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Entra21.CSharp.ClinicaVeterinaria.Servico.viewModels;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;

namespace entra21Scharp.ClinicaVeterinariaAplicacao.Controllers
{
    public class RacaController : Controller
    {
        private readonly IRacaServico _racaServico;


        //Construtor: Objetivo construir o objeto de RacaController,
        //Com o minimo necessário para o funcionamento correto
        public RacaController(ClinicaVeterinariaContexto contexto)
        {
            _racaServico = new RacaServico(contexto);
        }

        [Route("/raca")]
        [HttpGet]

        public IActionResult ObterTodos()
        {
            var racas = _racaServico.ObterTodos();

            return View("Index", racas);
        }

        [HttpGet("/raca/cadastrar")]
        public IActionResult Cadastrar()
        {
            var especies = ObterEspecies();

            ViewBag.Especies = especies;

            return View();

        }

        [HttpPost("/raca/cadastrar")]
        public IActionResult Cadastrar(

            [FromForm] RacaCadastrarViewModel racaCadastrarViewModel)
        {
            
            _racaServico.Cadastrar(racaCadastrarViewModel);

            return RedirectToAction("Index");
        }

        [Route("/raca/apagar")]
        [HttpGet]
        public IActionResult Apagar([FromQuery] int id)
        {
            _racaServico.Apagar(id);

            return RedirectToAction("Index");
        }


        [HttpGet("/raca/editar")]

        public IActionResult Editar([FromQuery] int id)
        {
            var raca = _racaServico.ObterPorId(id);
            var especies = ObterEspecies();
            var racaEditarNewModel = new RacaEditarViewModel
            {
                id = raca.Id,
                Nome = raca.Nome,
                Especie = raca.Especie
            };

            ViewBag.Especies = especies;

            return View(racaEditarNewModel);
        }

        [HttpPost("/raca/editar")]

        public IActionResult Editar(
            [FromForm] RacaEditarViewModel racaEditarViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Especies = ObterEspecies();
                return View(racaEditarViewModel);   
            }

            _racaServico.Editar(racaEditarViewModel);

            return RedirectToAction("Index");
        }

        private List<string> ObterEspecies()
        {
            return Enum.GetNames<Especie>().OrderBy(x => 1).ToList();
        }
    }
}
