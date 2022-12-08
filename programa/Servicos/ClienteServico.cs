using programa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa.Servicos
{
    internal class ClienteServico
    {
        private ClienteServico()
        {

        }

        private static ClienteServico instancia = default!;

        public static ClienteServico Get()
        {
            if (instancia == null) instancia = new ClienteServico();
            return instancia;
        }

        public List<Cliente> Lista = new List<Cliente>();

       
    }
}
