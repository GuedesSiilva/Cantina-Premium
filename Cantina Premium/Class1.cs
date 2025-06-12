using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_Premium
{
    public class Cardapio   
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; } = 0;
        public bool Chapa { get; set; }
        public Cardapio(int id,string nome, double preco, int quantidade,bool chapa)
        {
            ID = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Chapa = chapa;
        }
        public override string ToString()
        {
            return $"#{ID} {Nome, - 21}- R${Preco,-5:F2} - Qtd: {Quantidade, -3}";
        }
    }
}
