namespace View;

    public class Sessoes
    {
        public static void CadastrarSessao()
        {
        Console.WriteLine("Digite o id da sessao:");
        string id = Console.ReadLine();
        Console.WriteLine("Digite o id usuario:");
        string idUser = Console.ReadLine();
        Model.Usuario usuario = Controller.Usuario.BuscarUsuario(idUser);
        Console.WriteLine("Digite a data de login:");
        string perfil = Console.ReadLine();
        Console.WriteLine("Digite a data de logout:");
        string dataLogout = Console.ReadLine();
        try {
            Controller.Sessoes.CadastrarSessao(id, usuario, perfil, dataLogout);
            Console.WriteLine("Sessao cadastrada com sucesso");
        } catch (Exception e) {
            Console.WriteLine($"Erro ao cadastrar sessao: {e.Message}");
        }
        }

        public static void AlterarSessao()
        {
        Console.WriteLine("Digite o id da sessao:");
        string id = Console.ReadLine();
        Console.WriteLine("Digite o id usuario:");
        string idUser = Console.ReadLine();
        Model.Usuario usuario = Controller.Usuario.BuscarUsuario(idUser);
        Console.WriteLine("Digite a data de login:");
        string perfil = Console.ReadLine();
        Console.WriteLine("Digite a data de logout:");
        string dataLogout = Console.ReadLine();
        try {
            Controller.Sessoes.AlterarSessao(id, usuario, perfil, dataLogout);
            Console.WriteLine("Sessao alterada com sucesso");
        } catch (Exception e) {
            Console.WriteLine($"Erro ao alterar sessao: {e.Message}");
        }
        }

        public static void ExcluirSessao()
        {
        Console.WriteLine("Digite o id da sessao:");
        string id = Console.ReadLine();
        try {
            Controller.Sessoes.ExcluirSessao(id);
            Console.WriteLine("Sessao excluída com sucesso");
        } catch (Exception e) {
            Console.WriteLine($"Erro ao excluir sessao: {e.Message}");
        }
        }

        public static void ListarSessoes() {
        Console.WriteLine("Listar sessoes");
        foreach (Model.Sessoes sessao in Controller.Sessoes.ListarSessoes()) {
            Console.WriteLine(sessao);
        }
        }
        
        

      
        
    }