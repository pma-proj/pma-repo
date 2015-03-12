USE [PMA_TEST]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[fcn_GetAssignmentsByMember]') AND xtype IN (N'FN', N'IF', N'TF'))
	DROP FUNCTION [dbo].[fcn_GetAssignmentsByMember]
GO

CREATE FUNCTION [dbo].[fcn_GetAssignmentsByMember]()
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
	MEMBER_LAST_NAME 		AS 'MemberLastName'
	FROM ASSIGNMENT A
	INNER JOIN MEMBER M ON M.MEMBER_ID = A.MEMBER_ID
);

GO
