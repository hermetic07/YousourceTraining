CREATE PROCEDURE [dbo].[sp_GetOrder]
	@id UNIQUEIDENTIFIER
AS
	SELECT TOP 1 o.OrderId, o.RecipientEmail, o.RecipientName, o.SenderEmail, o.SenderName, p.ProductId, p.ProductName, p.MerchantId, m.MerchantName 
	FROM Orders o
	INNER JOIN Products p
	ON p.ProductId = o.ProductId
	INNER JOIN Merchants m
	ON m.MerchantId = p.MerchantId
	WHERE p.ProductId = @id
RETURN 0
