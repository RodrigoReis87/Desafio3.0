using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.ViewModels
{
    public class UcPedidoVM : PropertyChange
    {
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

        private string _numero;
        public string Numero
        {
            get => _numero;
            set
            {
                _numero = value;
                OnPropertyChanged(nameof(Numero));
            }
        }

        private DateTime _datacriacao;
        public DateTime Datacriacao
        {
            get => _datacriacao;
            set
            {
                _datacriacao = value;
                OnPropertyChanged(nameof(Datacriacao));
            }
        }

        private DateTime _dataAlteracao;
        public DateTime DataAlteracao
        {
            get => _dataAlteracao;
            set
            {
                _dataAlteracao = value;
                OnPropertyChanged(nameof(DataAlteracao));
            }
        }

        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        private double _desconto;
        public double Desconto
        {
            get => _desconto;
            set
            {
                _desconto = value;
                OnPropertyChanged(nameof(Desconto));
            }
        }

        private double _frete;
        public double Frete
        {
            get => _frete;
            set
            {
                _frete = value;
                OnPropertyChanged(nameof(Frete));
            }
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                OnPropertyChanged(nameof(SubTotal));
            }
        }

        private double _valorTotal;
        public double ValorTotal
        {
            get => _valorTotal;
            set
            {
                _valorTotal = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private ObservableCollection<ClienteVM> _cliente;
        public ObservableCollection<ClienteVM> Cliente
        {
            get => _cliente;
            set
            {
                _cliente = value;
                OnPropertyChanged(nameof(Cliente));
            }
        }

        private ObservableCollection<EnderecoVM> _endereco;
        public ObservableCollection<EnderecoVM> Endereco
        {
            get => _endereco;
            set
            {
                _endereco = value;
                OnPropertyChanged(nameof(Endereco));
            }
        }
    }
}
