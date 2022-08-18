using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Repositorio
{
    public interface IRacaRepositorio
    {
        void Cadastrar(Raca raca);
        void Editar(Raca racaParaAlterar);
        Raca ObterPorId(int id);
        List<Raca> ObterTodos();
        void Apagar(int id);

    }
}