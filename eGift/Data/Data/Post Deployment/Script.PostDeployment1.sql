/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS( SELECT 1 FROM dbo.Merchants)
    BEGIN
        INSERT INTO dbo.Merchants (MerchantId,MerchantName) VALUES (default,'Play Station')
        INSERT INTO dbo.Merchants (MerchantId,MerchantName) VALUES (default,'Steam')
        INSERT INTO dbo.Merchants (MerchantId,MerchantName) VALUES (default,'Epic Games')

        DECLARE @merchantId as UNIQUEIDENTIFIER

        SELECT TOP(1) @merchantId =  MerchantId FROM dbo.Merchants 
        WHERE MerchantName = 'Play Station'

        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'PSN 20 usd', 20)
        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'PSN 50 usd', 50)
        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'PSN 100 usd', 100)

        SELECT TOP(1) @merchantId =  MerchantId FROM dbo.Merchants 
        WHERE MerchantName = 'Steam'

        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'Steam wallet 20 usd', 20)
        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'Steam wallet 50 usd', 50)
        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'Steam wallet 100 usd', 100)

        SELECT TOP(1) @merchantId =  MerchantId FROM dbo.Merchants 
        WHERE MerchantName = 'Epic Games'

        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'Epic 20 usd', 20)
        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'Epic 50 usd', 50)
        INSERT INTO dbo.Products (ProductId,MerchantId,ProductName,ProductPrice) VALUES (default,@merchantId,'Epic 100 usd', 100)
    END