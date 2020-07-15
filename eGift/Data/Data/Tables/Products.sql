CREATE TABLE [dbo].[Products] (
    [ProductId]   UNIQUEIDENTIFIER  NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [MerchantId]  UNIQUEIDENTIFIER  NOT NULL,
    [ProductName] NVARCHAR (500)    NULL,
    [ProductPrice] MONEY NULL, 
    CONSTRAINT [FK_Products_Merchants] FOREIGN KEY ([MerchantId]) REFERENCES [dbo].[Merchants] ([MerchantId])
);

