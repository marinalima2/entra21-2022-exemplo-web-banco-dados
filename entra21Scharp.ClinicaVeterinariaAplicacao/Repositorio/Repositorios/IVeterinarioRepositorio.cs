using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IVeterinarioRepositorio
    {
        Veterinario Cadastrar(Veterinario veterinario);
        IList<Veterinario> ObterTodos(string pesquisa);

    }
}