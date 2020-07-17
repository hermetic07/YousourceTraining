CREATE PROCEDURE [dbo].[sp_GetOrders]
AS
	SELECT o.OrderId, o.RecipientEmail, o.RecipientName, o.SenderEmail, o.SenderName, o.OrderQuantity, o.OrderMessage, o.OrderDate, p.ProductId, p.ProductName, p.ProductPrice, p.MerchantId, m.MerchantName 
	FROM Orders o
	INNER JOIN Products p
	ON p.ProductId = o.ProductId
	INNER JOIN Merchants m
	ON m.MerchantId = p.MerchantId
RETURN 0
