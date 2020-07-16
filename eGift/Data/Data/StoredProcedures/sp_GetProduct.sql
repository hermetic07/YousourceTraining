CREATE PROCEDURE [dbo].[sp_GetProduct]
	@id UNIQUEIDENTIFIER
AS
	SELECT TOP 1 p.ProductId, p.ProductName, p.ProductPrice, p.MerchantId, m.MerchantName 
	FROM Products p
	INNER JOIN Merchants m
	ON m.MerchantId = p.MerchantId
	WHERE p.ProductId = @id
RETURN 0
