CREATE TABLE [dbo].[Korinik] (
    [ID]                   INT             IDENTITY (1, 1) NOT NULL,
    [Korisnichko_Ime]      NVARCHAR (20)   NOT NULL,
    [Lozinka]              VARBINARY (MAX) NOT NULL,
    [Ime]                  NVARCHAR (20)   NOT NULL,
    [Prezime]              NVARCHAR (25)   NOT NULL,
    [Pol]                  NVARCHAR (1)    NOT NULL,
    [Studiska_Programa_ID] INT             NULL,
    [Organizacija_ID]      INT             NOT NULL,
    [Email]                NVARCHAR (MAX)  NOT NULL,
    [Telefonski_Broj]      NVARCHAR (13)   NULL,
    [Administrator]        BIT             NULL,
    [Student]              BIT             NULL,
    [Mentor]               BIT             NULL,
    CONSTRAINT [PK_Korinik] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [CK_Korinik_Pol] CHECK ([Pol]='М' OR [Pol]='Ж'),
    CONSTRAINT [CK_Korinik_Studiska_Programa_ID] CHECK ([Student]=(1) AND [Studiska_Programa_ID] IS NOT NULL OR [Studiska_Programa_ID] IS NULL),
    CONSTRAINT [FK_Korinik_Studiska_Programa] FOREIGN KEY ([Studiska_Programa_ID]) REFERENCES [dbo].[Studiska_Programa] ([ID])
);

