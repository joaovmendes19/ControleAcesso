using System;

namespace ControleAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de opções");
            Console.WriteLine("1 - Cadastrar Usuario");
            Console.WriteLine("2 - Alterar Usuario");
            Console.WriteLine("3 - Excluir Usuario");
            Console.WriteLine("4 - Listar Usuarios");
            Console.WriteLine("5 - Cadastrar Perfil");
            Console.WriteLine("6 - Alterar Perfil");
            Console.WriteLine("7 - Excluir Perfil");
            Console.WriteLine("8 - Listar Perfis");
            Console.WriteLine("9 - Cadastrar Sessao");
            Console.WriteLine("10 - Alterar Sessao");
            Console.WriteLine("11 - Excluir Sessao");
            Console.WriteLine("12 - Listar Sessoes");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite a opção desejada:");
            string opcao = Console.ReadLine();
            switch (opcao) {
                case "1":
                    Usuario.CadastrarUsuario();
                    break;
                case "2":
                    Usuario.AlterarUsuario();
                    break;
                case "3":
                    Usuario.ExcluirUsuario();
                    break;
                case "4":
                    Usuario.ListarUsuarios();
                    break;
                case "5":
                    Perfil.CadastrarPerfil();
                    break;
                case "6":
                    Perfil.AlterarPerfil();
                    break;
                case "7":
                    Perfil.ExcluirPerfil();
                    break;
                case "8":
                    Perfil.ListarPerfis();
                    break;
                case "9":
                    Sessoes.CadastrarSessao();
                    break;
                case "10":
                    Sessoes.AlterarSessao();
                    break;
                case "11":
                    Sessoes.ExcluirSessao();
                    break;
                case "12":
                    Sessoes.ListarSessoes();
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
