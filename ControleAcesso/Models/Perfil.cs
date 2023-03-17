
namespace Model;

public class Perfis
{
    public int id { get; set; }

    public Usuario idUser { get; set; }

    public string Perfil { get; set; }

    public Perfil(int id, int idUser, string perfil)
    {
        this.id = id;
        this.idUser = idUser;
        this.Perfil = perfil;
    }

    public override string ToString()
    {
        return $"Id: {id} IdUser: {idUser} Perfil: {Perfil}";
    }

    public static List<Perfil> Perfis { get; set; } = new List<Perfil>();

    public static Perfil BuscarPerfil(int id)
    {
        foreach (Perfil perfil in Perfis)
        {
            if (perfil.id == id)
            {
                return perfil;
            }
        }

        throw new Exception("Sessão não encontrada");

    }


    public static void AlterarPerfil(int id, int idUser, string perfil)
    {
        Perfil perfil = BuscarPerfil(id);
        perfil.idUser = idUser;
        perfil.Perfil = perfil;
    }

    public static void ExcluirPerfil(int id)
    {
        Perfil perfil = BuscarPerfil(id);
        Perfis.Remove(perfil);
    }



}