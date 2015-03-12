USE [PMA_TEST]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[fcn_GetAssignments]') AND xtype IN (N'FN', N'IF', N'TF'))
	DROP FUNCTION [dbo].[fcn_GetAssignments]
GO

CREATE FUNCTION [dbo].[fcn_GetAssignments]()
RETURNS TABLE
AS
RETURN 
(
	SELECT ASSIGNMENT_ID 	AS 'Id',
	ASSIGNMENT_NAME			AS 'Name',
	ASSIGNMENT_START_DATE 	AS 'StartDate',
	ASSIGNMENT_END_DATE 	AS 'EndDate',
	A.MEMBER_ID 			AS 'MemberId',
	MEMBER_FIRST_NAME 		AS 'MemberFirstName',
	MEMBER_LAST_NAME 		AS 'MemberLastName',
	A.PROJECT_ID			AS 'ProjectId',
	PROJECT_NAME			AS 'ProjectName'
	FROM ASSIGNMENT A
	INNER JOIN MEMBER M 	ON M.MEMBER_ID = A.MEMBER_ID
	INNER JOIN PROJECT P 	ON P.PROJECT_ID = A.PROJECT_ID
);

GO
