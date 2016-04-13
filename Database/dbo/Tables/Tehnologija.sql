CREATE TABLE [dbo].[Tehnologija] (
    [ID]        INT           NOT NULL,
    [Ime]       NVARCHAR (50) NOT NULL,
    [Oblast_ID] INT           NOT NULL,
    CONSTRAINT [PK_Tehnologija] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Tehnologija_Oblast] FOREIGN KEY ([Oblast_ID]) REFERENCES [dbo].[Oblast] ([ID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [UK_Tehnologija_Ime] UNIQUE NONCLUSTERED ([Ime] ASC),
    CONSTRAINT [UK_Tehnologija_Oblast_ID] UNIQUE NONCLUSTERED ([Oblast_ID] ASC)
);

