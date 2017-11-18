CREATE PROCEDURE [dbo].[EliminarRegistro]	
	@ID bigint	
AS
BEGIN
	DELETE FROM Registros WHERE ID = @ID	
	RETURN 1
END