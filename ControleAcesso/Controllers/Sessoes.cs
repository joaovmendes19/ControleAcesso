namespace Controller;

    public class Sessoes
    {
        public static void CadastrarSessoes(string id, string nome)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            Model.Sessoes sessoes = new Model.Sessoes(idConvert, nome);
        }

        public static void AlterarSessoes(string id, string nome)
        {
            int SessoesConvert = 0;
            try {
                SessoesConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Sessoes.AlterarSessoes(SessoesConvert, nome);
        }

        public static void ExcluirSessoes(string id)
        {
            int SessoesConvert = 0;
            try {
                SessoesConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            Model.Sessoes.ExcluirSessoes(SessoesConvert);
        }

        public static Model.Sessoes BuscarSessoes(string id)
        {
            int SessoesConvert = 0;
            try {
                SessoesConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("Id inválido");
            }
            
            return Model.Sessoes.BuscarSessoes(SessoesConvert);
        }   

        public static List<Model.Sessoes> ListarSessoes()
        {
            return Model.Sessoes.Sessoes;
        }

    }