CREATE TABLE [dbo].[Prijava_Korisnik] (
    [Prijava_ID]  INT NOT NULL,
    [Korisnik_ID] INT NOT NULL,
    CONSTRAINT [PK_Prijava_Korisnik] PRIMARY KEY CLUSTERED ([Prijava_ID] ASC, [Korisnik_ID] ASC),
    CONSTRAINT [FK_Prijava_Korisnik_Korisnik] FOREIGN KEY ([Korisnik_ID]) REFERENCES [dbo].[Korisnik] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Prijava_Korisnika_Prijava] FOREIGN KEY ([Prijava_ID]) REFERENCES [dbo].[Prijava] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);

