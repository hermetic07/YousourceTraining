CREATE TABLE [dbo].[Orders] (
    [OrderId]        UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [ProductId]      UNIQUEIDENTIFIER NOT NULL,
    [SenderName]     NVARCHAR (100) NULL,
    [SenderEmail]    NVARCHAR (100) NULL,
    [RecipientName]  NVARCHAR (100) NULL,
    [RecipientEmail] NVARCHAR (100) NULL,
    [OrderQuantity] INT NULL, 
    [OrderDate] DATETIME NULL DEFAULT GETDATE(), 
    [OrderMessage] TEXT NULL, 
    CONSTRAINT [FK_Orders_Orders] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductId])
);

