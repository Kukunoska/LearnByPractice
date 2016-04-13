CREATE TABLE [dbo].[Ocenka] (
    [Korisnik_ID] INT NOT NULL,
    [Predmet_ID]  INT NOT NULL,
    [Ocenka]      INT NOT NULL,
    CONSTRAINT [PK_Ocenka] PRIMARY KEY CLUSTERED ([Korisnik_ID] ASC, [Predmet_ID] ASC),
    CONSTRAINT [CK_Ocenka_Ocenka] CHECK ([Ocenka] like '[6-10]'),
    CONSTRAINT [FK_Ocenka_Korinik] FOREIGN KEY ([Korisnik_ID]) REFERENCES [dbo].[Korinik] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Ocenka_Predmet] FOREIGN KEY ([Predmet_ID]) REFERENCES [dbo].[Predmet] ([ID])
);

