using Repositorio;
using Repositorio.BancoDados;
using Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{

    // A classe RacaServico irá implementar a nterface IRacaServico,
    // ou seja, deverá honrar as cláusulas defininidas na interface(contrato)!
    public class RacaServico : IRacaServico
    {
        private RacaRepositorio racaRepositorio;


        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            racaRepositorio = new RacaRepositorio(contexto);
        }
        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            racaRepositorio.Cadastrar(raca);
            Console.WriteLine($"Nome: {nome} especie: {especie}");

        }
    }
}
