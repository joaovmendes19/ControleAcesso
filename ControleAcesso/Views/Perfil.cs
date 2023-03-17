namespace View;
public class Perfil
{
    public static void CadastrarPerfil()
    {
        Console.WriteLine("Digite o id do perfil:");
        string id = Console.ReadLine();
        Console.WriteLine("Digite o nome do perfil:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o tipo do perfil: U para usuário ou A para administrador:");
        string perfil = Console.ReadLine();
        try {
            Controller.Perfil.CadastrarPerfil(id, nome, perfil);
            Console.WriteLine("Perfil cadastrado com sucesso");
        } catch (Exception e) {
            Console.WriteLine($"Erro ao cadastrar perfil: {e.Message}");
        }
    }
    public static void AlterarPerfil()
    {
        Console.WriteLine("Digite o id do perfil:");
        string id = Console.ReadLine();
        Console.WriteLine("Digite o nome do perfil:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o tipo do perfil: U para usuário ou A para administrador:");
        string perfil = Console.ReadLine();
        try {
            Controller.Perfil.AlterarPerfil(id, nome, perfil);
            Console.WriteLine("Perfil alterado com sucesso");
        } catch (Exception e) {
            Console.WriteLine($"Erro ao alterar perfil: {e.Message}");
        }
    }
    public static void ExcluirPerfil()
    {
        Console.WriteLine("Digite o id do perfil:");
        string id = Console.ReadLine();
        try {
            Controller.Perfil.ExcluirPerfil(id);
            Console.WriteLine("Perfil excluído com sucesso");
        } catch (Exception e) {
            Console.WriteLine($"Erro ao excluir perfil: {e.Message}");
        }
    }

    public static void ListarPerfis() {
        Console.WriteLine("Listar perfis");
        foreach (Model.Perfil perfil in Controller.Perfil.ListarPerfis()) {
            Console.WriteLine(perfil);
        }
    }
}