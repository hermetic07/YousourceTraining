CREATE TABLE [dbo].[Merchants] (
    [MerchantId]   UNIQUEIDENTIFIER  NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [MerchantName] NVARCHAR (500)    NULL
);

