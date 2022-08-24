using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios;
using Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.MapeamentoEntidades
{
    public interface IVeterinarioMapeamentoEntidade
    {
        public Veterinario ConstruirCom(VeterinarioCadastrarViewModel viewModel);
    }
}