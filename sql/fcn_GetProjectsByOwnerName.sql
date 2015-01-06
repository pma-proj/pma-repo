USE [PMA_TEST]
GO

/****** Object:  UserDefinedFunction [dbo].[fcn_GetProjectsByOwnerName]    Script Date: 01/02/2015 17:16:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE function [dbo].[fcn_GetProjectsByOwnerName](@FirstName varchar(30), @LastName varchar(40))
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
	WHERE MEMBER_FIRST_NAME LIKE '%' + @FirstName + '%'
	AND MEMBER_LAST_NAME LIKE '%' + @LastName + '%'
);

GO

