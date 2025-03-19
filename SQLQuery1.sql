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


INSERT INTO TicketTemplate2_Details 
    (TicketGuid, CompanyName, CompanyTelNo, PrimeReporter, PrimeReporterContact, PrimeReporterEmail, 
     PurchaseOrderNumber, Username, UserContactNo, UserEmail, SiteAddress, Make, Model, 
     ProductID, SerialNumber, UnderWarranty, WarrantyPackNumber, FaultDescription, PhysicalDamage)
VALUES 
    (NEWID(), 
     'Vega School', 
     '021 461 8089', 
     'Orrin Wilson', 
     '074 546 4722', 
     'owilson@vegaschool.com', 
     'PO123456', 
     'Owilson', 
     '074 546 4722', 
     'owilson@vegaschool.com', 
     '130 Strand Street, De Waterkant, Cape Town', 
     'HP', 
     '255 G9', 
     '6Q7Y7ES#ACQ', 
     'CND2331YWD', 
     1,  
     'WP123456', 
     'The laptop hinge is flexing when opening the lid, causing the screen bezel to detach from its groove.', 
     0); 
SELECT * FROM TicketTemplate2_Details;



INSERT INTO dbo.Tickets
    (TicketGuid, CompanyName, CompanyTelNo, PrimeReporter, PrimeReporterContact, PrimeReporterEmail,
     PurchaseOrderNumber, Username, UserContactNo, UserEmail, SiteAddress, Make, Model, 
     ProductID, SerialNumber, UnderWarranty, WarrantyPackNumber, FaultDescription, PhysicalDamage, 
     Campus, PrimaryContact, TroubleshooterName, TroubleshooterEmail, TroubleshooterContactNumber, 
     EquipmentMake, EquipmentModel, EquipmentProductNumber, EquipmentSerialNumber, TicketType)
VALUES
    (NEWID(), 
     'Vega School', 
     '021 461 8089', 
     'Orrin Wilson', 
     '074 546 4722', 
     'owilson@vegaschool.com', 
     'PO123456', 
     'Owilson', 
     '074 546 4722', 
     'owilson@vegaschool.com', 
     '130 Strand Street, De Waterkant, Cape Town', 
     'HP', 
     '255 G9', 
     '6Q7Y7ES#ACQ', 
     'CND2331YWD', 
     1,  
     'WP123456', 
     'The laptop hinge is flexing when opening the lid, causing the screen bezel to detach from its groove.', 
     0,
     'Rosebank College',  -- Example Campus
     1,  -- PrimaryContact: True
     'Sunnyboy Rasebeka',  -- Troubleshooter Name
     'srasebeka@rosebankcollege.co.za',  -- Troubleshooter Email
     '0123207270',  -- Troubleshooter Contact Number
     'HP',  -- Equipment Make
     '255 G9',  -- Equipment Model
     '6Q7Y7ES',  -- Equipment Product Number
     'CND3131JYG',  -- Equipment Serial Number
     'Template2'  -- Ticket Type (assuming this is for a Template2 ticket)
);

SELECT * FROM dbo.Tickets;



--------------------------------------------------------------------------------------------------------------

--										READ

USE CRUD;													-- TO USE THE CREATED DATABASE
SELECT DB_NAME(); 
SELECT @@SERVERNAME;

SELECT * FROM dbo.DocumentDetails;							-- VIEW TICKETS

SELECT * FROM dbo.TicketTemplate2_Details

SELECT * FROM dbo.Tickets

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

