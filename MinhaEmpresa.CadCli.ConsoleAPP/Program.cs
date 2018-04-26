using Empresa.CadCli.Core.contratos;
using Empresa.CadCli.Core.Data.EF;
using Empresa.CadCli.Core.Data.EF.Repositorios;
using Empresa.CadCli.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CadCli.ConsoleAPP
{
    class Program
    {

        static IClienteRepositorio cliRepo = new ClienteRepositorio();

        static void Main(string[] args)
        {
            // UsandoContexto();


            var menu = true;

            while (menu)
            {
                Console.WriteLine("O que deseja fazer ?\n 1 = Todos\n 2 = Adicionar\n 3 = Excluir\n 4 = Editar\n"
                + " 5 = Pesquisar por nome\n S = Sair\n");
                Console.Write("Digite a opção desejada: ");
                var resp = Console.ReadLine();

                int opcao;
                if (int.TryParse(resp, out opcao) && (opcao > 0 && opcao < 6))
                {
                    switch (opcao)
                    {
                        case 1:
                            ListarTodos();
                            break;
                        case 2:
                            Adicionar();
                            break;
                        case 3:
                            Excluir();
                            break;
                        case 4:
                            Editar();
                            break;
                        case 5:
                            pesquisar();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (resp.ToLower() == "s")
                    {
                        menu = false;
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("\n\nOpção Invalida!");
                    }

                }
            }
            Console.ReadLine();
        }

        private static void pesquisar()
        {
            Console.Write("\n\nInforme o conteudo do nome: ");
            var clientes = cliRepo.ObterPorNome(Console.ReadLine());

            foreach (var cli in clientes)
            {
                Console.WriteLine("\nId: {0}\nNome: {1}\nTipo: {2}\n", cli.id, cli.nome, cli.TipoCliente.nome);
            }
        }

        private static void Adicionar()
        {
            Console.Write("\n\nInforme o Nome: ");
            var nome = Console.ReadLine();
            Console.Write("\nInforme o Tipo: ");
            var tipo = Convert.ToInt32(Console.ReadLine());
            cliRepo.Adicionar(new Cliente(nome, tipo));
            Console.WriteLine("Cliente " + nome + "  Adicionado com sucesso!");
        }

        private static void ListarTodos()
        {
            foreach (var cli in cliRepo.ObterTodos())
            {
                Console.WriteLine("\nId: {0}\nNome: {1}\nTipo: {2}\n", cli.id, cli.nome, cli.TipoCliente.nome);
            }
        }

        private static void Editar()
        {
            Console.Write("\n\nInforme o ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var cliente = cliRepo.ObterPorId(id);
            if (cliente != null)
            {
                Console.Write("\n\nInforme o Nome: ");
                cliente.nome = Console.ReadLine();
                Console.Write("\nInforme o Tipo:\n1 = PF\n 2 = PJ");
                cliente.tipoClienteId = Convert.ToInt32(Console.ReadLine());
                cliRepo.Atualizar(cliente);
                Console.WriteLine("Cliente" + cliente.nome + " atualizado!");
            }
        }

        private static void Excluir()
        {
            Console.Write("\n\nInforme o ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var cliente = cliRepo.ObterPorId(id);
            if (cliente != null)
            {
                cliRepo.Excluir(cliente);
                Console.WriteLine("Cliente " + cliente.nome + "excluido com sucesso!");
            }
        }

    }
}
