CREATE TABLE [dbo].[Korisnik] (
    [ID]                   INT             IDENTITY (1, 1) NOT NULL,
    [Korisnichko_Ime]      NVARCHAR (20)   NOT NULL,
    [Lozinka]              VARBINARY (255) NOT NULL,
    [Ime]                  NVARCHAR (20)   NOT NULL,
    [Prezime]              NVARCHAR (25)   NOT NULL,
    [Pol]                  NCHAR (1)       NOT NULL,
    [Studiska_Programa_ID] INT             NULL,
    [Organizacija_ID]      INT             NOT NULL,
    [Email]                NVARCHAR (255)  NOT NULL,
    [Telefonski_Broj]      NVARCHAR (13)   NULL,
    [Administrator]        BIT             NOT NULL,
    [Student]              BIT             NOT NULL,
    [Mentor]               BIT             NOT NULL,
    CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [CK_Korisnik_Pol] CHECK ([Pol]='М' OR [Pol]='Ж'),
    CONSTRAINT [CK_Korisnik_Studiska_Programa_ID] CHECK ([Student]=(1) AND [Studiska_Programa_ID] IS NOT NULL OR [Student]=(0) AND [Studiska_Programa_ID] IS NULL),
    CONSTRAINT [FK_Korisnik_Organizacija] FOREIGN KEY ([Organizacija_ID]) REFERENCES [dbo].[Organizacija] ([ID]),
    CONSTRAINT [FK_Korisnik_Studiska_Programa] FOREIGN KEY ([Studiska_Programa_ID]) REFERENCES [dbo].[Studiska_Programa] ([ID])
);







