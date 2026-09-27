CREATE DATABASE NhlDb;
GO

USE NhlDb;
GO

CREATE TABLE NhlEmployee (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NhlName NVARCHAR(100) NOT NULL,
    NhlGender NVARCHAR(10) NULL,
    NhlBirthDay DATE NULL,
    NhlEmail VARCHAR(100) NULL,
    NhlPhone VARCHAR(20) NULL,
    NhlActive BIT DEFAULT 1
);