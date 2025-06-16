using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Premium
{
    internal class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public List<Cardapio> Itens { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHora { get; set; }
        public string Status { get; set; } = "";
        public string Tipo { get; set; } = "";

        public Pedido() { }
        public Pedido(string Entrega)
        {
            Tipo = Entrega;
        }

        public override string ToString()
        {
            return $"Pedido #{Id} - Cliente: {NomeCliente} - {DataHora:HH:mm} {Tipo} {Status}";
        }

    }
}
