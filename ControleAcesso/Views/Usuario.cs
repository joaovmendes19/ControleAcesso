namespace View;

    public class Usuario
    {
        public static void CadastrarUsuario()
        {
            Console.WriteLine("Digite o id do usuario:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome do usuario:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuario:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario:");
            string senha = Console.ReadLine();
            try {
                Controller.Usuario.CadastrarUsuario(id, nome, email, senha);
                Console.WriteLine("Usuario cadastrado com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar usuario: {e.Message}");
            }
            

        }

        public static void AlterarUsuario()
        {
            Console.WriteLine("Digite o id do usuario:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome do usuario:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuario:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario:");
            string senha = Console.ReadLine();
            try {
                Controller.Usuario.AlterarUsuario(id, nome, email, senha);
                Console.WriteLine("Usuario alterado com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao alterar usuario: {e.Message}");
            }
        }

        public static void ExcluirUsuario()
        {
            Console.WriteLine("Digite o id do usuario:");
            string id = Console.ReadLine();
            try {
                Controller.Usuario.ExcluirUsuario(id);
                Console.WriteLine("Usuario excluído com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao excluir usuario: {e.Message}");
            }
        }

        public static void ListarUsuarios() {
            Console.WriteLine("Listar usuarios");
            foreach (Model.Usuario usuario in Controller.Usuario.ListarUsuarios()) {
                Console.WriteLine(usuario);
            }
        }
    }