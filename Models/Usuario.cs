public class Usuario
{
    public string UserName {get; set;}
    public string Contraseña {get; set;}
    public string Nombre {get; set;}
    public string Mail {get; set;}
    public string Telefono {get; set;}

    public Usuario() { }

    public Usuario(string userName, string contraseña, string nombre, string mail, string telefono)
    {
        UserName = userName;
        Contraseña = contraseña;
        Nombre = nombre;
        Mail = mail;
        Telefono = telefono;
    }
}