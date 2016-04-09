CREATE TABLE [dbo].[Prijava_Tehnologija] (
    [Prijava_ID]     INT NOT NULL,
    [Tehnologija_ID] INT NOT NULL,
    CONSTRAINT [PK_Prijava_Tehnologija] PRIMARY KEY CLUSTERED ([Prijava_ID] ASC, [Tehnologija_ID] ASC),
    CONSTRAINT [FK_Prijava_Tehnologija_Prijava] FOREIGN KEY ([Prijava_ID]) REFERENCES [dbo].[Prijava] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Prijava_Tehnologija_Tehnologija] FOREIGN KEY ([Tehnologija_ID]) REFERENCES [dbo].[Tehnologija] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);

