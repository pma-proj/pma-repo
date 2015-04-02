USE [PMA_TEST]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[fcn_GetRoleByMember]') AND xtype IN (N'FN', N'IF', N'TF'))
	DROP FUNCTION [dbo].[fcn_GetRoleByMember]
GO

CREATE FUNCTION [dbo].[fcn_GetRoleByMember](@Login varchar(80))
RETURNS TABLE
AS
RETURN
(
	SELECT 	MEMBER_ID,
	MEMBER_
	ROLE_NAME
	FROM	ROLE R
	INNER JOIN 	MEMBER M ON M.ROLE_ID = R.ROLE_ID
	WHERE 		MEMBER_MAIL_PRO = @Login
)
GO
