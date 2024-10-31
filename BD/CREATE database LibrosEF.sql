CREATE database LibrosEF

CREATE TABLE Libros(
    libroId int identity(1,1) PRIMARY key not null,
    Descripcion NVARCHAR(1000) not null,
    FechaPublicacion DATETIME DEFAULT GETDATE() NULL,
    FotoPortada varbinary (max) null 
)

CREATE TABLE Precios
(
    precioid int identity(1,1) not null,
    promocion money null,
    libroId int  null
)



ALTER TABLE Precios
ADD CONSTRAINT FK_PRECIO_LIBRO
FOREIGN KEY(LibroId)
REFERENCES Libros(LibroId)
