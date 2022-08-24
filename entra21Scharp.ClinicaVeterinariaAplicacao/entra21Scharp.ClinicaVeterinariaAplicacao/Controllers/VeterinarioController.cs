using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios;
using Microsoft.AspNetCore.Mvc;

namespace entra21Scharp.ClinicaVeterinariaAplicacao.Controllers
{
    [Route("Veterinario")]

    public class VeterinarioController : Controller
    {
        private readonly IVeterinarioServico _veterinarioServico;

        public VeterinarioController(IVeterinarioServico veterinarioServico)
        {
            _veterinarioServico = veterinarioServico;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost("/cadastrar")]
        public IActionResult Cadastrar(
            VeterinarioCadastrarViewModel veterinarioCadastarViewModel)
        {
            if(!ModelState.IsValid)
                return View(veterinarioCadastarViewModel);

            //Criar o registro chamando o serviço
            _veterinarioServico.Cadastrar(veterinarioCadastarViewModel);

            //Redirecionar para Index

            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index)); 
        }
    }

}
