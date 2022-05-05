using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desafio.Models.PedidoCompleto;

namespace Desafio.ViewModels
{
    public class PedidoVM
    {
        public PedidoVM() { }

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
        public List<Item> Itens { get; set; }
        // public List<Pagamento> pagamento { get; set; }        

        public void ConverterToVM(PedidoCompleto objeto)
        {
            try
            {
                objeto.Id = Id;
                objeto.Numero = Numero;
                objeto.DataCriacao = DataCriacao;
                objeto.DataAlteracao = DataAlteracao;
                objeto.Status = Status;
                objeto.Desconto = Desconto;
                objeto.Frete = Frete;
                objeto.SubTotal = SubTotal;
                objeto.Valortotal = Valortotal;

                objeto.Cliente = new Cliente()
                {
                    Id = objeto.Cliente.Id,
                    Cnpj = objeto.Cliente.Cnpj,
                    Cpf = objeto.Cliente.Cpf,
                    Nome = objeto.Cliente.Nome,
                    RazaoSocial = objeto.Cliente.RazaoSocial,
                    Email = objeto.Cliente.Email,
                    DataNascimento = objeto.Cliente.DataNascimento
                };

                objeto.EnderecoEntrega = new EnderecoEntrega()
                {
                    Id = objeto.EnderecoEntrega.Id,
                    Endereco = objeto.EnderecoEntrega.Endereco,
                    Numero = objeto.EnderecoEntrega.Numero,
                    Cep = objeto.EnderecoEntrega.Cep,
                    Bairro = objeto.EnderecoEntrega.Bairro,
                    Cidade = objeto.EnderecoEntrega.Cidade,
                    Estado = objeto.EnderecoEntrega.Estado,
                    Complemento = objeto.EnderecoEntrega.Complemento,
                    Referencia = objeto.EnderecoEntrega.Referencia
                };

                //objeto.Itens = new List<Item>();
                    foreach(var item in objeto.Itens)
                    {
                    objeto.Itens.Add(new Item()
                    {
                        Id = objeto.Itens.First().Id,
                        Idproduto = objeto.Itens.First().Idproduto,
                        Nome = objeto.Itens.First().Nome,
                        Quantidade = objeto.Itens.First().Quantidade,
                        ValorUnitario = objeto.Itens.First().ValorUnitario
                    });
                    };                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
    
}
