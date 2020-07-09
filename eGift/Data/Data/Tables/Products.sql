CREATE TABLE [dbo].[Products] (
    [ProductId]   INT            NOT NULL,
    [MerchantId]  INT            NULL,
    [ProductName] NVARCHAR (500) NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Products_Merchants] FOREIGN KEY ([MerchantId]) REFERENCES [dbo].[Merchants] ([MerchantId])
);

