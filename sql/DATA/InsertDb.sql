USE [PMA_TEST]
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
	MEMBER_MAIL_PERSO
)
VALUES
(
	'Tresfield', 'Jason', '5 rue du 8 mai 1945', '69310',
	'Pierre-Bénite', '1991-04-18', '0400000000', 'jason.tresfield@cgi.com',
	'jason.tresfield@gmail.com'
),
(
	'Lebon', 'Arnaud', '23 rue des Chartreux', '69004',
	'Lyon', '1988-12-19', '0400000000', 'lebon.arnaud@outlook.com',
	'arnaud.lebon@gmail.com'
),
(
	'Scheppler', 'Alexandre', '', '69000',
	'Lyon', '1975-01-01', '0400000000', 'alexandre.scheppler@cgi.com',
	'alexandre.scheppler@gmail.com'
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
	'PMA', '2014-10-06', '2014-10-06', 1
),
(
	'GED', '2014-09-17', '2016-09-09', 2
),
(
	'CAROline', '2012-01-01', '2017-12-31', 3
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
	1, 3, 'APP46Ter', '20150304'
),
(
	1, 3, 'Refonte Fiche Produit', '20141101'
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

