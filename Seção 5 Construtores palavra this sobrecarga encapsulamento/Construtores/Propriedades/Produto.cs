using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Propriedades
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade; // indica que o atributo é privativo e não pode ser acessado por outra

        public Produto()
        {
        }

        public Produto(string nome, double preco) : this() //Está pegando o construtor de cima
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)  //Está pegando o construtor de cima
        {
            _quantidade = quantidade;
        }

        public string Nome { get { return _nome; } set
            {
                if (value != null && value.Length > 1) 
                {
                    _nome = value;  // o value ele pega o que o set recebe como parametro
                }
            } }

        public double Preco { get { return _preco; } }
        
        public int Quantidade { get { return _quantidade; } }
 

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
