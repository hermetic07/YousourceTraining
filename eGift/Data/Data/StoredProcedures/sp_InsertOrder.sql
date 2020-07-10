CREATE PROCEDURE [dbo].[sp_InsertOrder]
	@productId UNIQUEIDENTIFIER,
	@senderName NVARCHAR(500),
	@senderEmail NVARCHAR(500),
	@recipientName NVARCHAR(500),
	@recipientEmail NVARCHAR(500)
AS
	INSERT INTO [dbo].[Orders] (ProductId,SenderName,SenderEmail,RecipientName,RecipientEmail)
	VALUES(@productId,@senderName,@senderEmail,@recipientName,@recipientEmail)
RETURN 0
