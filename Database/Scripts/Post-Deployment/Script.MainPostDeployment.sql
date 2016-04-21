/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

:r .\dbo.Studiska_Programa.Table.sql
GO

:r .\dbo.Korisnik.Table.sql
GO

:r .\dbo.Predmet.Table.sql
GO

:r .\dbo.Ocenka.Table.sql
GO

:r .\dbo.Oblast.Table.sql
GO

:r .\dbo.Tehnologija.Table.sql
GO

:r .\dbo.Vid_Organizacija.Table.sql
GO

:r .\dbo.Organizacija.Table.sql
GO

:r .\dbo.Prijava.Table.sql
GO

:r .\dbo.Prijava_Korisnik.Table.sql
GO

:r .\dbo.Prijava_Tehnologija.Table.sql
GO

print 'Done deploying data'
