using Microsoft.AspNetCore.Mvc;

namespace entra21Scharp.ClinicaVeterinariaAplicacao.Controllers
{
    public class RacaController : Controller
    {

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
            [FromQuery]string especie )
        {
            return RedirectToAction("Index");
        }

        

    }
}
