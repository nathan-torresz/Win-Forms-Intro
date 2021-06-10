using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Forms_1
{
    class CarrinhoCompras : Produto
    {
        private int _idProduto;
        public int IdProduto { get => _idProduto; private set => _idProduto = value; }
        public CarrinhoCompras(int idProduto, string numeroProduto, string nomeProduto, string marcaProduto, string descricaoProduto,
            string precoProduto) : base(numeroProduto, nomeProduto, marcaProduto, descricaoProduto, precoProduto)
        {
            IdProduto = idProduto;
            NumeroProduto = numeroProduto;
            NomeProduto = nomeProduto;
            MarcaProduto = marcaProduto;
            DescricaoProduto = descricaoProduto;
            PrecoProduto = precoProduto;
        }
    }
}