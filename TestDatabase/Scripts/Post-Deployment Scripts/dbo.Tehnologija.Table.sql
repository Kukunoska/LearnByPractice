MERGE INTO [dbo].[Tehnologija] AS [target]
USING 
	(VALUES 
		(N'C#', 1), 
		(N'Java', 1)
	) 
	AS [source] (ime, oblastID)
ON [target].Ime = [source].ime
WHEN MATCHED THEN
	UPDATE SET [target].Ime = [source].ime, [target].Oblast_ID = [source].oblastID
WHEN NOT MATCHED BY TARGET THEN
	INSERT ([Ime],[Oblast_ID]) VALUES ([source].ime, [source].oblastID)
WHEN NOT MATCHED BY SOURCE THEN
	DELETE;