USE [PMA_TEST]
GO

---------------------------------------------------------------------
-- TABLE ROLE
---------------------------------------------------------------------
INSERT INTO ROLE
(			
	ROLE_NAME
)
VALUES
(
	'Admin'
),
(
	'Project Manager'
),
(
	'Team Member'
)
GO

---------------------------------------------------------------------
-- TABLE MEMBER
---------------------------------------------------------------------
INSERT INTO MEMBER
(			
	MEMBER_LAST_NAME,	
	MEMBER_FIRST_NAME,	
	MEMBER_ADR,		
	MEMBER_POSTAL_CODE,	
	MEMBER_CITY,			
	MEMBER_BIRTHDATE,
	MEMBER_TEL,		
	MEMBER_MAIL_PRO,		
	MEMBER_PASSWORD,
	ROLE_ID
)
VALUES
(
	'Tresfield', 'Jason', '5 rue du 8 mai 1945', '69310',
	'Pierre-Bénite', '1991-04-18', '0400000000', 'jason.tresfield@cgi.com',
	'AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA5xW35mQDlUy5WYqWwVOq9AAAAAACAAAAAAAQZgAAAAEAACAAAABolUlb5+tLl2cDBUDFRKP0zvzI944pZtpoZMLmaVoREwAAAAAOgAAAAAIAACAAAADGSejYRvXatfDtm/sTJ2XNdmfFa6dg35WT6Jck3B87dhAAAABi8/lbUJ2wZhcf3NESNp5GQAAAAFbRFpKpHZRfN4TQw8k4ZMhlZcPPgaNB7/3xmVB86F59vzX0MclXCVszVB0aeOHPVPswnTpF+YU7o0oqz4Qcvvs=', 1
)
GO

---------------------------------------------------------------------
-- TABLE PROJECT
---------------------------------------------------------------------
INSERT INTO PROJECT
(
	PROJECT_NAME,
	PROJECT_START_DATE,
	PROJECT_END_DATE,
	PROJECT_OWNER_ID	
)
VALUES
(
	'CAROline', '2014-10-06', '2014-10-06', 1
)
GO


---------------------------------------------------------------------
-- TABLE ASSIGNMENT
---------------------------------------------------------------------
INSERT INTO ASSIGNMENT
(
	MEMBER_ID,
	PROJECT_ID,
	ASSIGNMENT_NAME,
	ASSIGNMENT_START_DATE	
)
VALUES
(
	1, 1, 'APP46Ter', '20150304'
),
(
	1, 1, 'Refonte Fiche Produit', '20141101'
)
GO

---------------------------------------------------------------------
-- TABLE TASK
---------------------------------------------------------------------
INSERT INTO TASK
(
	ASSIGNMENT_ID,
	TASK_NAME,
	TASK_START_DATE	
)
VALUES
(
	1, 'Rédaction STD', '20150304'
),
(
	1, 'Chiffrage détaillé', '20150305' 
),
(
	1, 'Rédaction des TUs', '20150309' 
),
(
	1, 'Développement', '20150311' 
),
(
	1, 'Exécution des TUs', '20150316' 
),
(
	1, 'Qualification', '20150318' 
)
GO

