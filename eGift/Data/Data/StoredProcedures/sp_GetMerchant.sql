CREATE PROCEDURE [dbo].[sp_GetMerchant]
	@id UNIQUEIDENTIFIER
AS
	SELECT * FROM Merchants
	WHERE MerchantId = @id
RETURN 0
