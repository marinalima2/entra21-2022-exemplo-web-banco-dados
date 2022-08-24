using Entra21.CSharp.ClinicaVeterinaria.Servico.MapeamentoEntidades;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios;
using Repositorio.Entidades;
using Repositorio.Repositorios;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    public class VeterinarioServico : IVeterinarioServico
    {
        private readonly IVeterinarioRepositorio _veterinarioRepositorio;
        private readonly IVeterinarioMapeamentoEntidade _mapeamento;

        public VeterinarioServico(
            IVeterinarioRepositorio veterinarioRepositorio,
            IVeterinarioMapeamentoEntidade mapeamento)
        {
            _veterinarioRepositorio = veterinarioRepositorio;
            _mapeamento = mapeamento;
        }

        public Veterinario Cadastrar(VeterinarioCadastrarViewModel viewModel)
        {
            var veterinario = _mapeamento.ConstruirCom(viewModel);

            _veterinarioRepositorio.Cadastrar(veterinario);

            return veterinario;        
        }

        public IList<Veterinario> ObterTodos(string pesquisa) =>
            _veterinarioRepositorio.ObterTodos(pesquisa);
    }
}
