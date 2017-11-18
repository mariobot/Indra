CREATE PROCEDURE [dbo].[InsertarRegistro]
	@Nombre varchar(100),
	@Respuesta bigint,
	@FechaRegistro date
AS
BEGIN
	INSERT INTO Registros(Nombre,Respuesta,FechaRegistro)
	VALUES  (@Nombre,@Respuesta,@FechaRegistro)
	RETURN 1
END