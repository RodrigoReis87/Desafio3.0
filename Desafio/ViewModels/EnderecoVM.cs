using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.ViewModels
{
    public class EnderecoVM : PropertyChange
    {
        public string id { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string complemento { get; set; }
        public string referencia { get; set; }

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

        private string _endereco;
        public string Endereco
        {
            get => _endereco;
            set
            {
                _endereco = value;
                OnPropertyChanged(nameof(Endereco));
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

        private string _cep;
        public string Cep
        {
            get => _cep;
            set
            {
                _cep = value;
                OnPropertyChanged(nameof(Cep));
            }
        }

        private string _bairro;
        public string Bairro
        {
            get => _bairro;
            set
            {
                _bairro = value;
                OnPropertyChanged(nameof(Bairro));
            }
        }

        private string _cidade;
        public string Cidade
        {
            get => _cidade;
            set
            {
                _cidade = value;
                OnPropertyChanged(nameof(Cidade));
            }
        }

        private string _estado;
        public string Estado
        {
            get => _estado;
            set
            {
                _estado = value;
                OnPropertyChanged(nameof(Estado));
            }
        }

        private string _complemento;
        public string Complemento
        {
            get => _complemento;
            set
            {
                _complemento = value;
                OnPropertyChanged(nameof(Complemento));
            }
        }

        private string _referencia;
        public string Referencia
        {
            get => _referencia;
            set
            {
                _referencia = value;
                OnPropertyChanged(nameof(Referencia));
            }
        }
    }
}

