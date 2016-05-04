CREATE TABLE [dbo].[Ocenka] (
    [Korisnik_ID] INT NOT NULL,
    [Predmet_ID]  INT NOT NULL,
    [Ocenka]      INT NOT NULL,
    CONSTRAINT [PK_Ocenka] PRIMARY KEY CLUSTERED ([Korisnik_ID] ASC, [Predmet_ID] ASC),
    CONSTRAINT [CK_Ocenka_Ocenka] CHECK ([Ocenka]>=(6) AND [Ocenka]<=(10)),
<<<<<<< HEAD
    CONSTRAINT [FK_Ocenka_Korisnik] FOREIGN KEY ([Korisnik_ID]) REFERENCES [dbo].[Korisnik] ([ID]),
=======
    CONSTRAINT [FK_Ocenka_Korisnik] FOREIGN KEY ([Korisnik_ID]) REFERENCES [dbo].[Korisnik] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
>>>>>>> 971d64c46acb3e2bcde39c4614d495fc18b3d520
    CONSTRAINT [FK_Ocenka_Predmet] FOREIGN KEY ([Predmet_ID]) REFERENCES [dbo].[Predmet] ([ID])
);





<<<<<<< HEAD




=======
>>>>>>> 971d64c46acb3e2bcde39c4614d495fc18b3d520
