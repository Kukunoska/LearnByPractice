CREATE TABLE [dbo].[Prijava] (
    [ID]                    INT  IDENTITY (1, 1) NOT NULL,
    [Organizacija_ID]       INT  NOT NULL,
    [Datum_Na_Prijavuvanje] DATETIME NOT NULL,
    CONSTRAINT [PK_Prijava] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Prijava_Organizacija] FOREIGN KEY ([Organizacija_ID]) REFERENCES [dbo].[Organizacija] ([ID])
);




GO
CREATE NONCLUSTERED INDEX [IX_Prijava_Organizacija_ID]
    ON [dbo].[Prijava]([ID] ASC);

