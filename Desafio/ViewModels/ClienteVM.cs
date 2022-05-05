using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desafio.Models.PedidoCompleto;

namespace Desafio.ViewModels
{
    public class ClienteVM : PropertyChange
    {
        public ClienteVM() { }

        public ClienteVM(Cliente objeto)
        {
            ConverterToVM(objeto);
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

        private string _cnpj;
        public string Cnpj
        {
            get => _cnpj;
            set
            {
                _cnpj = value;
                OnPropertyChanged(nameof(Cnpj));
            }
        }

        private string _cpf;
        public string Cpf
        {
            get => _cpf;
            set
            {
                _cpf = value;
                OnPropertyChanged(nameof(Cpf));
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

        private string _razaoSocial;
        public string RazaoSocial
        {
            get => _razaoSocial;
            set
            {
                _razaoSocial = value;
                OnPropertyChanged(nameof(RazaoSocial));
            }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get => _dataNascimento;
            set
            {
                _dataNascimento = value;
                OnPropertyChanged(nameof(DataNascimento));
            }
        }

        private void ConverterToVM(Cliente objeto)
        {
            try
            {
                Id = objeto.Id;
                Cnpj = objeto.Cnpj;
                Cpf = objeto.Cpf;
                Nome = objeto.Nome;
                RazaoSocial = objeto.RazaoSocial;
                Email = objeto.Email;
                DataNascimento = objeto.DataNascimento;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
