
namespace Model;

    public class Usuario
    {
        public int id {get; set;}
        
        public string nome {get; set;}

        public string email {get; set;}

        public string senha {get; set;}

        public Usuario(int id, string nome, string email, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public override string ToString()
        {
            return $"Id: {id} Nome: {nome} Email: {email} Senha: {senha}";
        }

        public static List<Usuario> Usuarios {get; set;} = new List<Usuario>();

        public static Usuario BuscarUsuario(int id)
        {
          foreach (Usuario usuario in Usuarios)
        {
            if (Usuarios.id == id)
            {
                return usuario;
            }
        }

        throw new Exception("Sessão não encontrada");
        }

        public static void AlterarUsuario(int id, string nome, string email, string senha)
        {
            Usuario usuario = BuscarUsuario(id);
            usuario.nome = nome;
            usuario.email = email;
            usuario.senha = senha;
        }

        public static void ExcluirUsuario(int id)
        {
            Usuario usuario = BuscarUsuario(id);
            Usuarios.Remove(usuario);
        }


    }