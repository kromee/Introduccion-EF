using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso EF Core 6");

            using (var db = new AppVentaLibrosContext())
            {
                //uso del AsNoTracking
                /* var libros = db.Libros?.Include(x => x.PrecioPromocion).AsNoTracking();
                 foreach (var libro in libros)
                 {
                     Console.WriteLine(libro.Titulo + " --- " + libro.PrecioPromocion?.PrecioActual);
                 }*/


                //Mostrando comentarios de los libros
                /* var libros = db.Libros?.Include(x => x.ComentarioLista).AsNoTracking();
                 foreach (var libro in libros)
                 {
                     Console.WriteLine(libro.Titulo);
                     foreach (var comentario in libro.ComentarioLista)
                     {
                         Console.WriteLine("----- " + comentario.ComentarioTexto);
                     }
                 }*/

                var libros = db.Libros.Include(x => x.AutorLink).ThenInclude(xi => xi.Autor);
                
                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.Titulo);
                    foreach (var autLink in libro.AutorLink)
                    {
                        Console.WriteLine("---- " + autLink.Autor.Nombre);
                    }
                }

            }
        }
    }
}
