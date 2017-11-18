CREATE table Registros
(

ID bigint primary key not null identity(1,1),

Nombre Nvarchar(100) NOT NULL,

Respuesta bigint NOT NULL,

FechaRegistro DATETIME2 NOT NULL

)

