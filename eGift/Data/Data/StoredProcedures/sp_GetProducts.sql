CREATE PROCEDURE [dbo].[sp_GetProducts]
AS
	SELECT p.ProductId, p.ProductName, p.MerchantId, m.MerchantName 
	FROM Products p
	INNER JOIN Merchants m
	ON m.MerchantId = p.MerchantId
RETURN 0
