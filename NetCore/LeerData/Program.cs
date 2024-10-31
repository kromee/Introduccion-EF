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

                // relacion de muchos a muchos

                /* var libros = db.Libros.Include(x => x.AutorLink).ThenInclude(xi => xi.Autor);

                 foreach (var libro in libros)
                 {
                     Console.WriteLine(libro.Titulo);
                     foreach (var autLink in libro.AutorLink)
                     {
                         Console.WriteLine("---- " + autLink.Autor.Nombre);
                     }
                 }*/


                //Insertar nuevo autor
                /*
                      var nuevoAutor1 = new Autor
                      {
                          Nombre = "Juan",
                          Apellidos = "Robles",
                          Grado = "Junior"
                      };
                      db.Add(nuevoAutor1);

                      var nuevoAutor2 = new Autor
                      {
                          Nombre = "Juana",
                          Apellidos = "Lima",
                          Grado = "Master"
                      };
                      db.Add(nuevoAutor2);

                      var estadoTransaccion = db.SaveChanges();
                      Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);
                */

                //Actualizar datos del autor
                /*var autor = db.Autor?.Single(x => x.Nombre == "Juan");
                if (autor != null)
                {
                    autor.Apellidos = "Lopez";
                    autor.Grado = "Programador";
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("Estado de transaccion ==> " + estadoTransaccion);
                }*/

                //eliminar autor
                var autor = db.Autor?.Single(x => x.AutorId == 1);
                if (autor != null) {
                    db.Remove(autor);
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("Estado de transaccion ==> " + estadoTransaccion);
                }
            }

        }
    }
}
