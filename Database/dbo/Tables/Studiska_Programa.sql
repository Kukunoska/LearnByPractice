CREATE TABLE [dbo].[Studiska_Programa] (
    [ID]  INT IDENTITY(1, 1) NOT NULL,
    [Ime] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Studiska_Programa] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UK_Studiska_Programa_Ime] UNIQUE NONCLUSTERED ([Ime] ASC)
);

