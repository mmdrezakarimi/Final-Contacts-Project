CREATE DATABASE Contact
USE Contact

CREATE TABLE dbo.[User]
(
	Id INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY,
	Username VARCHAR(32) NOT NULL UNIQUE,
	Password BINARY(16) NOT NULL,
	Fullname VARCHAR(32) NOT NULL,
	Avatar VARCHAR(32)
)


CREATE TABLE dbo.Contact
(
	Id INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY,
	UserId INT NOT NULL FOREIGN KEY REFERENCES dbo.[User](Id),
	Fullname VARCHAR(32) NOT NULL,
	EMail VARCHAR(32),
	Avatar VARCHAR(32)
)

CREATE TABLE dbo.PhoneType
(
	Id TINYINT NOT NULL PRIMARY KEY,
	Title VARCHAR(32) NOT NULL
)

INSERT INTO dbo.PhoneType VALUES
(1, 'Home'), (2, 'Work'), (3, 'Mobile')

CREATE TABLE dbo.Phone
(
	Id INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY,
	ContactId INT NOT NULL FOREIGN KEY REFERENCES dbo.Contact(Id),
	PhoneTypeId TINYINT NOT NULL FOREIGN KEY REFERENCES dbo.PhoneType(Id),
	Number VARCHAR(32) NOT NULL
)

CREATE TABLE dbo.Favorite
(
	ContactId INT NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES dbo.Contact(Id)
)

CREATE TABLE dbo.[GroupsType]
(
Id INT NOT NULL PRIMARY KEY,
Title VARCHAR(32) NOT NULL
);

INSERT INTO dbo.GroupsType VALUES
(1, 'Family'), (2, 'Work'), (3, 'Friends'), (4, 'Gym') ,(5,'Others');

SELECT * FROM  dbo.Phone


INSERT INTO dbo.[User](Username,Password,Fullname) VALUES ('mmd2719',CONVERT(BINARY(16), '55422500'),'Mohammadrezakarimi');

INSERT INTO dbo.Contact(UserID,Fullname,EMail) VALUES (1000,'Mohammadrezakarimi','mohammadrezakarimi@gmail.com');
INSERT INTO dbo.[User](Username,Password,Fullname) VALUES ('mehdi4452',CONVERT(BINARY(16), '362890'),'MehdiNjfi');
INSERT INTO dbo.Contact(UserID,Fullname,EMail) VALUES (1001,'MehdiNjfi','mehdinjfi@gmail.com');
INSERT INTO dbo.Phone(ContactID,PhoneTypeId,Number) VALUES (1002,3,'09184753968');
INSERT INTO dbo.Phone(ContactID,PhoneTypeId,Number) VALUES (1003,3,'09184753968');