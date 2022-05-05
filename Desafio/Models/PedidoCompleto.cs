using Desafio.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class PedidoCompleto
    {
        public PedidoCompleto() { }

        
        #region Atributos
            public string Id { get; set; }
            public int Numero { get; set; }
            public DateTime DataCriacao { get; set; }
            public DateTime DataAlteracao { get; set; }
            public string Status { get; set; }
            public double Desconto { get; set; }
            public double Frete { get; set; }
            public double SubTotal { get; set; }
            public double Valortotal { get; set; }
            public Cliente Cliente { get; set; }
            public EnderecoEntrega EnderecoEntrega { get; set; }
            public Item[] Itens { get; set; }
            public Pagamento[] pagamento { get; set; }

        #endregion

        #region Métodos

        #endregion
    }
}
