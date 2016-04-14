CREATE TABLE [dbo].[Tehnologija] (
    [ID]        INT           IDENTITY (1, 1) NOT NULL,
    [Ime]       NVARCHAR (50) NOT NULL,
    [Oblast_ID] INT           NOT NULL,
    CONSTRAINT [PK_Tehnologija] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Tehnologija_Oblast] FOREIGN KEY ([Oblast_ID]) REFERENCES [dbo].[Oblast] ([ID]),
    CONSTRAINT [UK_Tehnologija_Ime] UNIQUE NONCLUSTERED ([ID] ASC)
);




GO
CREATE NONCLUSTERED INDEX [IX_Tehnologija_Oblast_ID]
    ON [dbo].[Tehnologija]([ID] ASC);

