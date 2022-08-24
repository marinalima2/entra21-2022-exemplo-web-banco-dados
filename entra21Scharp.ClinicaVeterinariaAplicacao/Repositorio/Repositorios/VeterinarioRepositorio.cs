using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public class VeterinarioRepositorio : IVeterinarioRepositorio
    {
        private readonly ClinicaVeterinariaContexto _contexto;

        public VeterinarioRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }

        public Veterinario Cadastrar(Veterinario veterinario)
        {
            _contexto.Veterinarios.Add(veterinario);
            _contexto.SaveChanges();

            return veterinario;
        }

        public IList<Veterinario> ObterTodos(string pesquisa) => // => : Ùnica excessão é no construtor
        
            _contexto.Veterinarios
                //Nome com LIKE ou CRMV exatamente 
                .Where(x => x.Nome.Contains(pesquisa) || x.Crmv == pesquisa).
                ToList();
        
    }
}
