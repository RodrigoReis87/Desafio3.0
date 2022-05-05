using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.ViewModels
{
    public class PagamentoVM : PropertyChange
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

        private int _parcela;
        public int Parcela
        { 
            get=>_parcela;
            set
            {
                _parcela = value;
                OnPropertyChanged(nameof(Parcela));
            }
        }

        private double _valor;
        public double Valor
        {
            get => _valor;
            set
            {
                _valor = value;
                OnPropertyChanged(nameof(Valor));
            }
        }

        private string _codigo;
        public string Codigo
        {
            get => _codigo;
            set
            {
                _codigo = value;
                OnPropertyChanged(nameof(Codigo));
            }
        }

        private string _nome;
        private Pagamento item;

        public PagamentoVM(Pagamento item)
        {
            this.item = item;
        }

        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }

        public void ConverterToVM(PagamentoVM objeto)
        {
            try
            {
                if (objeto != null)
                {
                    Id = objeto.Id;
                    Parcela = objeto.Parcela;
                    Valor = objeto.Valor;
                    Codigo = objeto.Codigo;
                    Nome = objeto.Nome;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
