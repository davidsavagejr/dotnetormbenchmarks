CREATE TABLE People (
    Id UNIQUEIDENTIFIER NOT NULL,
    First VARCHAR(255) NULL,
    Last VARCHAR(255) NULL,
    Email VARCHAR(255) NULL,
    Address VARCHAR(255) NULL,
    City VARCHAR(255) NULL,
    State VARCHAR(50) NULL,
    Zip VARCHAR(10) NULL,
    Phone VARCHAR(100) NULL, 
    CONSTRAINT [PK_People] PRIMARY KEY ([Id])
);
GO

CREATE NONCLUSTERED INDEX [IX_People_Email] ON [dbo].[People] ([Email])
