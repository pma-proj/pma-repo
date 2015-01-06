USE [PMA_TEST]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[fcn_GetProjects]()
returns table
as
return(
	select PROJECT_ID as 'Id',
	PROJECT_NAME as 'Name',
	PROJECT_START_DATE as 'StartDate',
	PROJECT_END_DATE as 'EndDate',
	P.PROJECT_OWNER_ID as 'OwnerId',
	MEMBER_FIRST_NAME as 'OwnerFirstName',
	MEMBER_LAST_NAME as 'OwnerLastName'
	FROM PROJECT P
	INNER JOIN MEMBER M ON M.MEMBER_ID = P.PROJECT_OWNER_ID
);
GO

