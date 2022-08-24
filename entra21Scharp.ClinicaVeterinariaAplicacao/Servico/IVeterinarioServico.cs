using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios;
using Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    public interface IVeterinarioServico
    {
        Veterinario Cadastrar(VeterinarioCadastrarViewModel viewModel);
        IList<Veterinario> ObterTodos(string pesquisa);

    }
}