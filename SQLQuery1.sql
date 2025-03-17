-- Safety method, intentionally breaks to prevent user (me) from 
-- pressing F5 without selecting specific methods to run
RAISEERROR('Script stopped for safety; do not proceed further!', 16, 1);



--------------------------------------------------------------------------------------------------------------

--										CREATE



CREATE TABLE user_account (
    id INT IDENTITY(1,1) PRIMARY KEY,						-- PRIMARY KEY (INCREMENTAL)
    user_name VARCHAR(50) NOT NULL,							-- MAXLENGTH OF USERNAME
    password VARCHAR(255) NOT NULL,							-- MAXLENGTH OF PASSWORD
    role VARCHAR(50) NOT NULL								-- MAXLENGTH OF ROLE
);

CREATE DATABASE CRUD;										-- CREATE THE DATABASE

USE CRUD;													-- TO USE THE CREATED DATABASE

--------------------------------------------------------------------------------------------------------------

--										UPDATE



ALTER TABLE dbo.DocumentDetails								-- CHANGE MAXLENGTH OF PROPERTY
ALTER COLUMN FaultDescription NVARCHAR(200);

--------------------------------------------------------------------------------------------------------------

--										CREATE




INSERT INTO dbo.user_account (user_name, password, role)	-- ADD USER TO TABLE
VALUES ('admin1', 'pass1', 'Administrator');

INSERT INTO dbo.user_account (user_name, password, role)
VALUES ('user1', 'user1', 'User');


INSERT INTO user_account (guid, user_name, password, email, role)
VALUES (NEWID(), 'admin!', 'qwer1234', 'admin@administrator.com', 'Administrator');
SELECT * FROM dbo.user_account;

--------------------------------------------------------------------------------------------------------------

--										READ

USE CRUD;													-- TO USE THE CREATED DATABASE
SELECT DB_NAME(); 
SELECT @@SERVERNAME;

SELECT * FROM dbo.DocumentDetails;							-- VIEW TICKETS

SELECT * FROM dbo.user_account;								-- VIEW USERS

SELECT * FROM dbo.__EFMigrationsHistory;


SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH		-- VIEW PROP NAME + DATATYPE + MAXLENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'DocumentDetails';


															
SELECT *													-- VIEW ALL TABLES IN DATABASE
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE';

--------------------------------------------------------------------------------------------------------------

--										DELETE


DROP TABLE dbo.user_account

DELETE FROM dbo.user_account;

--------------------------------------------------------------------------------------------------------------

--										RECREATE

DROP TABLE dbo.user_account

--(guid, user_name, password, email, role)
CREATE TABLE dbo.user_account
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    guid UNIQUEIDENTIFIER NOT NULL,
    UserName NVARCHAR(MAX) NOT NULL,
    password NVARCHAR(100) NOT NULL,
    email NVARCHAR(100) NOT NULL,  
    role NVARCHAR(20) NOT NULL     
);
SELECT * FROM dbo.user_account;




INSERT INTO user_account (guid, UserName, password, email, role)
VALUES (NEWID(), 'admin!', 'qwer1234', 'admin@administrator.com', 'Administrator');
SELECT * FROM dbo.user_account;

