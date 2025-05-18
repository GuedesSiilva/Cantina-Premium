using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Premium
{
    public class Cardapio   
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; } = 0;
        public Cardapio(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public override string ToString()
        {
            return $"{Nome, - 21}- R${Preco,-5:F2} - Qtd: {Quantidade, -3}";
        }
    }
}
