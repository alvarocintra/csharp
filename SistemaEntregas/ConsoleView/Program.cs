using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            LimparTela = 5,
            Sair = 6
        }
        public static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("Escolha sua opcao");
            Console.WriteLine("- Clientes -");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("- Geral -");
            Console.WriteLine("4 - Limpar Tela");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);
        }

        //Metodos Cliente
        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();

            Console.WriteLine("Nome: ");
            cli.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Cpf: ");
            cli.Cpf = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Rua: ");
            cli._Endereco.Rua = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Numero: ");
            //cli._Endereco.Numero = Console.R

            Console.WriteLine("Complemento: ");
            cli._Endereco.Complemento = Console.ReadLine();

            return cli;
        }

        private static Cliente PesquisarCliente()
        {
            return new Cliente();
        }

        private static Cliente EditarCliente()
        {
            return new Cliente();
        }
        

        static void Main(string[] args)
        {

            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.Sair;
            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        CadastrarCliente();
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        EditarCliente();
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        //ExcluirCliente();
                        break;
                    case OpcoesMenuPrincipal.LimparTela:
                        //LimparTela();
                        break;
                    default:
                        break;

                }
            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);

              /*  switch (opcaoDigitada)
                {
                    case 1:
                        CadastrarCliente();

                        break;

                    case 2:
                        PesquisarCliente();
                        break;

                    case 3:
                        EditarCliente();
                        break;

                    case 4:
                        break;

                    default:
                        break;
                }
            } while (opcaoDigitada != 5);*/


            
        }
    }
}
