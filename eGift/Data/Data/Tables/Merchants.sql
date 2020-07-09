CREATE TABLE [dbo].[Merchants] (
    [MerchantId]   INT            NOT NULL,
    [MerchantName] NVARCHAR (500) NULL,
    CONSTRAINT [PK_Merchants] PRIMARY KEY CLUSTERED ([MerchantId] ASC)
);

