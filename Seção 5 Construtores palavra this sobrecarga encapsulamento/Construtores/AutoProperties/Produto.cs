using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AutoProperties
{
    class Produto
    {
        private string _nome; // se tiver uma lógica particular deixa do jeto que está
        public double Preco { get; private set; }
        public int Quantidade { get; private set; } // indica que o atributo é privativo e não pode ser acessado por outra
        

        public Produto()
        {
        }

        public Produto(string nome, double preco) : this() //Está pegando o construtor de cima
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)  //Está pegando o construtor de cima
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;  // o value ele pega o que o set recebe como parametro
                }
            }
        }

     


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
