CREATE TABLE [dbo].[Korisnik] (
    [ID]                   INT           NOT NULL,
    [Korisnichko_Ime]      NVARCHAR (20) NOT NULL,
    [Lozinka]              NVARCHAR (15) NOT NULL,
    [Ime]                  NVARCHAR (20) NOT NULL,
    [Prezime]              NVARCHAR (15) NOT NULL,
    [Pol]                  NVARCHAR (1)  NOT NULL,
    [Studiska_Programa_ID] INT           NOT NULL,
    [Organizacija_ID]      INT           NOT NULL,
    [Email]                NVARCHAR (30) NOT NULL,
    [Telefonski_Broj]      NVARCHAR (13) NULL,
    CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [CK_Korisnik_Pol] CHECK ([Pol]=' Ж' OR [Pol]='М'),
    CONSTRAINT [FK_Korisnik_Organizacija] FOREIGN KEY ([Organizacija_ID]) REFERENCES [dbo].[Organizacija] ([ID]),
    CONSTRAINT [FK_Korisnik_Studiska_Programa] FOREIGN KEY ([Studiska_Programa_ID]) REFERENCES [dbo].[Studiska_Programa] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE
);

