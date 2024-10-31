using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeerData
{
    public class Libros

    {
        [Key]
        public int LibroId {get;set;}
        public string? Titulo {get;set;}
        public string? Descripcion {get;set;}
        public System.DateTime FechaPublicacion {get;set;}

        public Precios? PrecioPromocion {get;set;}
        public ICollection<Comentario>? ComentarioLista {get;set;}
        public ICollection<LibroAutor>? AutorLink {get;set;}
    }
}