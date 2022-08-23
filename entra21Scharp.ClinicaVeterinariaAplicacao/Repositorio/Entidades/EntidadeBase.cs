using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    //Classes que herdarem terão que implementar o que estiver na EntidadeBase
    public abstract class EntidadeBase 
    {

        public int Id { get; set; }
        
    }
}
