CREATE PROCEDURE [dbo].[sp_GetProducts]
@id UNIQUEIDENTIFIER
AS
	SELECT p.ProductId, p.ProductName, p.ProductPrice, p.MerchantId, m.MerchantName 
	FROM Products p
	INNER JOIN Merchants m
	ON m.MerchantId = p.MerchantId
	WHERE p.MerchantId = @id
RETURN 0
