CREATE TABLE [dbo].[Ocenka] (
    [Korisnik_ID]       INT           NOT NULL,
    [Shifra_Na_Predmet] NVARCHAR (10) NOT NULL,
    [Ocenka]            INT           NOT NULL,
    CONSTRAINT [PK_Ocenka] PRIMARY KEY CLUSTERED ([Korisnik_ID] ASC, [Shifra_Na_Predmet] ASC),
    CONSTRAINT [CK_Ocenka_Ocenka] CHECK ([Ocenka]>=(6) AND [Ocenka]<=(10)),
    CONSTRAINT [FK_Ocenka_Korisnik] FOREIGN KEY ([Korisnik_ID]) REFERENCES [dbo].[Korisnik] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Ocenka_Predmet] FOREIGN KEY ([Shifra_Na_Predmet]) REFERENCES [dbo].[Predmet] ([Shifra_Na_Predmet])
);







