namespace Controller;

    public class Perfil
    {
        public static void CadastrarPerfil(int id, Usuario idUser, string perfil)
        {
         
        
            int PerfilConvert = 0;
            try {
                PerfilConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            Model.Usuario usuario = new Model.Usuario(PerfilConvert, nome, email, senha);
        }

        public static void AlterarPerfil(int id, Usuario idUser, string perfil)
        {
            int PerfilConvert = 0;
            try {
                PerfilConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Usuario.AlterarUsuario(PerfilConvert, nome, email, senha);
        }

        public static void ExcluirPerfil(int id)
        {
            int PerfilConvert = 0;
            try {
                PerfilConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Usuario.ExcluirUsuario(PerfilConvert);
        }

        public static Model.Usuario BuscarPerfil(int id)
        {
            int PerfilConvert = 0;
            try {
                PerfilConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.Usuario.BuscarUsuario(PerfilConvert);
        }

        public static List<Model.Usuario> ListarPerfis()
        {
            return Model.Usuario.Usuarios;
        }

        
    }
