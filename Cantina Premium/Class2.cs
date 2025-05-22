using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Premium
{
    internal class PreparoPedidos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pedido { get; set; }
        public int Quantidade { get; set; } = 0;
    }
}
