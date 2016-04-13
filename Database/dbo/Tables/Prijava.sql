CREATE TABLE [dbo].[Prijava] (
    [ID]              INT NOT NULL,
    [Organizacija_ID] INT NOT NULL,
    CONSTRAINT [PK_Prijava] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Prijava_Organizacija] FOREIGN KEY ([Organizacija_ID]) REFERENCES [dbo].[Organizacija] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);

