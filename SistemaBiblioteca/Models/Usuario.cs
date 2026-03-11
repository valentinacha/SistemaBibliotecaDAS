public class Usuario
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string email { get; set; }

    public Usuario(int id, string nombre, string email)
    {
        this.id = id;
        this.nombre = nombre;
        this.email = email;
    }
}