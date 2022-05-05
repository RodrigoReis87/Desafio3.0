using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Pagamento
    {
        public string Id { get; set; }
        public int Parcela { get; set; }
        public double Valor { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
    }
}
