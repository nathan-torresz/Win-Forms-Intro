using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Forms_1
{
    class Vendas
    {
        private int _idProduto;
        public int IdProduto { get => _idProduto; private set => _idProduto = value; }

        public Vendas(int idProduto)
        {
            IdProduto = idProduto;
        }
    }
}
