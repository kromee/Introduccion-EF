namespace LeerData
{
    public class LibroAutor
    {
        public int AutorId {get;set;}
        public int LibroId {get;set;}
        public Libros? Libro {get;set;}
        public Autor? Autor {get;set;}
    }
}