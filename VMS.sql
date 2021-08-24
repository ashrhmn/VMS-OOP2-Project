-- Database export via SQLPro (https://www.sqlprostudio.com/allapps.html)
-- Exported by ash at 24-08-2021 07:14.
-- WARNING: This file may contain descructive statements such as DROPs.
-- Please ensure that you are running the script at the proper location.


-- BEGIN TABLE dbo.candidates
IF OBJECT_ID('dbo.candidates', 'U') IS NOT NULL
DROP TABLE dbo.candidates;
GO

CREATE TABLE dbo.candidates (
	username nvarchar(50) NOT NULL
);
GO

ALTER TABLE dbo.candidates ADD CONSTRAINT PK_candidates PRIMARY KEY (username);
GO

-- Inserting 3 rows into dbo.candidates
-- Insert batch #1
INSERT INTO dbo.candidates (username) VALUES
('nil'),
('public1'),
('public2');

-- END TABLE dbo.candidates

-- BEGIN TABLE dbo.pending_signups
IF OBJECT_ID('dbo.pending_signups', 'U') IS NOT NULL
DROP TABLE dbo.pending_signups;
GO

CREATE TABLE dbo.pending_signups (
	username nvarchar(50) NOT NULL,
	password nvarchar(50) NULL
);
GO

-- Table dbo.pending_signups contains no data. No inserts have been genrated.
-- Inserting 0 rows into dbo.pending_signups


-- END TABLE dbo.pending_signups

-- BEGIN TABLE dbo.user_credentials
IF OBJECT_ID('dbo.user_credentials', 'U') IS NOT NULL
DROP TABLE dbo.user_credentials;
GO

CREATE TABLE dbo.user_credentials (
	username nvarchar(50) NOT NULL,
	password nvarchar(50) NULL,
	role nvarchar(50) NULL
);
GO

ALTER TABLE dbo.user_credentials ADD CONSTRAINT PK_users PRIMARY KEY (username);
GO

-- Inserting 24 rows into dbo.user_credentials
-- Insert batch #1
INSERT INTO dbo.user_credentials (username, password, role) VALUES
('aaa', 'zzz', 'General Public'),
('admin1', 'admin1', 'Admin'),
('admin2', 'admin2', 'Admin'),
('another', 'password', 'General Public'),
('ash', 'ash', 'Admin'),
('ashh', 'ashh', 'General Public'),
('manager1', 'manager1', 'District Manager'),
('manager2', 'manager2', 'District Manager'),
('manager3', 'manager3', 'District Manager'),
('new', 'new', 'District Manager'),
('nil', 'nila', 'General Public'),
('p1', 'p1', 'General Public'),
('p2', 'p2', 'General Public'),
('p3', 'p3', 'General Public'),
('p4', 'p4', 'General Public'),
('p5', 'p5', 'General Public'),
('p6', 'p6', 'General Public'),
('public1', 'public1', 'General Public'),
('public2', 'public2', 'General Public'),
('public4', 'public4', 'General Public'),
('public5', 'public5', 'General Public'),
('public6', 'public6', 'General Public'),
('public7', 'public7', 'General Public'),
('public8', 'public8', 'General Public');

-- END TABLE dbo.user_credentials

-- BEGIN TABLE dbo.user_details
IF OBJECT_ID('dbo.user_details', 'U') IS NOT NULL
DROP TABLE dbo.user_details;
GO

CREATE TABLE dbo.user_details (
	username nvarchar(50) NOT NULL,
	name nvarchar(50) NULL,
	gender nvarchar(50) NULL,
	address nvarchar(50) NULL,
	fatherName nvarchar(50) NULL,
	motherName nvarchar(50) NULL,
	dateOfBirth date NULL,
	nid nvarchar(50) NULL
);
GO

ALTER TABLE dbo.user_details ADD CONSTRAINT PK_user_details PRIMARY KEY (username);
GO

-- Inserting 13 rows into dbo.user_details
-- Insert batch #1
INSERT INTO dbo.user_details (username, name, gender, address, fatherName, motherName, dateOfBirth, nid) VALUES
('ash', 'Ashik', 'male', 'Shahzadpur, Sirajgonj', 'Daddy', 'Mommy', '1999-01-25 00:00:00', '19998826702000011'),
('ashh', '', '', '', '', '', '0001-01-03 00:00:00', '835478915'),
('new', 'New User', 'Other', 'Shahzadpur', 'New Father', 'New Mother', '1990-08-23 00:00:00', '4624523452345'),
('nil', 'Nil', 'Male', 'Shahzadpur, Sirajgonj', 'Daddy of Nil', 'Mommy of Nil', '1999-01-25 00:00:00', '435634563456'),
('p1', 'Pub1', 'Female', 'addpub1', 'fpub1', 'mpub1', '2021-08-23 00:00:00', '482567683'),
('p2', 'Pub2', 'Male', '', 'fPub2', 'mPub2', '2021-08-23 00:00:00', '536511211'),
('p3', '', '', '', '', '', '0001-01-03 00:00:00', '278761445'),
('p4', '', '', '', '', '', '0001-01-03 00:00:00', '855354268'),
('p5', '', '', '', '', '', '0001-01-03 00:00:00', '712558921'),
('p6', '', '', '', '', '', '0001-01-03 00:00:00', '769749181'),
('public1', 'Nil Rahman', 'Female', 'Shahzadpur', 'Nasir Uddin Ahmed', 'Amina Khatun', '2021-08-13 00:00:00', '081273480123874'),
('public2', 'Ash', 'Male', '', '', '', '2021-08-23 00:00:00', ''),
('public4', '', 'Male', '', '', '', '2021-08-23 00:00:00', '');

-- END TABLE dbo.user_details

-- BEGIN TABLE dbo.votes
IF OBJECT_ID('dbo.votes', 'U') IS NOT NULL
DROP TABLE dbo.votes;
GO

CREATE TABLE dbo.votes (
	username nvarchar(50) NOT NULL,
	candidate nvarchar(50) NULL
);
GO

ALTER TABLE dbo.votes ADD CONSTRAINT PK_votes PRIMARY KEY (username);
GO

-- Inserting 10 rows into dbo.votes
-- Insert batch #1
INSERT INTO dbo.votes (username, candidate) VALUES
('new', 'public1'),
('nil', 'public1'),
('p1', 'public1'),
('p2', 'public2'),
('p3', 'public1'),
('p4', 'public1'),
('p5', 'public2'),
('p6', 'nil'),
('public1', 'public1'),
('public2', 'public2');

-- END TABLE dbo.votes

