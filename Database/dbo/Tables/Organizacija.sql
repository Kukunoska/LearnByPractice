CREATE TABLE [dbo].[Organizacija] (
    [ID]                  INT           IDENTITY (1, 1) NOT NULL,
    [Ime]                 NVARCHAR (255) NOT NULL,
    [Adresa]              NVARCHAR (255) NOT NULL,
    [Kontakt_Telefon]     NVARCHAR (16) NULL,
    [Veb_Strana]          NVARCHAR (50) NULL,
    [Vid_Organizacija_ID] INT           NOT NULL,
    CONSTRAINT [PK_Organizacija] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Organizacija_Vid_Organizacija] FOREIGN KEY ([Vid_Organizacija_ID]) REFERENCES [dbo].[Vid_Organizacija] ([ID]),
    CONSTRAINT [UK_Organizacija_Ime] UNIQUE NONCLUSTERED ([Ime] ASC)
);



