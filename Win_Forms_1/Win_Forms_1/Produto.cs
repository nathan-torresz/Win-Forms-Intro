using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Forms_1
{
    class Produto
    {
       // private int _idProduto;
        private string _numeroProduto;
        private string _nomeProduto;
        private string _marcaProduto;
        private string _descricaoProduto;
        private string _precoProduto;

        public string NumeroProduto { get => _numeroProduto; set => _numeroProduto = value; }
        public string NomeProduto { get => _nomeProduto; set => _nomeProduto = value; }
        public string MarcaProduto { get => _marcaProduto; set => _marcaProduto = value; }
        public string DescricaoProduto { get => _descricaoProduto; set => _descricaoProduto = value; }
        public string PrecoProduto { get => _precoProduto; set => _precoProduto = value; }
        //public int IdProduto { get => _idProduto; set => _idProduto = value; }

        public Produto(string numeroProduto, string nomeProduto, string marcaProduto, string descricaoProduto,
            string precoProduto)
        {
            //IdProduto = idProduto;
            NumeroProduto = numeroProduto;
            NomeProduto = nomeProduto;
            MarcaProduto = marcaProduto;
            DescricaoProduto = descricaoProduto;
            PrecoProduto = precoProduto;
        }
    }
}