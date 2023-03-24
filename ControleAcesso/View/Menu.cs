using System;

namespace View
{
    public class Menu
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("1) Cadastrar usuário");
            Console.WriteLine("2) Alterar usuário");
            Console.WriteLine("3) Excluir usuário");
            Console.WriteLine("4) Listar usuários");
            Console.WriteLine("5) Cadastrar perfil");
            Console.WriteLine("6) Excluir perfil");
            Console.WriteLine("7) Listar perfis");
            Console.WriteLine("8) Cadastrar sessão");
            Console.WriteLine("9) Excluir sessão");
            Console.WriteLine("10) Listar sessões");
            Console.WriteLine(" Sair");
            Console.WriteLine("Digite a opção desejada: ");
        }

        public static void ExibirMenu() {
            int opcao = -1;
            do {
                MostrarMenu();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        View.Usuario.CriarUsuario();
                        break;
                    case 2:
                        View.Usuario.AlterarUsuario();
                        break;
                    case 3:
                        View.Usuario.ExcluirUsuario();
                        break;
                    case 4:
                        View.Usuario.ListarUsuarios();
                        break;
                    case 5:
                        View.Perfil.CriarPerfil();
                        break;
                    case 6:
                        View.Perfil.ExcluirPerfil();
                        break;
                    case 7:
                        View.Perfil.ListarPerfis();
                        break;
                    case 8:
                        View.Sessao.Login();
                        break;
                    case 9:
                        View.Sessao.Logoff();
                        break;
                    case 10:
                        View.Sessao.ListarSessoes();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por utilizar nossos serviços!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}