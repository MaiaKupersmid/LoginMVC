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

    public static void AgregarUsuario(Usuario user)
    {
        string sql = "INSERT INTO Usuario(UserName, Contraseña, Nombre, Mail, Telefono) VALUES(@UserName, @Contraseña, @Nombre, @Mail, @Telefono)";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            BD.Execute(sql, new {UserName = user.UserName, Contraseña = user.Contraseña, Nombre = user.Nombre, Mail = user.Mail, Telefono = user.Telefono });
        }
    }
}