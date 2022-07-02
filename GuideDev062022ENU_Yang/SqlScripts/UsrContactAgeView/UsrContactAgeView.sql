IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[UsrVwContactAgeDays]'))
DROP VIEW [dbo].[UsrVwContactAgeDays]
GO
CREATE VIEW [dbo].[UsrVwContactAgeDays]
AS
SELECT Id as UsrId,
		Name as UsrName,
		BirthDate as UsrBirthDate,
		datediff(DAY, BirthDate, getdate()) as UsrAgeDays
FROM [Contact]
GO