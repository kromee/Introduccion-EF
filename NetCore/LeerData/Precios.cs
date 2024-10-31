using System.ComponentModel.DataAnnotations;

namespace LeerData
{
    public class Precios
    {
        [Key]
        public int PrecioId {get;set;}
        public decimal PrecioActual {get;set;}
        public decimal Promocion {get;set;}
        public int LibroId {get;set;}

        public Libros? Libros {get;set;}
    }
}