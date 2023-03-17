namespace Model;

public class Sessao
{
    public int id { get; set; }

    public Usuario idUser { get; set; }

    public string token { get; set; }

    public DateTime dataEntrada { get; set; }

    public DateTime dataSaida { get; set; }

    public static List<Sessoes> Sessoes { get; set; } = new List<Sessoes>();

    public Sessoes(int id, int idUser, string token, DateTime dataEntrada, DateTime dataSaida)
    {
        this.id = id;
        this.idUser = idUser;
        this.token = token;
        this.dataEntrada = dataEntrada;
        this.dataSaida = dataSaida;
    }

    public override string ToString()
    {
        return $"Id: {id} IdUser: {idUser} Token: {token} DataEntrada: {dataEntrada} DataSaida: {dataSaida}";
    }

    public static Sessoes BuscarSessao(int id)
    {
        foreach (Sessoes sessao in Sessoes)
        {
            if (sessao.id == id)
            {
                return sessao;
            }
        }

        throw new Exception("Sessão não encontrada");
    }


    public static void AlterarSessao(int id, int idUser, string token, DateTime dataEntrada, DateTime dataSaida)
    {
        Sessoes sessao = BuscarSessao(id);
        sessao.idUser = idUser;
        sessao.token = token;
        sessao.dataEntrada = dataEntrada;
        sessao.dataSaida = dataSaida;
    }

    public static void ExcluirSessao(int id)
    {
        Sessoes sessao = BuscarSessao(id);
        Sessoes.Remove(sessao);
    }







}

