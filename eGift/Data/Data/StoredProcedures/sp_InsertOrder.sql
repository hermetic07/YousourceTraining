CREATE PROCEDURE [dbo].[sp_InsertOrder]
	@productId UNIQUEIDENTIFIER,
	@senderName NVARCHAR(500),
	@senderEmail NVARCHAR(500),
	@recipientName NVARCHAR(500),
	@recipientEmail NVARCHAR(500),
	@orderQuantity INT,
	@orderTotal MONEY
AS
	INSERT INTO [dbo].[Orders] (ProductId,SenderName,SenderEmail,RecipientName,RecipientEmail,OrderQuantity,OrderTotal)
	VALUES(@productId,@senderName,@senderEmail,@recipientName,@recipientEmail,@orderQuantity,@orderTotal)
RETURN 0
