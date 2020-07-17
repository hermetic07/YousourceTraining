CREATE PROCEDURE [dbo].[sp_InsertOrder]
	@productId UNIQUEIDENTIFIER,
	@senderName NVARCHAR(500),
	@senderEmail NVARCHAR(500),
	@recipientName NVARCHAR(500),
	@recipientEmail NVARCHAR(500),
	@orderQuantity INT,
	@orderMessage TEXT
AS
	INSERT INTO [dbo].[Orders] (ProductId,SenderName,SenderEmail,RecipientName,RecipientEmail,OrderQuantity,OrderMessage)
	VALUES(@productId,@senderName,@senderEmail,@recipientName,@recipientEmail,@orderQuantity,@orderMessage)
RETURN 0
