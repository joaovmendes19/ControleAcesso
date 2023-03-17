namespace Controller;

    public class Usuario
    {
        public static void CadastrarUsuario(string id, string nome, string email, string senha)
        {
            int UserConvert = 0;
            try {
                UserConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            Model.Usuario usuario = new Model.Usuario(UserConvert, nome, email, senha);
        }
        
        public static void AlterarUsuario(string id, string nome, string email, string senha)
        {
            int UserConvert = 0;
            try {
                UserConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Usuario.AlterarUsuario(UserConvert, nome, email, senha);
        }

        public static void ExcluirUsuario(string id)
        {
            int UserConvert = 0;
            try {
                UserConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Usuario.ExcluirUsuario(UserConvert);
        }

        public static Model.Usuario BuscarUsuario(string id)
        {
            int UserConvert = 0;
            try {
                UserConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.Usuario.BuscarUsuario(UserConvert);
        }

        public static List<Model.Usuario> ListarUsuarios()
        {
            return Model.Usuario.Usuarios;
        }
    }