CREATE TABLE [dbo].[Vid_Organizacija] (
    [ID]  INT IDENTITY(1, 1) NOT NULL,
    [Ime] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Vid_Organizacija] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [UK_Vid_Organizacija_Ime] UNIQUE NONCLUSTERED ([Ime] ASC)
);

