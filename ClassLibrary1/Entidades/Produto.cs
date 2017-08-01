using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string ProdutoNome { get; set; }

        public string ProdutoDescricao { get; set; }

        public decimal ProdutoPreco { get; set; }

        public string ProdutoCategoria { get; set; }
    }
}
