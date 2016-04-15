CREATE TABLE [dbo].[Prijava_Korisnik] (
    [Prijava_ID]  INT NOT NULL,
    [Korisnik_ID] INT NOT NULL,
    CONSTRAINT [PK_Prijava_Korisnik] PRIMARY KEY CLUSTERED ([Prijava_ID] ASC, [Korisnik_ID] ASC),
    CONSTRAINT [FK_Prijava_Korisnik_Korisnik] FOREIGN KEY ([Korisnik_ID]) REFERENCES [dbo].[Korisnik] ([ID]),
    CONSTRAINT [FK_Prijava_Korisnik_Prijava] FOREIGN KEY ([Prijava_ID]) REFERENCES [dbo].[Prijava] ([ID])
);






GO
CREATE NONCLUSTERED INDEX [IX_Prijava_Korisnik(KorisnikID,Prijava_ID)]
    ON [dbo].[Prijava_Korisnik]([Prijava_ID] ASC);

