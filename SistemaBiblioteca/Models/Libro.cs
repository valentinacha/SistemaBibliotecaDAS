public class Libro
{
    public int id { get; set; }
    public string titulo { get; set; }
    public string autor { get; set; }
    public int Anio { get; set; }

    public Libro(int id, string titulo, string autor, int Anio)
    {
        this.id = id;
        this.titulo = titulo;
        this.autor = autor;
        this.Anio = Anio;
    }
}