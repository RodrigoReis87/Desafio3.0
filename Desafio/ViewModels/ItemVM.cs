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
    public class ItemVM : PropertyChange
    {
        public ItemVM(ItemVM prod)
        {
            ConverterToVM(prod);
        }

        public ItemVM(Item item)
        {
            this.item = item;
        }

        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _idProduto;
        public string IdProduto
        {
            get => _idProduto;
            set
            {
                _idProduto = value;
                OnPropertyChanged(nameof(IdProduto));
            }
        }

        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }

        private int _quantidade;
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                _quantidade = value;
                OnPropertyChanged(nameof(Quantidade));
            }
        }

        private double _valorUnitario;
        private Item item;

        public double ValorUnitario
        {
            get => _valorUnitario;
            set
            {
                _valorUnitario = value;
                OnPropertyChanged(nameof(ValorUnitario));
            }
        }

        public void ConverterToVM(ItemVM objeto)
        {
            try
            {
                if(objeto != null)
                {
                    Id = objeto.Id;
                    IdProduto = objeto.IdProduto;
                    Nome = objeto.Nome;
                    Quantidade = objeto.Quantidade;
                    ValorUnitario = objeto.ValorUnitario;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

