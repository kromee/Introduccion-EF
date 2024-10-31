



ALTER TABLE Precios
ADD CONSTRAINT FK_PRECIO_LIBRO
FOREIGN KEY(LibroId)
REFERENCES Libros(LibroId)


insert into Libros (Titulo, Descripcion)
values ('fsfsf', 'ffff')
insert into Libros (Titulo, Descripcion)
values ('lklk', 'mmm')

insert INto precios (PrecioActual, promocion, libroId)
values (988, 88, 1 )

insert INto precios (PrecioActual, promocion, libroId)
values (400, 38, 2 )



CREATE TABLE Comentario
( comentarioId int identity (1,1) not null,
    alumno nvarchar (220) null, 
    puntaje int null, 
    comentariotexto nvarchar (500),
    libroId int
)

ALTER TABLE Comentario
    ADD CONSTRAINT FK_COMENTARIO_LIBRO
        FOREIGN KEY(LibroId) REFERENCES Libros(LibroId)


    insert into Comentario values ('Eduardo', 10, 'buen comentario', 1)
      insert into Comentario values ('Eduardo Martinez', 5, 'buen libro', 2)

      CREATE table autor (
autorid int IDENTITY(1,1) primary key not null,
        nombre NVARCHAR(300)  null, 
        apellidos NVARCHAR(400)  null,
        grado nvarchar(500) null,
        fotoperfil varbinary (max) null
      )


create TABLE libroautor(
    libroid INT,
    autorid int ,
    PRIMARY KEY (libroid, autorid)
)

ALTER TABLE LibroAutor
	ADD CONSTRAINT FK_LIBRO_AUTOR_AUTORID
		FOREIGN KEY(AutorId) REFERENCES Autor(AutorId)



ALTER TABLE LibroAutor
	ADD CONSTRAINT FK_LIBRO_AUTOR_LIBROID
		FOREIGN KEY(LibroId) REFERENCES Libro(LibroId)CREATE database LibrosEF
use LibrosEF
CREATE TABLE Libros(
    libroId int identity(1,1) PRIMARY key not null,
    Titulo NVARCHAR(200) not null,
    Descripcion NVARCHAR(1000) not null,
    FechaPublicacion DATETIME DEFAULT GETDATE() NULL,
    FotoPortada varbinary (max) null 
)

CREATE TABLE Precios
(
    precioid int identity(1,1) not null,
    PrecioActual money null,
    promocion money null,
    libroId int  null
)





ALTER TABLE LibroAutor
    ADD CONSTRAINT FK_LIBRO_AUTOR_AUTORID
        FOREIGN KEY(AutorId) REFERENCES Autor(AutorId)



ALTER TABLE LibroAutor
    ADD CONSTRAINT FK_LIBRO_AUTOR_LIBROID
        FOREIGN KEY(LibroId) REFERENCES Libro(LibroId)



        insert into autor (nombre, apellidos, grado)
values ('Eduardo', 'Martinez', 'Master')
insert into autor (nombre, apellidos, grado)
values ('Eduardo', 'Dominguez', 'Master')

INSERT into libroautor (libroid, autorid)
values (1, 1)
INSERT into libroautor (libroid, autorid)
values (1, 2)







