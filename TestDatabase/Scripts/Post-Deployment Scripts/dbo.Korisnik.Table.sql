MERGE INTO [dbo].[Korisnik] AS[target]
USING
	(VALUES
		(
			N'Jasmina_K', 0x65B2464F2D2DAD5D319EDA267467E983E36BFAB6016B91C0F3CD9B70263C13178352E1C057D9757D1F03DA37692D7968, 
			N'Јасмина', N'Кукуноска', N'Ж', 1, 1, N'jasminakukunoska@gmail.com',000, 0, 1, 0
		),
		(
			N'Marija_K', 0x453A5093E3605249FBCF5FDCA571BCB8ECE54FD3400161DC560363A1226D14F79E31CD14EE74BD8F746FDD2329D94FFE,
			N'Марија', N'Кузмановска', N'Ж', 1, 1, N'marija.kuzmanocka@gmail.com',000, 0, 1, 0
		)
	)
	AS [source] (korisnichkoIme, lozinka, ime, prezime, pol, studiskaProgramaID, organizacijaID,
				 email, telefonskiBroj, administrator, student, mentor)
ON [target].Korisnichko_Ime = [source].korisnichkoIme
WHEN MATCHED THEN
	UPDATE SET [target].Korisnichko_Ime = [source].korisnichkoIme,
				[target].Lozinka = [source].lozinka,
				[target].Ime = [source].ime, 
				[target].Prezime = [source].prezime,
				[target].Pol = [source].pol,
				[target].Studiska_Programa_ID = [source].studiskaProgramaID,
				[target].Organizacija_ID = [source].organizacijaID,
				[target].Email = [source].email,
				[target].Telefonski_Broj = [source].telefonskiBroj,
				[target].Administrator = [source].administrator,
				[target].Student = [source].student,
				[target].Mentor = [source].mentor
WHEN NOT MATCHED BY TARGET THEN
	INSERT ([Korisnichko_Ime], [Lozinka], [Ime], [Prezime], [Pol], [Studiska_Programa_ID],
			[Organizacija_ID], [Email], [Telefonski_Broj], [Administrator], [Student], [Mentor])
		VALUES ([source].[korisnichkoIme], [source].[lozinka], [source].[ime], [source].[prezime],
				[source].[pol], [source].[studiskaProgramaID], [source].[organizacijaID],
				[source].[email], [source].[telefonskiBroj], [source].[administrator],
				[source].[student], [source].[mentor])
WHEN NOT MATCHED BY SOURCE THEN
	DELETE;