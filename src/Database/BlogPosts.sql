CREATE TABLE [dbo].[BlogPosts]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [PersonId] UNIQUEIDENTIFIER NOT NULL, 
    [Subject] NVARCHAR(50) NULL, 
    [Body] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_BlogPosts_ToPeople] FOREIGN KEY ([PersonId]) REFERENCES [People]([Id])
)
