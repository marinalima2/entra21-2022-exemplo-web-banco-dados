using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }    
        public string Crmv { get; set; }    
        public  int Idade { get; set; }
        public decimal Salario { get; set; }
        public bool Empregado { get; set; }
    
    }
}
