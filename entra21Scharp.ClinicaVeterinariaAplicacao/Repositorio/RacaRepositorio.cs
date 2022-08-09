using Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Repositorio
{
    public class RacaRepositorio : IRacaRepositorio
    {
        private readonly ClinicaVeterinariaContexto _contexto;

        public RacaRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }
        public void Cadastrar(Raca raca)
        {
            //Insert na tabela de raças 
            _contexto.Racas.Add(raca);
            _contexto.SaveChanges();
            
        }
    }
}
