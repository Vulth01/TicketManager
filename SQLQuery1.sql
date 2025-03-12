-- Safety method, intentionally breaks to prevent user (me) from 
-- pressing F5 without selecting specific methods to run
RAISEERROR('Script stopped for safety; do not proceed further!', 16, 1);

CREATE TABLE user_account (
    id INT IDENTITY(1,1) PRIMARY KEY,  -- Use IDENTITY for auto-increment
    user_name VARCHAR(50) NOT NULL,     -- Correct VARCHAR usage
    password VARCHAR(255) NOT NULL,     -- Correct VARCHAR usage
    role VARCHAR(50) NOT NULL           -- Correct VARCHAR usage
);


CREATE DATABASE CRUD;

--Check that you are in the correct directory
SELECT DB_NAME();

SELECT @@SERVERNAME;

USE CRUD;


--View the cells in the table
SELECT * FROM dbo.DocumentDetails;

SELECT * FROM dbo.user_account;

SELECT * FROM dbo.__EFMigrationsHistory;


-- View all the tables in the current database
SELECT * 
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE';



-- Change the MaxCharLength of property
ALTER TABLE dbo.DocumentDetails
ALTER COLUMN FaultDescription NVARCHAR(200);

-- View the properties with their datatype and MaxCharLength
SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'DocumentDetails';





-- Add admin to table
INSERT INTO dbo.user_account (user_name, password, role)
VALUES ('admin1', 'pass1', 'Administrator');

SELECT * FROM dbo.user_account;



-- Add user to table
INSERT INTO dbo.user_account (user_name, password, role)
VALUES ('user1', 'user1', 'User');

SELECT * FROM dbo.user_account;


