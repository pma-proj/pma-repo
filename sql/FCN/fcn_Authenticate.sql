USE [PMA_TEST]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[fcn_Authenticate]') AND xtype IN (N'FN', N'IF', N'TF'))
	DROP FUNCTION [dbo].[fcn_Authenticate]
GO

CREATE FUNCTION [dbo].[fcn_Authenticate](@Login varchar(80))
RETURNS TABLE
AS
RETURN
(
	SELECT 	MEMBER_ID				AS 'Id',
			MEMBER_LAST_NAME		AS 'LastName',
			MEMBER_FIRST_NAME		AS 'FirstName',	
			MEMBER_ADR				AS 'Address',
			MEMBER_POSTAL_CODE		AS 'PostalCode',
			MEMBER_CITY				AS 'City',
			MEMBER_BIRTHDATE		AS 'BirthDate',
			MEMBER_TEL				AS 'Telephone',
			MEMBER_MAIL_PRO			AS 'Mail',
			MEMBER_PASSWORD			AS 'Password',
	FROM	MEMBER
	WHERE 	MEMBER_MAIL_PRO = @Login
)

GO
