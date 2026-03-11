public class Prestamo
{
    public int id { get; set; }
    public Usuario usuario { get; set; }
    public Libro libro { get; set; }
    public DateTime fechaPrestamo { get; set; }
    public DateTime fechaDevolucion { get; set; }

    public Prestamo(int id, Usuario usuario, Libro libro, DateTime fechaPrestamo, DateTime fechaDevolucion)
    {
        this.id = id;
        this.usuario = usuario;
        this.libro = libro;
        this.fechaPrestamo = fechaPrestamo;
        this.fechaDevolucion = fechaDevolucion;
    }
}