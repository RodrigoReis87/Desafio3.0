using Desafio.Models;
using Desafio.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desafio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		string json = @"{
			'id': '9477b7a9-83c2-400b-8a6b-6be6bb541bf0',
			'numero': 1,
			'datacriacao': '2022-02-22T23:37:22.5769046+00:00',
			'dataalteracao': '2022-04-13T23:37:22.5773178+00:00',
			'status': 'APROVADO',
			'desconto': 10,
			'frete': 25,
			'subTotal': 270.7,
			'valortotal': 305.7,
			'cliente': {
				'id': '11b02b6d-39be-4d46-a46b-ac97a33fe989',
				'cnpj': '',
				'cpf': '68471698005',
				'nome': 'Barry Allen',
				'razaoSocial': '',
				'email': 'theflash@teamflash.com',
				'dataNascimento': '1997-04-13T23:37:22.5778272+00:00'
			},
			'enderecoEntrega': {
				'id': 'dea46c91-a124-4286-b3e3-e2f2c145f4c6',
				'endereco': 'Star Labs',
				'numero': '100',
				'cep': '00000000',
				'bairro': 'midtown',
				'cidade': 'central city',
				'estado': 'KS',
				'complemento': '',
				'referencia': ''
			},
			'itens': [
				{
					'id': '3ed07192-6815-4b77-b3dc-b7bdb5f24b47',
					'idproduto': 'c8bddecb-f3b2-4b4c-b655-ae1c1d732762',
					'nome': 'Tênis Stark Runner',
					'quantidade': 1,
					'valorunitario': 120.5
				},
				{
	'id': '57ee2448-26d2-4172-a23d-95835b8c724e',
					'idproduto': '23280712-21e6-426a-a7fc-ee95be9b7b69',
					'nome': 'Tênis Luthor Confort',
					'quantidade': 1,
					'valorunitario': 150.2
				}
			],
			'pagamento': [
				{
					'id': '7241f1b9-5e1f-4e55-a043-82daa2f7c4cc',
					'parcela': 1,
					'valor': 152.85,
					'codigo': 'pagseguro',
					'nome': 'pagseguro'
				},
				{
	'id': 'a3255ce6-71da-44a9-b2a7-5a1fe2a32a43',
					'parcela': 2,
					'valor': 152.85,
					'codigo': 'pagseguro',
					'nome': 'pagseguro'
				}
			]
		}";

		public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSincronizar_Click(object sender, RoutedEventArgs e)
        {
            var obj = JsonConvert.DeserializeObject<PedidoCompleto>(json);

			var pedidoVM = new PedidoVM();

			pedidoVM.ConverterToVM(obj);

			MessageBox.Show("Pedidos sincronizados com sucesso!");
        }

		private void BtnSair_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
