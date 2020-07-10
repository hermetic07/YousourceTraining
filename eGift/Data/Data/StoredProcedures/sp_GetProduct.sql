CREATE PROCEDURE [dbo].[sp_GetProduct]
	@id UNIQUEIDENTIFIER
AS
	SELECT * FROM Products
	WHERE ProductId = @id
RETURN 0
