using System.Data.SqlClient;
using Dapper;

public static class BD
{
    public static string _connectionString = @"Server=LOCALHOST;
    Database=Login;Trusted_Connection=True;";

    public static void AgregarUsuario(Usuario user)
    {
        string sql = "INSERT INTO Usuario(UserName, Contraseña, Nombre, Mail, Telefono) VALUES(@UserName, @Contraseña, @Nombre, @Mail, @Telefono)";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            BD.Execute(sql, new {UserName = user.UserName, Contraseña = user.Contraseña, Nombre = user.Nombre, Mail = user.Mail, Telefono = user.Telefono });
        }
    }

    public static Usuario TraerUsuario(string userName)
    {
        Usuario User = null;
        string nombre = null ;
        string mail = null ;
        string telefono = null ;
        string sql = "SELECT * FROM Usuario WHERE UserName = @userName ";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            User = BD.QueryFirstOrDefault<Usuario>(sql, new { userName });
        }
        return User;
    }

    public static bool Verificar(string userName, string contraseña)
    {
        string User = null;
        bool ok = false;
        string sql = "SELECT UserName FROM Usuario WHERE UserName = @userName AND Contraseña = @contraseña";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            User = BD.QueryFirstOrDefault<string>(sql, new { userName, contraseña });
        }
        if(userName == User)
        {
            ok = true;
        } else{
            ok = false;
        }
        return ok;
    }

    public static string TraerPorTel(string telefono)
    {
        string User = null;
        string sql = "SELECT UserName FROM Usuario WHERE Telefono = @telefono ";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            User = BD.QueryFirstOrDefault<string>(sql, new { telefono });
        }
        return User;
    }
}