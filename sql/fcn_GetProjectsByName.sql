USE [PMA_TEST]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[fcn_GetProjectsByName]') AND xtype IN (N'FN', N'IF', N'TF'))
	DROP FUNCTION [dbo].[fcn_GetProjectsByName]
GO

CREATE function [dbo].[fcn_GetProjectsByName](@Name varchar(50))
RETURNS TABLE
AS
RETURN 
(
	SELECT PROJECT_ID 	AS 'Id',
	PROJECT_NAME 		AS 'Name',
	PROJECT_START_DATE 	AS 'StartDate',
	PROJECT_END_DATE 	AS 'EndDate',
	P.PROJECT_OWNER_ID 	AS 'OwnerId',
	MEMBER_FIRST_NAME 	AS 'OwnerFirstName',
	MEMBER_LAST_NAME 	AS 'OwnerLastName'
	FROM PROJECT P
	INNER JOIN MEMBER M ON M.MEMBER_ID = P.PROJECT_OWNER_ID
	WHERE PROJECT_NAME = @Name
);

GO
