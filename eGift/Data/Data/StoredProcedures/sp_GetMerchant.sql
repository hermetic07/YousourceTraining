CREATE PROCEDURE [dbo].[sp_GetMerchant]
	@id int
AS
	SELECT * FROM Merchants
	WHERE MerchantId = @id
RETURN 0
