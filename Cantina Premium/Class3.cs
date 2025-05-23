using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Premium
{
    internal class PreparoPedidos
    {
        public static PreparoPedidos Instancia { get; } = new PreparoPedidos();
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
