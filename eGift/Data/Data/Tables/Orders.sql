CREATE TABLE [dbo].[Orders] (
    [OrderId]        INT            NOT NULL,
    [ProductId]      INT            NULL,
    [SenderName]     NVARCHAR (100) NULL,
    [SenderEmail]    NVARCHAR (100) NULL,
    [RecipientName]  NVARCHAR (100) NULL,
    [RecipientEmail] NVARCHAR (100) NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Orders] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductId])
);

