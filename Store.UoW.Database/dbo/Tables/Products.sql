CREATE TABLE [dbo].[Products] (
    [Id]    BIGINT       IDENTITY (1, 1) NOT NULL,
    [name]  VARCHAR (90) NULL,
    [price] DECIMAL (18) NOT NULL,
    [stock] INT          NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC)
);

