USE [PMA_TEST]
GO

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
	'Lyon', '1988-12-19', '0400000000', 'arnaud.lebon@cgi.com',
	'arnaud.lebon@gmail.com'
)
GO

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
)
GO

